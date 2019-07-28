namespace DestinyItemTagger
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using Microsoft.VisualBasic.FileIO;

    /// <summary>
    /// Main Program, hold the main perk matching functions used by the UI.
    /// </summary>
    public static class Program
    {
        // Setup various column locations for data we need to get at
        private const int PerkSetTypeColumn = 0;
        private const int PerkRecommendationsTypeColumn = 0;
        private const int PerkRecommendationsNameColumn = 1;
        private const int PerkRecommendationsScoreColumn = 2;
        private const int ItemTypeColumn = 5;
        private const int ItemPerkStartColumn = 5;
        private const int ItemPerkEndOffset = 4;
        private const int ItemTagOffset = 3;
        private const int ItemPerkSetStatusOffset = 2;
        private const int ItemPerkRecommendationScoreOffset = 1;

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
        /// Tags items.
        /// </summary>
        /// <param name="destinyItems">Array of items.</param>
        /// <param name="perkSets">Array of perks.</param>
        /// <param name="typedPerkSet">Is the perk set type specific.</param>
        /// <param name="perkRecommendations">Array of Recommendations.</param>
        /// <param name="perkScoreTagLevel">Tag above this score.</param>
        /// <returns>Array of tagged items.</returns>
        public static string[][] TagItems(
                string[][] destinyItems,
                string[][] perkSets,
                bool typedPerkSet,
                string[][] perkRecommendations,
                int perkScoreTagLevel)
        {
            if (destinyItems is null)
            {
                throw new ArgumentNullException(nameof(destinyItems));
            }

            if (perkSets is null)
            {
                throw new ArgumentNullException(nameof(perkSets));
            }

            if (perkRecommendations is null)
            {
                throw new ArgumentNullException(nameof(perkRecommendations));
            }

            // Check each item
            string[][] taggedItems = Array.Empty<string[]>();
            foreach (string[] destinyItem in destinyItems)
            {
                // Take a copy of the item and add 3 columns to store the tag, perk set match status and perk recomendation score
                string[] taggedItem = destinyItem;
                Array.Resize(ref taggedItem, taggedItem.Length + 3);
                taggedItem[taggedItem.Length - 3] = string.Empty;

                // Check the items perk recommendation score
                CheckForRecomendedPerks(ref taggedItem, perkRecommendations, perkScoreTagLevel);

                // Check if the item has a perk set
                CheckForPerkSets(ref taggedItem, perkSets, typedPerkSet);

                // Finaly, Add the item to the array to be returned
                Array.Resize(ref taggedItems, taggedItems.Length + 1);
                taggedItems[taggedItems.Length - 1] = taggedItem;
            }

            return taggedItems;
        }

        private static void CheckForRecomendedPerks(ref string[] taggedItem, string[][] perkRecommendations, int perkScoreTagLevel)
        {
            // Go through each recommended perk.
            int perkScore = 0;
            foreach (string[] perkRecommendation in perkRecommendations)
            {
                // To see if we can find it.
                if (CheckForPerk(taggedItem, perkRecommendation[PerkRecommendationsTypeColumn], perkRecommendation[PerkRecommendationsNameColumn]))
                {
                    // And add its score onto the total if we can.
                    perkScore += Convert.ToInt32(perkRecommendation[PerkRecommendationsScoreColumn], CultureInfo.InvariantCulture);
                }
            }

            // Set the items perk recommendation score
            int perkScoreColumn = taggedItem.Length - ItemPerkRecommendationScoreOffset;
            taggedItem[perkScoreColumn] = perkScore.ToString(CultureInfo.InvariantCulture);

            // If the item exceeds that score level, tag it as a keeper.
            if (perkScore >= perkScoreTagLevel)
            {
                int perkTagColumn = taggedItem.Length - ItemTagOffset;
                taggedItem[perkTagColumn] = "keep";
            }
        }

        private static void CheckForPerkSets(ref string[] taggedItem, string[][] perkSets, bool typedPerkSet)
        {
            // Go through each perk set
            foreach (string[] perkSet in perkSets)
            {
                // Check if we need to match the type of the item as well as the perk
                string perkSetType;
                if (typedPerkSet)
                {
                    // We need to match the item type so use the item type from the perk set
                    perkSetType = perkSet[PerkSetTypeColumn];
                }
                else
                {
                    // We do not need to match the item type so use the items own type to ensure a match
                    perkSetType = taggedItem[ItemTypeColumn];
                }

                // Check each perk in the perk set
                bool perkSetMatch = true;
                foreach (string perk in perkSet)
                {
                    if (perk != perkSetType)
                    {
                        // Use a boolean AND to ensure that perkSetMatch will remain true only while all the perks in the set continue to be found
                        perkSetMatch = perkSetMatch & CheckForPerk(taggedItem, perkSetType, perk);
                    }
                }

                // Check if all the perks in the set matched
                if (perkSetMatch)
                {
                    // Set the perk set status column.
                    int perkSetColumn = taggedItem.Length - ItemPerkSetStatusOffset;
                    taggedItem[perkSetColumn] = "yes";

                    // Apply the favorite tag.
                    int perkTagColumn = taggedItem.Length - ItemTagOffset;
                    taggedItem[perkTagColumn] = "favorite";
                }
            }
        }

        private static bool CheckForPerk(string[] destinyItem, string type, string perk)
        {
            // Go through each perk on the item
            bool perkmatch = false;
            for (int perkColumn = ItemPerkStartColumn; perkColumn < destinyItem.Length - ItemPerkEndOffset; perkColumn++)
            {
                // Check if it matches the required perk
                if (type == destinyItem[ItemTypeColumn] && perk == destinyItem[perkColumn].Replace("*", string.Empty))
                {
                    perkmatch = true;
                }
            }

            return perkmatch;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Main mainForm = new Main())
            {
                Application.Run(mainForm: mainForm);
            }
        }
    }
}
