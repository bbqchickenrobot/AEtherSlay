using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AEtherSlay
{
    public partial class frmCreatureCreation : Form
    {
        #region Variable Declarations
        Random rand = new Random();
        Int32[] statRolls = new Int32[6];
        Int32 ac, health = 0;
        Int16 speed = 30;
        String alignment;
        Boolean hasShield = false;
        int forcedClass = -1, forcedRace = -1, forcedCategory = -1;
        List<Catalog.Weapon> simpleMelee = new List<Catalog.Weapon>() {
                    new Catalog.Weapon("Club", 4, 1, new List<string>() { "Light" }, "Bludgeoning"),
                    new Catalog.Weapon("Dagger", 4, 1, new List<string>() { "Light", "Finesse", "Thrown (20/60)" }, "Piercing"),
                    new Catalog.Weapon("Greatclub", 8, 1, new List<string>() { "Light", "Two-Handed" }, "Bludgeoning"),
                    new Catalog.Weapon("Handaxe", 6, 1, new List<string>() { "Light", "Thrown" }, "Slashing"),
                    new Catalog.Weapon("Javelin", 6, 1, new List<string>() { "Thrown (30/120)" }, "Piercing"),
                    new Catalog.Weapon("Light Hammer", 4, 1, new List<string>() { "Light", "Thrown (20/60)" }, "Bludgeoning"),
                    new Catalog.Weapon("Mace", 6, 1, new List<string>() { }, "Bludgeoning"),
                    new Catalog.Weapon("Quarterstaff", 6, 1, new List<string>() { "Versatile (1d8)" }, "Bludgeoning"),
                    new Catalog.Weapon("Sickle", 4, 1, new List<string>() { "Light" }, "Slashing"),
                    new Catalog.Weapon("Spear", 6, 1, new List<string>() { "Versatile (1d8)", "Thrown (20/60)" }, "Piercing"),
                    new Catalog.Weapon("Unarmed Strike", 1, 1, new List<string>() { "Light", "Thrown (20/60)" }, "Bludgeoning"),
            },
            simpleRanged = new List<Catalog.Weapon>() {
                    new Catalog.Weapon("Crossbow [Light]", 8, 1, new List<string>() { "Ammunition (80/320)", "Loading", "Two-Handed" }, "Piercing"),
                    new Catalog.Weapon("Dart", 4, 1, new List<string>() { "Thrown (20/60)", "Finesse" }, "Piercing"),
                    new Catalog.Weapon("Shortbow", 6, 1, new List<string>() { "Ammunition (80/320)", "Two-Handed" }, "Piercing"),
                    new Catalog.Weapon("Sling", 4, 1, new List<string>() { "Ammunition (30/120)" }, "Bludgeoning")
            },
            martialMelee = new List<Catalog.Weapon>() {
                    new Catalog.Weapon("Battleaxe", 8, 1, new List<string>() { "Versatile (1d10)" }, "Slashing"),
                    new Catalog.Weapon("Flail", 8, 1, new List<string>() { }, "Bludgeoning"),
                    new Catalog.Weapon("Glaive", 10, 1, new List<string>() { "Heavy", "Reach", "Two-Handed" }, "Slashing"),
                    new Catalog.Weapon("Greataxe", 12, 1, new List<string>() { "Heavy", "Two-Handed" }, "Slashing"),
                    new Catalog.Weapon("Greatsword", 6, 2, new List<string>() { "Heavy", "Two-Handed" }, "Slashing"),
                    new Catalog.Weapon("Halberd", 10, 1, new List<string>() { "Heavy", "Two-Handed", "Reach" }, "Slashing"),
                    new Catalog.Weapon("Lance", 12, 1, new List<string>() { "Reach", "Special" }, "Bludgeoning"),
                    new Catalog.Weapon("Longsword", 8, 1, new List<string>() { "Versatile (1d10)" }, "Slashing"),
                    new Catalog.Weapon("Maul", 6, 2, new List<string>() { "Heavy", "Two-Handed" }, "Bludgeoning"),
                    new Catalog.Weapon("Morningstar", 8, 1, new List<string>() { }, "Piercing"),
                    new Catalog.Weapon("Pike", 10, 1, new List<string>() { "Heavy", "Reach", "Two-Handed" }, "Piercing"),
                    new Catalog.Weapon("Rapier", 8, 1, new List<string>() { "Finesse" }, "Piercing"),
                    new Catalog.Weapon("Scimitar", 6, 1, new List<string>() { "Finesse", "Light" }, "Slashing"),
                    new Catalog.Weapon("Shortsword", 6, 1, new List<string>() { "Finesse", "Light" }, "Piercing"),
                    new Catalog.Weapon("Trident", 6, 1, new List<string>() { "Thrown (20/60)", "Versatile" }, "Piercing"),
                    new Catalog.Weapon("War Pick", 8, 1, new List<string>() { }, "Piercing"),
                    new Catalog.Weapon("Warhammer", 8, 1, new List<string>() { "Versatile (1d10)" }, "Bludgeoning"),
                    new Catalog.Weapon("Whip", 4, 1, new List<string>() { "Finesse", "Reach" }, "Slashing"),
            },
            martialRanged = new List<Catalog.Weapon>()
            {
                    new Catalog.Weapon("Blowgun", 1, 1, new List<string>(){ "Ammunition (25/100)", "Loading" }, "Piercing" ),
                    new Catalog.Weapon("Crossbow [Hand]", 6, 1, new List<string>(){ "Ammunition (30/120)", "Loading" }, "Piercing" ),
                    new Catalog.Weapon("Crossbow [Heavy]", 10, 1, new List<string>(){ "Ammunition (100/400)", "Loading" }, "Piercing" ),
                    new Catalog.Weapon("Longbow", 8, 1, new List<string>(){ "Ammunition (150/600)", "Loading" }, "Piercing" ),
                    new Catalog.Weapon("Net", 0, 0, new List<string>(){ "Thrown (5/15)", "Special" }, "" )
            },
            simple,
            martial,
            weapons = new List<Catalog.Weapon>();
        List<String>
            armors = new List<string>(),
            lightArmor = new List<string>()
            {
                    "Padded",
                    "Leather",
                    "Studded Leather"
            },
            mediumArmor = new List<string>()
            {
                    "Hide",
                    "Chain Shirt",
                    "Scale Mail",
                    "Breastplate",
                    "Half Plate",
            },
            heavyArmor = new List<string>()
            {
                    "Ring Mail",
                    "Chain Mail",
                    "Splint",
                    "Plate"
            },
            armor;
        #endregion

        public frmCreatureCreation()
        {
            InitializeComponent();

            simple = simpleMelee;
            martial = martialMelee;
            armor = lightArmor;

            armor.AddRange(mediumArmor);
            armor.AddRange(heavyArmor);

            simple.AddRange(simpleRanged);
            martial.AddRange(martialRanged);
            generateCharacter();
        }

        private void generateCharacter()
        {
            #region Set Type Of Enemy
                
            #endregion

            #region Core Stats
            // STR CON DEX INT WIS CHA
            // 0   1   2   3   4   5

            for (short stat = 0; stat < 6; stat++)
            {
                Int32[] rolls = new Int32[3];
                for (short roll = 0; roll < 4; roll++)
                {
                    Int32 rolled = rand.Next(1, 7);
                    if ((roll == 3) && (rolled > rolls.Min()))
                    {
                        rolls[Array.IndexOf(rolls, rolls.Min())] = rolled;
                    }
                    else
                    {
                        if (roll != 3)
                        {
                            rolls[roll] = rolled;
                        }
                    }
                }
                statRolls[stat] = rolls.Sum();
            }
            ac = 10 + ((statRolls[2] - 10) / 2);
            #region IRA
            //int[] sortedRolls = statRolls;
            //statRolls = new int[6] { -1, -1, -1, -1, -1, -1 };
            //Array.Sort(sortedRolls);
            //Array.Reverse(sortedRolls);
            //for (int i = 0; i < preferredStatsIRA.Count; i++)
            //{
            //    switch (preferredStatsIRA[i])
            //    {
            //        case "STR": statRolls[0] = sortedRolls[i]; break;
            //        case "CON": statRolls[1] = sortedRolls[i]; break;
            //        case "DEX": statRolls[2] = sortedRolls[i]; break;
            //        case "INT": statRolls[3] = sortedRolls[i]; break;
            //        case "WIS": statRolls[4] = sortedRolls[i]; break;
            //        case "CHA": statRolls[5] = sortedRolls[i]; break;
            //        default: statRolls[i] = sortedRolls[i]; break;
            //    }
            //    sortedRolls[i] = -1;
            //}
            //for (int i = 0; i < 6; i++)
            //{
            //    if (statRolls[i] < 0)
            //    {
            //        statRolls[i] = sortedRolls.Max();
            //        sortedRolls[Array.IndexOf(sortedRolls, sortedRolls.Max())] = -1;
            //    }
            //}
            #endregion
            #endregion

            #region Generate Weapons

            #endregion

            #region Generate Attacks

            #endregion

            #region Generate Alignment
            switch (rand.Next(9))
            {
                case 0:
                    alignment = "Lawful Good";
                    break;
                case 1:
                    alignment = "Neutral Lawful";
                    break;
                case 2:
                    alignment = "Lawful Evil";
                    break;
                case 3:
                    alignment = "Neutral Good";
                    break;
                case 4:
                    alignment = "True Neutral";
                    break;
                case 5:
                    alignment = "Neutral Evil";
                    break;
                case 6:
                    alignment = "Chaotic Good";
                    break;
                case 7:
                    alignment = "Chaotic Neutral";
                    break;
                case 8:
                    alignment = "Chaotic Evil";
                    break;
                default:
                    alignment = "True Neutral";
                    break;
            }
            #endregion
        }

        public class Attack
        {
            public int damageDiceSides, damageDice, atkModifier;
            public String atkType;

            public Attack(int damageDiceSides, int damageDice, int atkModifier, string atkType)
            {
                this.damageDiceSides = damageDiceSides;
                this.damageDice = damageDice;
                this.atkModifier = atkModifier;
                this.atkType = atkType;
            }

            public int avgDamage()
            {
                int avgRoll = Convert.ToInt32(Math.Floor(Convert.ToDouble(this.damageDiceSides / 2)) + 1);
                return Convert.ToInt32(avgRoll * this.damageDice + (Math.Floor(Convert.ToDouble(this.damageDice / 2) + 1)));
            }

            public String getDmgString()
            {
                return $"{damageDice}d{damageDiceSides} {atkType}";
            }
        }
    }
}
