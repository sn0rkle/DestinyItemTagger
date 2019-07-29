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

            // Fix the size of the window.
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Default Perk Score Levels.
            this.txtArmourPerkScoreLevel.Text = "3";
            this.txtWeaponPerkScoreLevel.Text = "3";

            // Default Current Power.
            this.txtCurrentPowerLevel.Text = "750";

            // Default Include Infusion.
            this.chkIncludeArmourForInfusion.Checked = true;
            this.chkIncludeWeaponsForInfusion.Checked = true;
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            // Tag the armour and add them to the lists
            this.TagArmour();

            // Tag the weapons and add them to the lists.
            this.TagWeapons();
        }

        private void TagArmour()
        {
            // Load the destiny armour items exported from DIM
            string[][] destinyArmourPieces = FileHelper.LoadArrayFromCSV(@"destinyArmor.csv", true);

            // Load the armour perk rules
            string[][] armourPerkSets = FileHelper.LoadArrayFromCSV(@"ArmourPerkSets.csv", false);
            string[][] armourPerkRecommendations = FileHelper.LoadArrayFromCSV(@"ArmourPerkRecommendations.csv", false);

            // Tag the armour based on the perk rules
            this.taggedArmourList = Program.TagItems(destinyArmourPieces, "Armour", this.txtCurrentPowerLevel.Text, armourPerkSets, false, armourPerkRecommendations, Convert.ToInt32(this.txtArmourPerkScoreLevel.Text));

            // Clear the armour lists
            this.listArmourForInfusion.Items.Clear();
            this.listArmourWithPerkSets.Items.Clear();
            this.listArmourWithPerkRecomendations.Items.Clear();

            // Add the tagged armour items to the correct list
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
        }

        private void TagWeapons()
        {
            // Load the destiny weapon items exported from DIM
            string[][] destinyWeapons = FileHelper.LoadArrayFromCSV(@"destinyWeapons.csv", true);

            // Load the weapon perk rules
            string[][] weaponPerkSets = FileHelper.LoadArrayFromCSV(@"WeaponPerkSets.csv", false);
            string[][] weaponPerkRecommendations = FileHelper.LoadArrayFromCSV(@"WeaponPerkRecommendations.csv", false);

            // Tag the weapons based on the perk rules
            this.taggedWeaponList = Program.TagItems(destinyWeapons, "Weapon", this.txtCurrentPowerLevel.Text, weaponPerkSets, true, weaponPerkRecommendations, Convert.ToInt32(this.txtWeaponPerkScoreLevel.Text));

            // Clear the weapons lists
            this.listWeaponsForInfusion.Items.Clear();
            this.listWeaponsWithPerkSets.Items.Clear();
            this.listWeaponsWithPerkRecommendations.Items.Clear();

            // Add the tagged armour items to the correct list
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
            // Export the tagged items to file.
            FileHelper.SaveArraysToFile(this.taggedArmourList, this.chkIncludeArmourForInfusion.Checked, this.taggedWeaponList, this.chkIncludeWeaponsForInfusion.Checked);

            // All done!
            MessageBox.Show(@"Export sucessfull", "DiT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
