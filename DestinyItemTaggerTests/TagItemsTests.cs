using Microsoft.VisualStudio.TestTools.UnitTesting;
using DestinyItemTagger;

namespace DestinyItemTaggerTests
{
    [TestClass]
    public class TagItemsTests
    {
        [TestMethod]
        public void armourPerkSetMatch()
        {
            string[][] destinyArmourPieces = new string[1][];
            destinyArmourPieces[0] = new string[31] { "Tangled Web Hood", "1664085089", "\"6917529097117115204\"", "", "Legendary", "Helmet", "", "Warlock", "732", "Void Damage Resistance", "1", "Warlock(750)", "FALSE", "FALSE", "2", "4", "", "5", "1", "2", "1", "0", "", "Mobile Warlock Armor*", "Mobility Enhancement Mod*", "Restorative Mod", "Tier 1 Armor*", "Sniper Rifle Targeting*", "Light Reactor", "Linear Fusion Rifle Reserves*", "Shotgun Reserves" };

            string[][] armourPerkSets = new string[1][];
            armourPerkSets[0] = new string[2] { "Light Reactor", "Linear Fusion Rifle Reserves" };

            bool typedPerkSet = false;

            string[][] armourPerkRecommendations = new string[][] { new string[] {"", "", "0" } };
            int perkScoreLevel = 0;

            string[][] taggedArmourList = Program.TagItems(destinyArmourPieces, armourPerkSets, typedPerkSet, armourPerkRecommendations, perkScoreLevel);

            Assert.IsTrue(taggedArmourList[0][32] == "yes");
        }

        public void EmptyDataMethod()
        {
            string[][] destinyArmourPieces = new string[][] { new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" } };
            string[][] armourPerkSets = new string[][] { new string[] { "", "" } };
            bool typedPerkSet = false;
            string[][] armourPerkRecommendations = new string[][] { new string[] { "", "", "0" } };
            int perkScoreLevel = 0;

            string[][] weaponPerkRecommendations = new string[][] { new string[] { "", "", "0" } };
            string[][] weaponPerkSets = new string[][] { new string[] { "" } };
            string[][] destinyWeaponPieces = new string[][] { new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" } };

            //string[][] taggedArmourList = Program.TagItems(destinyArmourPieces, armourPerkSets, typedPerkSet, armourPerkRecommendations, perkScoreLevel);
        }

        public void TestDataMethod()
        {
            //ARMOUR
            // Name	Hash	Id	Tag	Tier	Type	Source	Equippable	Power	Masterwork Type	Masterwork Tier	Owner	Locked	Equipped	Year	Season	Event	DTR Rating	# of Reviews	Mobility	Recovery	Resilience	Notes	Perks 0	Perks 1	Perks 2	Perks 3	Perks 4	Perks 5	Perks 6	Perks 7	Perks 8	Perks 9	Perks 10	Perks 11
            string[][] destinyArmourPieces = new string[3][];
            destinyArmourPieces[0] = new string[31] { "Tangled Web Hood", "1664085089", "\"6917529097117115204\"", "", "Legendary", "Helmet", "", "Warlock", "732", "Void Damage Resistance", "1", "Warlock(750)", "FALSE", "FALSE", "2", "4", "", "5", "1", "2", "1", "0", "", "Mobile Warlock Armor*", "Mobility Enhancement Mod*", "Restorative Mod", "Tier 1 Armor*", "Sniper Rifle Targeting*", "Light Reactor", "Linear Fusion Rifle Reserves*", "Shotgun Reserves" };

            string[][] armourPerkSets = new string[1][];
            armourPerkSets[0] = new string[2] { "Light Reactor", "Linear Fusion Rifle Reserves" };

            string[][] armourPerkRecommendations = new string[1][];
            armourPerkRecommendations[0] = new string[3] { "Helmet", "Light Reactor", "1" };
            armourPerkRecommendations[1] = new string[3] { "Helmet", "Linear Fusion Rifle Reserves", "2" };

            //this.taggedArmourList = Program.TagItems(destinyArmourPieces, armourPerkSets, false, armourPerkRecommendations, Convert.ToInt32(this.txtArmourPerkScoreLevel.Text));

            // WEAPONS
            // Name	Hash	Id	Tag	Tier	Type	Source	Power	Dmg	Masterwork Type	Masterwork Tier	Owner	Locked	Equipped	Year	Season	Event	DTR Rating	# of Reviews	Recoil	AA	Impact	Range	Stability	ROF	Reload	Mag	Equip	Charge Time	Draw Time	Accuracy	Notes	Perks 0	Perks 1	Perks 2	Perks 3	Perks 4	Perks 5	Perks 6	Perks 7	Perks 8	Perks 9	Perks 10	Perks 11	Perks 12	Perks 13
            string[][] destinyWeaponPieces = new string[3][];
            destinyWeaponPieces[0] = new string[38] { "The Huckleberry", "2286143274", "\"6917529095680493737\"", "", "Exotic", "Submachine Gun", "", "750", "Kinetic", "", "", "Warlock(750)", "TRUE", "FALSE", "1", "3", "", "4.7", "152", "100", "49", "22", "58", "56", "750", "10", "37", "87", "0", "0", "0", "", "Ride the Bull*", "Fluted Barrel*", "Ricochet Rounds*", "Rampage*", "Short-Action Stock*", "Huckleberry Catalyst*" };

            string[][] weaponPerkSets = new string[0][];
            weaponPerkSets[0] = new string[3] { "Pulse Rifle", "Kill Clip", "Outlaw" };

            string[][] weaponPerkRecommendations = new string[0][];
            weaponPerkRecommendations[0] = new string[3] { "Auto Rifle", "Rampage", "3" };

            //this.taggedArmourList = Program.TagItems(destinyArmourPieces, armourPerkSets, false, armourPerkRecommendations, Convert.ToInt32(this.txtArmourPerkScoreLevel.Text));

        }
    }
}
