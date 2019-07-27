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
        public static string[][] TagArmour(
                string[][] destinyArmourPieces,
                string[][] perkSets,
                string[][] perkRecommendations)
        {
            string[][] taggedArmourPieces = Array.Empty<string[]>();
            foreach (string[] destinyArmourPiece in destinyArmourPieces)
            {
                string[] taggedArmourPiece = destinyArmourPiece;
                Array.Resize(ref taggedArmourPiece, taggedArmourPiece.Length + 2);

                CheckArmourForPerkSets(ref taggedArmourPiece, perkSets);
                CheckArmourForRecomendedPerks(ref taggedArmourPiece, perkRecommendations);

                Array.Resize(ref taggedArmourPieces, taggedArmourPieces.Length + 1);
                taggedArmourPieces[taggedArmourPieces.Length - 1] = taggedArmourPiece;
            }

            return taggedArmourPieces;
        }

        public static void CheckArmourForRecomendedPerks(ref string[] taggedArmourPiece, string[][] perkRecommendations)
        {
            const int armourArraryPerkScoreColumn = 36;
            const int PerkRecommendationsNameColumn = 0;
            const int PerkRecommendationsWeightColumn = 2;
            int perkScore = 0;
            foreach (string[] perkRecommendation in perkRecommendations)
            {
                if (CheckArmourForPerk(taggedArmourPiece, perkRecommendation[PerkRecommendationsNameColumn]))
                {
                    perkScore += Convert.ToInt32(perkRecommendation[PerkRecommendationsWeightColumn]);
                }
            }

            taggedArmourPiece[armourArraryPerkScoreColumn] = perkScore.ToString();
        }

        public static void CheckArmourForPerkSets(ref string[] taggedArmourPiece, string[][] perkSets)
        {
            const int matchedSetColumn = 35;
            bool perkSetMatch;
            foreach (string[] perkSet in perkSets)
            {
                perkSetMatch = true;
                foreach (string perk in perkSet)
                {
                    perkSetMatch = perkSetMatch & CheckArmourForPerk(taggedArmourPiece, perk);
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

        private static bool CheckArmourForPerk(string[] destinyArmour, string perk)
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
