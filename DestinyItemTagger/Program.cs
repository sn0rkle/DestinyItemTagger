// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DestinyItemTagger
{
    using System;
    using System.Windows.Forms;
    using Microsoft.VisualBasic.FileIO;

    internal static class Program
    {
        public static string[][] TagItems(
                string[][] destinyItems,
                string[][] perkSets,
                string[][] perkRecommendations)
        {
            string[][] taggedItems = Array.Empty<string[]>();
            foreach (string[] destinyItem in destinyItems)
            {
                string[] taggedItem = destinyItem;
                Array.Resize(ref taggedItem, taggedItem.Length + 2);

                CheckForPerkSets(ref taggedItem, perkSets);
                CheckForRecomendedPerks(ref taggedItem, perkRecommendations);

                Array.Resize(ref taggedItems, taggedItems.Length + 1);
                taggedItems[taggedItems.Length - 1] = taggedItem;
            }

            return taggedItems;
        }

        public static void CheckForRecomendedPerks(ref string[] taggedArmourPiece, string[][] perkRecommendations)
        {
            const int armourArraryPerkScoreColumn = 36;
            const int PerkRecommendationsNameColumn = 0;
            const int PerkRecommendationsWeightColumn = 2;
            int perkScore = 0;
            foreach (string[] perkRecommendation in perkRecommendations)
            {
                if (CheckForPerk(taggedArmourPiece, perkRecommendation[PerkRecommendationsNameColumn]))
                {
                    perkScore += Convert.ToInt32(perkRecommendation[PerkRecommendationsWeightColumn]);
                }
            }

            taggedArmourPiece[armourArraryPerkScoreColumn] = perkScore.ToString();
        }

        public static void CheckForPerkSets(ref string[] taggedArmourPiece, string[][] perkSets)
        {
            const int matchedSetColumn = 35;
            bool perkSetMatch;
            foreach (string[] perkSet in perkSets)
            {
                perkSetMatch = true;
                foreach (string perk in perkSet)
                {
                    perkSetMatch = perkSetMatch & CheckForPerk(taggedArmourPiece, perk);
                }

                if (perkSetMatch)
                {
                    taggedArmourPiece[matchedSetColumn] = "yes";
                }
                else
                {
                    taggedArmourPiece[matchedSetColumn] = "no";
                }
            }
        }

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
