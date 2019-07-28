// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DestinyItemTagger
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;
    using Microsoft.VisualBasic.FileIO;

    /// <summary>
    /// Main Program.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Tags items.
        /// </summary>
        /// <param name="itemType">Armour or Weapon.</param>
        /// <param name="destinyItems">Array of items.</param>
        /// <param name="perkSets">Array of perks.</param>
        /// <param name="perkRecommendations">Array of Recommendations.</param>
        /// <returns>Array of tagged items.</returns>
        public static string[][] TagItems(
                string itemType,
                string[][] destinyItems,
                string[][] perkSets,
                string[][] perkRecommendations)
        {
            string[][] taggedItems = Array.Empty<string[]>();
            foreach (string[] destinyItem in destinyItems)
            {
                string[] taggedItem = destinyItem;
                Array.Resize(ref taggedItem, taggedItem.Length + 2);

                CheckForPerkSets(itemType, ref taggedItem, perkSets);
                CheckForRecomendedPerks(itemType, ref taggedItem, perkRecommendations);

                Array.Resize(ref taggedItems, taggedItems.Length + 1);
                taggedItems[taggedItems.Length - 1] = taggedItem;
            }

            return taggedItems;
        }

        /// <summary>
        /// Load CSVFile.
        /// </summary>
        /// <param name="csvLocation">File location.</param>
        /// <param name="hasHeaderRow">Ignore first line.</param>
        /// <returns>Array of arrays.</returns>
        public static string[][] LoadArrayFromCSV(
            string csvLocation,
            bool hasHeaderRow)
        {
            using (TextFieldParser importParser = new TextFieldParser(csvLocation))
            {
                importParser.CommentTokens = new string[] { "#" };
                importParser.TextFieldType = FieldType.Delimited;
                importParser.SetDelimiters(",");
                if (hasHeaderRow)
                {
                    importParser.ReadFields();
                }

                string[][] dataArray = Array.Empty<string[]>();
                while (!importParser.EndOfData)
                {
                    Array.Resize(ref dataArray, dataArray.Length + 1);
                    dataArray[dataArray.Length - 1] = importParser.ReadFields();
                }

                return dataArray;
            }
        }

        private static void CheckForRecomendedPerks(string itemType, ref string[] taggedItem, string[][] perkRecommendations)
        {
            int perkScoreColumn;
            if (itemType == "Armour")
            {
                perkScoreColumn = 36;
            }
            else
            {
                perkScoreColumn = 39;
            }

            const int PerkRecommendationsNameColumn = 0;
            const int PerkRecommendationsScoreColumn = 1;
            int perkScore = 0;
            foreach (string[] perkRecommendation in perkRecommendations)
            {
                if (CheckForPerk(taggedItem, perkRecommendation[PerkRecommendationsNameColumn]))
                {
                    perkScore += Convert.ToInt32(perkRecommendation[PerkRecommendationsScoreColumn], CultureInfo.InvariantCulture);
                }
            }

            taggedItem[perkScoreColumn] = perkScore.ToString(CultureInfo.InvariantCulture);
        }

        private static void CheckForPerkSets(string itemType, ref string[] taggedItem, string[][] perkSets)
        {
            const int matchedSetColumn = 35;
            bool perkSetMatch;
            foreach (string[] perkSet in perkSets)
            {
                perkSetMatch = true;
                foreach (string perk in perkSet)
                {
                    perkSetMatch = perkSetMatch & CheckForPerk(taggedItem, perk);
                }

                if (perkSetMatch)
                {
                    taggedItem[matchedSetColumn] = "yes";
                }
                else
                {
                    taggedItem[matchedSetColumn] = "no";
                }
            }
        }

        private static bool CheckForPerk(string[] destinyArmour, string perk)
        {
            const int PerkStartColumn = 23;
            const int PerkEndColumn = 34;
            bool perkmatch = false;
            for (int perkColumn = PerkStartColumn; perkColumn < PerkEndColumn; perkColumn++)
            {
                if (perk == destinyArmour[perkColumn].Replace("*", string.Empty))
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
