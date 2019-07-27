using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace DestinyItemTagger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static string[][] tagArmour(string[][] destinyArmourPieces, string[][] perkSets, string[][] perkRecommendations)
        {
            string[][] taggedArmourPieces = new string[0][];
            foreach (string[] destinyArmourPiece in destinyArmourPieces)
            {
                string[] taggedArmourPiece = destinyArmourPiece;
                Array.Resize(ref taggedArmourPiece, taggedArmourPiece.Length + 2);

                checkArmourForPerkSets(ref taggedArmourPiece, perkSets);
                checkArmourForRecomendedPerks(ref taggedArmourPiece, perkRecommendations);

                Array.Resize(ref taggedArmourPieces, taggedArmourPieces.Length + 1);
                taggedArmourPieces[taggedArmourPieces.Length - 1] = taggedArmourPiece;
            }
            return taggedArmourPieces;
        }

        public static void checkArmourForRecomendedPerks(ref string[] taggedArmourPiece, string[][] perkRecommendations)
        {
            const int armourArraryPerkScoreColumn = 36;
            const int PerkRecommendationsNameColumn = 0;
            const int PerkRecommendationsWeightColumn = 2;
            int perkScore = 0;
            foreach (string[] perkRecommendation in perkRecommendations)
            {
                if (checkArmourForPerk(taggedArmourPiece, perkRecommendation[PerkRecommendationsNameColumn]))
                    { perkScore = perkScore + Convert.ToInt32(perkRecommendation[PerkRecommendationsWeightColumn]); }
            }
            taggedArmourPiece[armourArraryPerkScoreColumn] = perkScore.ToString();
        }

        public static void checkArmourForPerkSets(ref string[] taggedArmourPiece, string[][] perkSets)
        {
            const int matchedSetColumn = 35;
            bool perkSetMatch;
            // See if it matches a perk set
            foreach (string[] perkSet in perkSets)
            {
                perkSetMatch = true;
                foreach (string perk in perkSet)
                    { perkSetMatch = perkSetMatch & checkArmourForPerk(taggedArmourPiece, perk);  }

                if (perkSetMatch)
                    { taggedArmourPiece[matchedSetColumn] = "yes"; }
                else
                    { taggedArmourPiece[matchedSetColumn] = "no"; }
            }
        }

        private static bool checkArmourForPerk(String[] destinyArmour, string perk)
        {
            const int PerkStartColumn = 23;
            const int PerkEndColumn = 34;
            bool perkmatch = false;
            for (int perkColumn = PerkStartColumn; perkColumn < PerkEndColumn; perkColumn++)
            {
                if (perk == destinyArmour[perkColumn].Replace("*", ""))
                    { perkmatch = true; }
            }
            return perkmatch;
        }

        public static string[][] loadArrayFromCSV(string CSVLocation, bool HasHeaderRow)
        {
            using (TextFieldParser importParser = new TextFieldParser(CSVLocation))
            {
                importParser.CommentTokens = new string[] { "#" };
                importParser.TextFieldType = FieldType.Delimited;
                importParser.SetDelimiters(",");
                if (HasHeaderRow)
                    { importParser.ReadFields(); }
                string[][] dataArray = new string[0][];
                while (!importParser.EndOfData)
                {
                    Array.Resize(ref dataArray, dataArray.Length + 1);
                    dataArray[dataArray.Length - 1] = importParser.ReadFields();
                }
                return dataArray;
            }
        }
    }
}
