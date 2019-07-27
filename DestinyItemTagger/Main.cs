// <copyright file="Main.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DestinyItemTagger
{
    using System;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        public Main()
        {
            this.InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string[][] destinyArmourPieces = Program.LoadArrayFromCSV(@"..\..\Data\destinyArmor.csv", true);
            string[][] armourPerkSets = Program.LoadArrayFromCSV(@"..\..\Data\ArmourPerkSets.csv", false);
            string[][] armourPerkRecommendations = Program.LoadArrayFromCSV(@"..\..\Data\ArmourPerkRecommendations.csv", false);
            string[][] taggedArmourList = Program.TagItems(destinyArmourPieces, armourPerkSets, armourPerkRecommendations);

            string[][] destinyWeapons = Program.LoadArrayFromCSV(@"..\..\Data\destinyWeapons.csv", true);
            string[][] weaponPerkSets = Program.LoadArrayFromCSV(@"..\..\Data\WeaponPerkSets.csv", false);
            string[][] weaponPerkRecommendations = Program.LoadArrayFromCSV(@"..\..\Data\WeaponPerkRecommendations.csv", false);
            string[][] taggedWeaponList = Program.TagItems(destinyWeapons, weaponPerkSets, weaponPerkRecommendations);
        }
    }
}
