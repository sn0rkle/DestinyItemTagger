namespace DestinyItemTagger
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

    /// <summary>
    /// Main Program, hold the main perk matching functions used by the UI.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Tags items based on the supplied perk rules and settings.
        /// </summary>
        /// <param name="destinyItems">Array of items.</param>
        /// <param name="itemType">Type of items in the list.</param>
        /// <param name="powerLevel">Current Power Level.</param>
        /// <param name="perkSets">Array of perks.</param>
        /// <param name="typedPerkSet">Is the perk set type specific.</param>
        /// <param name="perkRecommendations">Array of Recommendations.</param>
        /// <param name="perkScoreTagLevel">Tag above this score.</param>
        /// <returns>Array of tagged items.</returns>
        public static string[][] TagItems(
                string[][] destinyItems,
                string itemType,
                string powerLevel,
                string[][] perkSets,
                bool typedPerkSet,
                string[][] perkRecommendations,
                int perkScoreTagLevel)
        {
            // Check each item
            string[][] taggedItems = Array.Empty<string[]>();
            foreach (string[] destinyItem in destinyItems)
            {
                // Take a copy of the item and add 3 columns to store the tag, perk set match status and perk recomendation score
                string[] taggedItem = destinyItem;
                Array.Resize(ref taggedItem, taggedItem.Length + ColumnPosition.ItemTagOffset);
                taggedItem[taggedItem.Length - ColumnPosition.ItemTagOffset] = string.Empty;

                // Check the item power level for infusion
                CheckForInfusion(ref taggedItem, itemType, powerLevel);

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

        // Tag items whos Power Level is the same or higher than the supplied Power Level.
        private static void CheckForInfusion(ref string[] taggedItem, string itemType, string powerLevel)
        {
            // Choose the right Power Level column based on the item type
            int itemPowerLevelColumn = 0;
            if (itemType == "Armour")
            {
                itemPowerLevelColumn = ColumnPosition.ItemArmourPowerLevel;
            }
            else if (itemType == "Weapon")
            {
                itemPowerLevelColumn = ColumnPosition.ItemWeaponPowerLevel;
            }

            // Check if the item mathes or is higher that the power level and tag it if it is.
            if (Convert.ToInt32(taggedItem[itemPowerLevelColumn]) >= Convert.ToInt32(powerLevel))
            {
                int perkTagColumn = taggedItem.Length - ColumnPosition.ItemTagOffset;
                taggedItem[perkTagColumn] = "infuse";
            }
        }

        // Tag items that have a Perk Recommendation Score higher than the Perk Score Level supplied.
        private static void CheckForRecomendedPerks(ref string[] taggedItem, string[][] perkRecommendations, int perkScoreTagLevel)
        {
            // Go through each recommended perk.
            int perkScore = 0;
            foreach (string[] perkRecommendation in perkRecommendations)
            {
                // To see if we can find it.
                if (CheckForPerk(taggedItem, perkRecommendation[ColumnPosition.PerkRecommendationsType], perkRecommendation[ColumnPosition.PerkRecommendationsName]))
                {
                    // And add its score onto the total if we can.
                    perkScore += Convert.ToInt32(perkRecommendation[ColumnPosition.PerkRecommendationsScore]);
                }
            }

            // Set the items perk recommendation score
            int perkScoreColumn = taggedItem.Length - ColumnPosition.ItemPerkRecommendationScoreOffset;
            taggedItem[perkScoreColumn] = perkScore.ToString(CultureInfo.InvariantCulture);

            // If the item exceeds that score level, tag it as a keeper.
            if (perkScore >= perkScoreTagLevel)
            {
                int perkTagColumn = taggedItem.Length - ColumnPosition.ItemTagOffset;
                taggedItem[perkTagColumn] = "keep";
            }
        }

        // Tag items which contain all the Perks in any Perk Set.
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
                    perkSetType = perkSet[ColumnPosition.PerkSetType];
                }
                else
                {
                    // We do not need to match the item type so use the items own type to ensure a match
                    perkSetType = taggedItem[ColumnPosition.ItemType];
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
                    int perkSetColumn = taggedItem.Length - ColumnPosition.ItemPerkSetStatusOffset;
                    taggedItem[perkSetColumn] = "yes";

                    // Apply the favorite tag.
                    int perkTagColumn = taggedItem.Length - ColumnPosition.ItemTagOffset;
                    taggedItem[perkTagColumn] = "favorite";
                }
            }
        }

        // Check if an item contains the Perk specified
        private static bool CheckForPerk(string[] destinyItem, string type, string perk)
        {
            // Go through each perk on the item
            bool perkmatch = false;
            for (int perkColumn = ColumnPosition.ItemPerkStart; perkColumn < destinyItem.Length - ColumnPosition.ItemPerkEndOffset; perkColumn++)
            {
                // Check if it matches the required perk
                if ((type == destinyItem[ColumnPosition.ItemType] || type == "All") && perk == destinyItem[perkColumn].Replace("*", string.Empty))
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
