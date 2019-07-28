// <copyright file="Main.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DestinyItemTagger
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Main Class.
    /// </summary>
    public partial class Main : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            this.InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string[][] destinyArmourPieces = Program.LoadArrayFromCSV(@"..\..\Data\destinyArmor.csv", true);
            string[][] armourPerkSets = Program.LoadArrayFromCSV(@"..\..\Data\ArmourPerkSets.csv", false);
            string[][] armourPerkRecommendations = Program.LoadArrayFromCSV(@"..\..\Data\ArmourPerkRecommendations.csv", false);
            string[][] taggedArmourList = Program.TagItems("Armour", destinyArmourPieces, armourPerkSets, armourPerkRecommendations);

            // TOOD: Check based on weapon type and change score column based on armout / weapons
            string[][] destinyWeapons = Program.LoadArrayFromCSV(@"..\..\Data\destinyWeapons.csv", true);
            string[][] weaponPerkSets = Program.LoadArrayFromCSV(@"..\..\Data\WeaponPerkSets.csv", false);
            string[][] weaponPerkRecommendations = Program.LoadArrayFromCSV(@"..\..\Data\WeaponPerkRecommendations.csv", false);
            string[][] taggedWeaponList = Program.TagItems("Weapons", destinyWeapons, weaponPerkSets, weaponPerkRecommendations);
        }
    }
}
