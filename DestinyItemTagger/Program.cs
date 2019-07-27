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

        public static string[][] findPerkSetArmour(string[][] destinyArmourList, string CSVLocation)
        {
            // Load Perk Sets
            string[][] perkSets = loadArrayFromCSV(CSVLocation, false);
            string[][] perkSetArmour = new string[0][];

            bool perkSetMatch;
            // Check each peice of armour
            foreach (string[] destinyArmourPiece in destinyArmourList)
            {
                // See if it matches a perk set
                foreach (string[] perkSet in perkSets)
                {
                    // Check each perk in the set
                    perkSetMatch = true;
                    foreach (string perk in perkSet)
                    {
                        // If any perk on the perk set is not matched on the armour then the perk set does not match
                        perkSetMatch = perkSetMatch & checkArmourForPerk(destinyArmourPiece, perk);
                    }
                    // This armour matches a perk set!
                    if (perkSetMatch)
                    {
                        // Add it to our list of perk set matched armours
                        Array.Resize(ref perkSetArmour, perkSetArmour.Length + 1);
                        perkSetArmour[perkSetArmour.Length - 1] = destinyArmourPiece;
                    }
                }
            }
            // Return the matched armour
            return perkSetArmour;
        }

        public static string[][] findPerkRecommendedArmour(string[][] destinyArmourList, string CSVLocation, int armourWeightTriggerLevel)
        {
            // Load Perk Recomendations
            string[][] PerksRecommendations = loadArrayFromCSV(CSVLocation, false);
            string[][] perkRecommendedArmour = new string[0][];

            const int PerksRecommendationsNameColumn = 0;
            const int PerksRecommendationsWeightColumn = 1;

            // Check each peice of armour
            foreach (string[] destinyArmourPiece in destinyArmourList)
            {
                // For recommended perks
                int armourWeight = 0;
                foreach(string[] perkRecommendation in PerksRecommendations)
                {
                    // If it matches add to the total weighting of the armour
                    if(checkArmourForPerk(destinyArmourPiece, perkRecommendation[PerksRecommendationsNameColumn]))
                    {
                        armourWeight = armourWeight + Convert.ToInt32(perkRecommendation[PerksRecommendationsWeightColumn]);
                    }
                }
                // Check if this armour peice is heavy enough
                if(armourWeight > armourWeightTriggerLevel)
                {
                    // Copy the armour and add its weighting
                    string[] weightedArmourPiece = destinyArmourPiece;
                    Array.Resize(ref weightedArmourPiece, weightedArmourPiece.Length + 1);
                    weightedArmourPiece[weightedArmourPiece.Length - 1] = armourWeight.ToString();
                    // Add it to the array of perk recommended armours
                    Array.Resize(ref perkRecommendedArmour, perkRecommendedArmour.Length + 1);
                    perkRecommendedArmour[perkRecommendedArmour.Length - 1] = weightedArmourPiece;
                }
            }
            return perkRecommendedArmour;
        }

        public static string[][] loadArrayFromCSV(string CSVLocation, bool HasHeaderRow)
        {
            // Setup import file location
            using (TextFieldParser importParser = new TextFieldParser(CSVLocation))
            {
                // Define file format
                importParser.CommentTokens = new string[] { "#" };
                importParser.TextFieldType = FieldType.Delimited;
                importParser.SetDelimiters(",");
                // Skip header row if needed
                if (HasHeaderRow) { importParser.ReadFields(); }
                // Setup data array
                string[][] dataArray = new string[0][];
                // Read each line
                while (!importParser.EndOfData)
                {
                    // Add an array row
                    Array.Resize(ref dataArray, dataArray.Length + 1);
                    // Load array row items
                    dataArray[dataArray.Length - 1] = importParser.ReadFields();
                }
                // Return the data
                return dataArray;
            }
        }

        private static bool checkArmourForPerk(String[] destinyArmour, string perk)
        {
            const int PerkStartColumn = 23;
            const int PerkEndColumn = 34;
            // Check each armour perk
            bool perkmatch = false;
            for (int perkColumn = PerkStartColumn; perkColumn < PerkEndColumn; perkColumn++)
            {
                // To see if the perk matches
                if (perk == destinyArmour[perkColumn].Replace("*", "")) { perkmatch = true; }
            }
            return perkmatch;
        }


    }
}
