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
            string[][] perkSets = Program.LoadArrayFromCSV(@"..\..\Data\PerkSets.csv", false);
            string[][] perkRecommendations = Program.LoadArrayFromCSV(@"..\..\Data\PerkRecommendations.csv", false);

            string[][] taggedArmourList = Program.TagArmour(destinyArmourPieces, perkSets, perkRecommendations);
        }
    }
}
