namespace DestinyItemTagger
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Main Class.
    /// </summary>
    public partial class Main : Form
    {
        private string[][] taggedArmourList;
        private string[][] taggedWeaponList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            this.InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.txtArmourPerkScoreLevel.Text = "3";
            this.txtWeaponPerkScoreLevel.Text = "3";
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string[][] destinyArmourPieces = Program.LoadArrayFromCSV(@"destinyArmor.csv", true);
            string[][] armourPerkSets = Program.LoadArrayFromCSV(@"ArmourPerkSets.csv", false);
            string[][] armourPerkRecommendations = Program.LoadArrayFromCSV(@"ArmourPerkRecommendations.csv", false);
            this.taggedArmourList = Program.TagItems(destinyArmourPieces, armourPerkSets, false, armourPerkRecommendations, Convert.ToInt32(this.txtArmourPerkScoreLevel.Text));

            this.listArmourWithPerkSets.Items.Clear();
            this.listArmourWithPerkRecomendations.Items.Clear();
            foreach (string[] taggedArmour in this.taggedArmourList)
            {
                if (taggedArmour[taggedArmour.Length - 2] == "yes")
                {
                    this.listArmourWithPerkSets.Items.Add(taggedArmour[0]);
                }

                if (Convert.ToInt32(taggedArmour[taggedArmour.Length - 1]) >= Convert.ToInt32(this.txtArmourPerkScoreLevel.Text))
                {
                    this.listArmourWithPerkRecomendations.Items.Add(taggedArmour[0] + " - " + taggedArmour[taggedArmour.Length - 1]);
                }
            }

            string[][] destinyWeapons = Program.LoadArrayFromCSV(@"destinyWeapons.csv", true);
            string[][] weaponPerkSets = Program.LoadArrayFromCSV(@"WeaponPerkSets.csv", false);
            string[][] weaponPerkRecommendations = Program.LoadArrayFromCSV(@"WeaponPerkRecommendations.csv", false);
            this.taggedWeaponList = Program.TagItems(destinyWeapons, weaponPerkSets, true, weaponPerkRecommendations, Convert.ToInt32(this.txtWeaponPerkScoreLevel.Text));

            this.listWeaponsWithPerkSets.Items.Clear();
            this.listWeaponsWithPerkRecommendations.Items.Clear();
            foreach (string[] taggedWeapon in this.taggedWeaponList)
            {
                if (taggedWeapon[taggedWeapon.Length - 2] == "yes")
                {
                    this.listWeaponsWithPerkSets.Items.Add(taggedWeapon[0]);
                }

                if (Convert.ToInt32(taggedWeapon[taggedWeapon.Length - 1]) >= Convert.ToInt32(this.txtWeaponPerkScoreLevel.Text))
                {
                    this.listWeaponsWithPerkRecommendations.Items.Add(taggedWeapon[0] + " - " + taggedWeapon[taggedWeapon.Length - 1]);
                }
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"dimImport.csv"))
            {
                foreach (string[] taggedWeapon in this.taggedWeaponList)
                {
                    file.WriteLine(taggedWeapon[1] + "," + taggedWeapon[2] + "," + taggedWeapon[taggedWeapon.Length - 3] + "," + taggedWeapon[22]);
                }
            }

            MessageBox.Show(@"Export sucessfull", "DiT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
