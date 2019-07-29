namespace DestinyItemTagger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Constants for column numbers.
    /// </summary>
    internal class ColumnPosition
    {
        /// <summary>
        /// Perk Set column - Type.
        /// </summary>
        public const int PerkSetType = 0;

        /// <summary>
        /// Perk Recomendation column - Type.
        /// </summary>
        public const int PerkRecommendationsType = 0;

        /// <summary>
        /// Perk Recomendation column - Name.
        /// </summary>
        public const int PerkRecommendationsName = 1;

        /// <summary>
        /// Perk Recomendation column - Score.
        /// </summary>
        public const int PerkRecommendationsScore = 2;

        /// <summary>
        /// Item column - Hash.
        /// </summary>
        public const int ItemHash = 1;

        /// <summary>
        /// Item column - ID.
        /// </summary>
        public const int ItemID = 2;

        /// <summary>
        /// Item column - Type.
        /// </summary>
        public const int ItemType = 5;

        /// <summary>
        /// Item column - Perks start here.
        /// </summary>
        public const int ItemPerkStart = 5;

        /// <summary>
        /// Item column - Perks end this far from the end.
        /// </summary>
        public const int ItemPerkEndOffset = 4;

        /// <summary>
        /// Item column - Power Level for Weapons.
        /// </summary>
        public const int ItemWeaponPowerLevel = 7;

        /// <summary>
        /// Item column - Power Level for Armour.
        /// </summary>
        public const int ItemArmourPowerLevel = 8;

        /// <summary>
        /// Item column - Power Note for Armour.
        /// </summary>
        public const int ItemArmourNotes = 22;

        /// <summary>
        /// Item column - Power Note for Weapons.
        /// </summary>
        public const int ItemWeaponNotes = 31;

        /// <summary>
        /// Item column - Tag this far from the end.
        /// </summary>
        public const int ItemTagOffset = 3;

        /// <summary>
        /// Item column - Perk Set Status this far from the end.
        /// </summary>
        public const int ItemPerkSetStatusOffset = 2;

        /// <summary>
        /// Item column - Perk Recommendation Score this far from the end.
        /// </summary>
        public const int ItemPerkRecommendationScoreOffset = 1;
    }
}
