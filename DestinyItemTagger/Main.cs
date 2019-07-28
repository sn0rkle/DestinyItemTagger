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
            this.txtCurrentPowerLevel.Text = "750";
            this.chkIncludeArmourForInfusion.Checked = true;
            this.chkIncludeWeaponsForInfusion.Checked = true;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string[][] destinyArmourPieces = Program.LoadArrayFromCSV(@"destinyArmor.csv", true);
            string[][] armourPerkSets = Program.LoadArrayFromCSV(@"ArmourPerkSets.csv", false);
            string[][] armourPerkRecommendations = Program.LoadArrayFromCSV(@"ArmourPerkRecommendations.csv", false);
            this.taggedArmourList = Program.TagItems(destinyArmourPieces, "Armour", this.txtCurrentPowerLevel.Text, armourPerkSets, false, armourPerkRecommendations, Convert.ToInt32(this.txtArmourPerkScoreLevel.Text));

            this.listArmourForInfusion.Items.Clear();
            this.listArmourWithPerkSets.Items.Clear();
            this.listArmourWithPerkRecomendations.Items.Clear();
            foreach (string[] taggedArmour in this.taggedArmourList)
            {
                if (taggedArmour[taggedArmour.Length - 3] == "infuse")
                {
                    this.listArmourForInfusion.Items.Add(taggedArmour[0]);
                }

                if (taggedArmour[taggedArmour.Length - 3] == "keep")
                {
                    this.listArmourWithPerkRecomendations.Items.Add(taggedArmour[0] + " - " + taggedArmour[taggedArmour.Length - 1]);
                }

                if (taggedArmour[taggedArmour.Length - 3] == "favorite")
                {
                    this.listArmourWithPerkSets.Items.Add(taggedArmour[0]);
                }
            }

            string[][] destinyWeapons = Program.LoadArrayFromCSV(@"destinyWeapons.csv", true);
            string[][] weaponPerkSets = Program.LoadArrayFromCSV(@"WeaponPerkSets.csv", false);
            string[][] weaponPerkRecommendations = Program.LoadArrayFromCSV(@"WeaponPerkRecommendations.csv", false);
            this.taggedWeaponList = Program.TagItems(destinyWeapons, "Weapon", this.txtCurrentPowerLevel.Text, weaponPerkSets, true, weaponPerkRecommendations, Convert.ToInt32(this.txtWeaponPerkScoreLevel.Text));

            this.listWeaponsForInfusion.Items.Clear();
            this.listWeaponsWithPerkSets.Items.Clear();
            this.listWeaponsWithPerkRecommendations.Items.Clear();
            foreach (string[] taggedWeapon in this.taggedWeaponList)
            {
                if (taggedWeapon[taggedWeapon.Length - 3] == "infuse")
                {
                    this.listWeaponsForInfusion.Items.Add(taggedWeapon[0]);
                }

                if (taggedWeapon[taggedWeapon.Length - 3] == "keep")
                {
                    this.listWeaponsWithPerkRecommendations.Items.Add(taggedWeapon[0] + " - " + taggedWeapon[taggedWeapon.Length - 1]);
                }

                if (taggedWeapon[taggedWeapon.Length - 3] == "favorite")
                {
                    this.listWeaponsWithPerkSets.Items.Add(taggedWeapon[0]);
                }
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            // TODO: Move this into Program and pass include infuse weapons and armour flags
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"dimImport.csv"))
            {
                file.WriteLine("Hash,Id,Tag,Notes");
                foreach (string[] taggedArmour in this.taggedArmourList)
                {
                    string itemTag;
                    if (taggedArmour[taggedArmour.Length - 3] == "infuse" && !this.chkIncludeArmourForInfusion.Checked)
                    {
                        itemTag = string.Empty;
                    }
                    else
                    {
                        itemTag = taggedArmour[taggedArmour.Length - 3];
                    }

                    file.WriteLine(taggedArmour[1] + "," + taggedArmour[2] + "," + taggedArmour[taggedArmour.Length - 3] + "," + taggedArmour[22]);
                }

                foreach (string[] taggedWeapon in this.taggedWeaponList)
                {
                    string itemTag;
                    if (taggedWeapon[taggedWeapon.Length - 3] == "infuse" && !this.chkIncludeWeaponsForInfusion.Checked)
                    {
                        itemTag = string.Empty;
                    }
                    else
                    {
                        itemTag = taggedWeapon[taggedWeapon.Length - 3];
                    }
                    file.WriteLine(taggedWeapon[1] + "," + taggedWeapon[2] + "," + taggedWeapon[taggedWeapon.Length - 3] + "," + taggedWeapon[31]);
                }
            }

            MessageBox.Show(@"Export sucessfull", "DiT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
