namespace DestinyItemTagger
{
    using System;
    using System.IO;
    using Microsoft.VisualBasic.FileIO;

    /// <summary>
    /// Load and Save CSV Files.
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// Small helper routint the UI uses to load csv files into arrays.
        /// </summary>
        /// <param name="csvLocation">CSV file location.</param>
        /// <param name="hasHeaderRow">Ignore first line.</param>
        /// <returns>Jagged array loaded from the csv file.</returns>
        public static string[][] LoadArrayFromCSV(
            string csvLocation,
            bool hasHeaderRow)
        {
            using (TextFieldParser importParser = new TextFieldParser(csvLocation))
            {
                // Setup the file format
                importParser.CommentTokens = new string[] { "#" };
                importParser.TextFieldType = FieldType.Delimited;
                importParser.SetDelimiters(",");

                // Skip header row if needed.
                if (hasHeaderRow)
                {
                    importParser.ReadFields();
                }

                // Load the file into a jagged array a line at a time.
                string[][] dataArray = Array.Empty<string[]>();
                while (!importParser.EndOfData)
                {
                    Array.Resize(ref dataArray, dataArray.Length + 1);
                    dataArray[dataArray.Length - 1] = importParser.ReadFields();
                }

                return dataArray;
            }
        }

        /// <summary>
        /// Save tagged items to CSV.
        /// </summary>
        /// <param name="taggedArmourList">List of armour.</param>
        /// <param name="includeArmourInfuse">Include infuse armour.</param>
        /// <param name="taggedWeaponList">List of weapons.</param>
        /// <param name="includeWeaponInfuse">Include infuse weapon.</param>
        public static void SaveArraysToFile(string[][] taggedArmourList, bool includeArmourInfuse, string[][] taggedWeaponList, bool includeWeaponInfuse)
        {
            if (taggedArmourList is null)
            {
                throw new ArgumentNullException(nameof(taggedArmourList));
            }

            if (taggedWeaponList is null)
            {
                throw new ArgumentNullException(nameof(taggedWeaponList));
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"dimImport.csv"))
            {
                file.WriteLine("Hash,Id,Tag,Notes");
                foreach (string[] taggedArmour in taggedArmourList)
                {
                    string itemExportTag;
                    if (taggedArmour[taggedArmour.Length - ColumnPosition.ItemTagOffset] == "infuse" && !includeArmourInfuse)
                    {
                        itemExportTag = string.Empty;
                    }
                    else
                    {
                        itemExportTag = taggedArmour[taggedArmour.Length - ColumnPosition.ItemTagOffset];
                    }

                    file.WriteLine(taggedArmour[ColumnPosition.ItemHash] + "," + taggedArmour[ColumnPosition.ItemID] + "," + itemExportTag + "," + taggedArmour[ColumnPosition.ItemArmourNotes]);
                }

                foreach (string[] taggedWeapon in taggedWeaponList)
                {
                    string itemExportTag;
                    if (taggedWeapon[taggedWeapon.Length - ColumnPosition.ItemTagOffset] == "infuse" && !includeWeaponInfuse)
                    {
                        itemExportTag = string.Empty;
                    }
                    else
                    {
                        itemExportTag = taggedWeapon[taggedWeapon.Length - ColumnPosition.ItemTagOffset];
                    }

                    file.WriteLine(taggedWeapon[ColumnPosition.ItemHash] + "," + taggedWeapon[ColumnPosition.ItemID] + "," + itemExportTag + "," + taggedWeapon[ColumnPosition.ItemWeaponNotes]);
                }
            }
        }
    }
}
