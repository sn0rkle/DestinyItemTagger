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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.txtArmourPerkScoreLevel.Text = "3";
            this.txtWeaponPerkScoreLevel.Text = "3";
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            string[][] destinyArmourPieces = Program.LoadArrayFromCSV(@"..\..\Data\destinyArmor.csv", true);
            string[][] armourPerkSets = Program.LoadArrayFromCSV(@"..\..\Data\ArmourPerkSets.csv", false);
            string[][] armourPerkRecommendations = Program.LoadArrayFromCSV(@"..\..\Data\ArmourPerkRecommendations.csv", false);
            string[][] taggedArmourList = Program.TagItems(destinyArmourPieces, armourPerkSets, false, armourPerkRecommendations);

            this.listArmourWithPerkSets.Items.Clear();
            this.listArmourWithPerkRecomendations.Items.Clear();
            foreach (string[] taggedArmour in taggedArmourList)
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

            string[][] destinyWeapons = Program.LoadArrayFromCSV(@"..\..\Data\destinyWeapons.csv", true);
            string[][] weaponPerkSets = Program.LoadArrayFromCSV(@"..\..\Data\WeaponPerkSets.csv", false);
            string[][] weaponPerkRecommendations = Program.LoadArrayFromCSV(@"..\..\Data\WeaponPerkRecommendations.csv", false);
            string[][] taggedWeaponList = Program.TagItems(destinyWeapons, weaponPerkSets, true, weaponPerkRecommendations);

            this.listWeaponsWithPerkSets.Items.Clear();
            this.listWeaponsWithPerkRecommendations.Items.Clear();
            foreach (string[] taggedWeapon in taggedWeaponList)
            {
                if (taggedWeapon[taggedWeapon.Length - 2] == "yes")
                {
                    this.listWeaponsWithPerkSets.Items.Add(taggedWeapon[0]);
                }

                if (Convert.ToInt32(taggedWeapon[taggedWeapon.Length - 1]) >= Convert.ToInt32(this.txtArmourPerkScoreLevel.Text))
                {
                    this.listWeaponsWithPerkRecommendations.Items.Add(taggedWeapon[0] + " - " + taggedWeapon[taggedWeapon.Length - 1]);
                }
            }
        }
    }
}
