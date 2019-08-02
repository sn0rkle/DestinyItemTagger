using System;

[assembly: CLSCompliant(true)]

namespace DestinyItemTagger
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    /// <summary>
    /// Main Class.
    /// </summary>
    public partial class Main : Form
    {
        private string[][] taggedArmourList;
        private string[][] taggedWeaponList;
        private bool initFinished = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            this.InitializeComponent();
            using (Splash splashForm = new Splash())
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "\\destinyArmor.csv"))
                {
                    this.Launch = true;
                    splashForm.SendMessage(this.Launch, @"destinyArmour.csv found...");
                }
                else
                {
                    splashForm.SendMessage(this.Launch, "!! destinyArmour.csv not found !! - download from DIM");
                }

                if (File.Exists(@"destinyWeapons.csv"))
                {
                    this.Launch = this.Launch && true;
                    splashForm.SendMessage(this.Launch, @"destinyWeapons.csv found...");
                }
                else
                {
                    splashForm.SendMessage(this.Launch, "!! destinyWeapons.csv not found !! - download from DIM");
                }

                if (this.Launch == true)
                {
                    splashForm.SetButtonText("Launch");
                }
                else
                {
                    splashForm.SetButtonText("Exit");
                }

                splashForm.ShowDialog();

                if (this.Launch == true)
                {
                    // Default Perk Score Levels.
                    this.txtArmourPerkScoreLevel.Text = "3";
                    this.txtWeaponPerkScoreLevel.Text = "3";

                    // Default Current Power.
                    this.txtCurrentPowerLevel.Text = "750";

                    // Default Include Infusion.
                    this.chkIncludeArmourForInfusion.Checked = true;
                    this.chkIncludeWeaponsForInfusion.Checked = true;

                    // Init is done!
                    this.initFinished = true;

                    // Tag the armour and add them to the lists
                    this.TagArmour();

                    // Tag the weapons and add them to the lists.
                    this.TagWeapons();
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether to launch the application.
        /// </summary>
        public bool Launch
        { get; set; }

        private void TagArmour()
        {
            // Load the destiny armour items exported from DIM
            string[][] destinyArmourPieces = Array.Empty<string[]>();
            try
            {
                destinyArmourPieces = FileHelper.LoadArrayFromCSV(@"destinyArmor.csv", true);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(@"Unable to find destinyArmour.csv.  Please make sure this has been downloaded from DIM and placed in the same folder as this application.", "DiT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                if (taggedArmour[taggedArmour.Length - ColumnPosition.ItemTagOffset] == "infuse" && this.chkIncludeArmourForInfusion.Checked)
                {
                    this.listArmourForInfusion.Items.Add(taggedArmour[0]);
                }

                if (taggedArmour[taggedArmour.Length - ColumnPosition.ItemTagOffset] == "keep")
                {
                    this.listArmourWithPerkRecomendations.Items.Add(taggedArmour[0] + " - " + taggedArmour[taggedArmour.Length - ColumnPosition.ItemPerkRecommendationScoreOffset]);
                }

                if (taggedArmour[taggedArmour.Length - ColumnPosition.ItemTagOffset] == "favorite")
                {
                    this.listArmourWithPerkSets.Items.Add(taggedArmour[0]);
                }
            }
        }

        private void TagWeapons()
        {
            // Load the destiny weapon items exported from DIM
            string[][] destinyWeapons = Array.Empty<string[]>();
            try
            {
                destinyWeapons = FileHelper.LoadArrayFromCSV(@"destinyWeapons.csv", true);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(@"Unable to find destinyWeapons.csv.  Please make sure this has been downloaded from DIM and placed in the same folder as this application.", "DiT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                if (taggedWeapon[taggedWeapon.Length - ColumnPosition.ItemTagOffset] == "infuse" && this.chkIncludeWeaponsForInfusion.Checked)
                {
                    this.listWeaponsForInfusion.Items.Add(taggedWeapon[0]);
                }

                if (taggedWeapon[taggedWeapon.Length - ColumnPosition.ItemTagOffset] == "keep")
                {
                    this.listWeaponsWithPerkRecommendations.Items.Add(taggedWeapon[0] + " - " + taggedWeapon[taggedWeapon.Length - ColumnPosition.ItemPerkRecommendationScoreOffset]);
                }

                if (taggedWeapon[taggedWeapon.Length - ColumnPosition.ItemTagOffset] == "favorite")
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

        private void TxtCurrentPowerLevel_TextChanged(object sender, EventArgs e)
        {
            if (this.initFinished)
            {
                // Tag the armour and add them to the lists
                this.TagArmour();

                // Tag the weapons and add them to the lists.
                this.TagWeapons();
            }
        }

        private void ChkIncludeArmourForInfusion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.initFinished)
            {
                // Tag the armour and add them to the lists
                this.TagArmour();
            }
        }

        private void ChkIncludeWeaponsForInfusion_CheckedChanged(object sender, EventArgs e)
        {
            if (this.initFinished)
            {
                // Tag the weapons and add them to the lists.
                this.TagWeapons();
            }
        }

        private void TxtArmourPerkScoreLevel_TextChanged(object sender, EventArgs e)
        {
            if (this.initFinished)
            {
                // Tag the armour and add them to the lists.
                this.TagArmour();
            }
        }

        private void TxtWeaponPerkScoreLevel_TextChanged(object sender, EventArgs e)
        {
            if (this.initFinished)
            {
                // Tag the weapons and add them to the lists.
                this.TagWeapons();
            }
        }
    }
}