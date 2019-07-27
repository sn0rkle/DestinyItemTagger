using System;
using System.Windows.Forms;

namespace DestinyItemTagger
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string[][] destinyArmourPieces = Program.loadArrayFromCSV(@"..\..\Data\destinyArmor.csv", true);
            string[][] perkSets = Program.loadArrayFromCSV(@"..\..\Data\PerkSets.csv", false);
            string[][] perkRecommendations = Program.loadArrayFromCSV(@"..\..\Data\PerkRecommendations.csv", false);

            string[][] taggedArmourList = Program.tagArmour(destinyArmourPieces, perkSets, perkRecommendations);
        }
    }
}
