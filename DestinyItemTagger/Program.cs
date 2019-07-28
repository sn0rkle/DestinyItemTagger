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
        /// <param name="destinyItems">Array of items.</param>
        /// <param name="perkSets">Array of perks.</param>
        /// <param name="typedPerkSet">Is the perk set type specific.</param>
        /// <param name="perkRecommendations">Array of Recommendations.</param>
        /// <returns>Array of tagged items.</returns>
        public static string[][] TagItems(
                string[][] destinyItems,
                string[][] perkSets,
                bool typedPerkSet,
                string[][] perkRecommendations)
        {
            string[][] taggedItems = Array.Empty<string[]>();
            foreach (string[] destinyItem in destinyItems)
            {
                string[] taggedItem = destinyItem;
                Array.Resize(ref taggedItem, taggedItem.Length + 2);

                CheckForPerkSets(ref taggedItem, perkSets, typedPerkSet);
                CheckForRecomendedPerks(ref taggedItem, perkRecommendations);

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

        private static void CheckForRecomendedPerks(ref string[] taggedItem, string[][] perkRecommendations)
        {
            const int PerkRecommendationsTypeColumn = 0;
            const int PerkRecommendationsNameColumn = 1;
            const int PerkRecommendationsScoreColumn = 2;
            int perkScore = 0;
            foreach (string[] perkRecommendation in perkRecommendations)
            {
                if (CheckForPerk(taggedItem, perkRecommendation[PerkRecommendationsTypeColumn], perkRecommendation[PerkRecommendationsNameColumn]))
                {
                    perkScore += Convert.ToInt32(perkRecommendation[PerkRecommendationsScoreColumn], CultureInfo.InvariantCulture);
                }
            }

            int perkScoreColumn = taggedItem.Length - 1;
            taggedItem[perkScoreColumn] = perkScore.ToString(CultureInfo.InvariantCulture);
        }

        private static void CheckForPerkSets(ref string[] taggedItem, string[][] perkSets, bool typedPerkSet)
        {
            const int PerkRecommendationsTypeColumn = 0;
            const int PerkTypeColumn = 5;
            bool perkSetMatch;
            string perkSetType;

            foreach (string[] perkSet in perkSets)
            {
                if (typedPerkSet)
                {
                    perkSetType = perkSet[PerkRecommendationsTypeColumn];
                }
                else
                {
                    perkSetType = taggedItem[PerkTypeColumn];
                }

                perkSetMatch = true;
                foreach (string perk in perkSet)
                {
                    if (perk != perkSetType)
                    {
                        perkSetMatch = perkSetMatch & CheckForPerk(taggedItem, perkSetType, perk);
                    }
                }

                int matchedSetColumn = taggedItem.Length - 2;
                if (perkSetMatch)
                {
                    taggedItem[matchedSetColumn] = "yes";
                }
            }
        }

        private static bool CheckForPerk(string[] destinyItem, string type, string perk)
        {
            int perkTypeColumn = 5;
            int perkStartColumn = 6;
            int perkEndColumn = destinyItem.Length - 2;

            bool perkmatch = false;
            for (int perkColumn = perkStartColumn; perkColumn < perkEndColumn; perkColumn++)
            {
                if (type == destinyItem[perkTypeColumn] && perk == destinyItem[perkColumn].Replace("*", string.Empty))
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
