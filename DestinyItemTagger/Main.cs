using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

      
            // Load Destiny Armour
            string[][] destinyArmourList = Program.loadArrayFromCSV(@"..\..\Data\destinyArmor.csv", true);

            listPerkSets.Items.Clear();
            string[][] perkSetArmour = Program.findPerkSetArmour(destinyArmourList, @"..\..\Data\PerkSets.csv");
            foreach(string [] destinyArmourPiece in perkSetArmour)
            {
                listPerkSets.Items.Add(destinyArmourPiece[0]);
            }

            listPerkReccomendations.Items.Clear();
            string[][] perkRecommendedArmour = Program.findPerkRecommendedArmour(destinyArmourList, @"..\..\Data\PerksRecommendations.csv", Convert.ToInt32(txtWeightTrigger.Text));
            foreach (string[] destinyArmourPiece in perkRecommendedArmour)
            {
                listPerkReccomendations.Items.Add(destinyArmourPiece[0]);
            }
            
        }
    }
}
