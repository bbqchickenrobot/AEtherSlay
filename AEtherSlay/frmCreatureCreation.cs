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
        Boolean hasShield = false;
        int forcedClass = -1, forcedRace = -1, forcedCategory = -1;
        List<Weapon> simpleMelee = new List<Weapon>() {
                    new Weapon("Club", 4, 1, new List<string>() { "Light" }, "Bludgeoning"),
                    new Weapon("Dagger", 4, 1, new List<string>() { "Light", "Finesse", "Thrown (20/60)" }, "Piercing"),
                    new Weapon("Greatclub", 8, 1, new List<string>() { "Light", "Two-Handed" }, "Bludgeoning"),
                    new Weapon("Handaxe", 6, 1, new List<string>() { "Light", "Thrown" }, "Slashing"),
                    new Weapon("Javelin", 6, 1, new List<string>() { "Thrown (30/120)" }, "Piercing"),
                    new Weapon("Light Hammer", 4, 1, new List<string>() { "Light", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Mace", 6, 1, new List<string>() { }, "Bludgeoning"),
                    new Weapon("Quarterstaff", 6, 1, new List<string>() { "Versatile (1d8)" }, "Bludgeoning"),
                    new Weapon("Sickle", 4, 1, new List<string>() { "Light" }, "Slashing"),
                    new Weapon("Spear", 6, 1, new List<string>() { "Versatile (1d8)", "Thrown (20/60)" }, "Piercing"),
                    new Weapon("Unarmed Strike", 1, 1, new List<string>() { "Light", "Thrown (20/60)" }, "Bludgeoning"),
            },
            simpleRanged = new List<Weapon>() {
                    new Weapon("Crossbow [Light]", 8, 1, new List<string>() { "Ammunition (80/320)", "Loading", "Two-Handed" }, "Piercing"),
                    new Weapon("Dart", 4, 1, new List<string>() { "Thrown (20/60)", "Finesse" }, "Piercing"),
                    new Weapon("Shortbow", 6, 1, new List<string>() { "Ammunition", "Two-Handed" }, "Piercing"),
                    new Weapon("Sling", 4, 1, new List<string>() { "Ammunition (30/120)" }, "Bludgeoning")
            },
            martialMelee = new List<Weapon>() {
                    new Weapon("Battleaxe", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)", "Loading" }, "Bludgeoning"),
                    new Weapon("Flail", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Glaive", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Greataxe", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Greatsword", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Halberd", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Lance", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Longsword", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Maul", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Morningstar", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Pike", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Rapier", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Scimitar", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Shortsword", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Trident", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("War Pick", 4, 1, new List<string>() { }, "Piercing"),
                    new Weapon("Warhammer", 4, 1, new List<string>() { "Ammunition", "Thrown (20/60)" }, "Bludgeoning"),
                    new Weapon("Whip", 4, 1, new List<string>() { "Finesse", "Reach" }, "Bludgeoning"),
            },
            martialRanged = new List<Weapon>()
            {
                    "Blowgun",
                    "Crossbow [hand]",
                    "Crossbow [heavy]",
                    "Longbow",
                    "Net"
            },
            simple,
            martial,
            weapons = new List<Weapon>();
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
            armor
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

        public class Enemy
        {
            public String name, spellcastingStat, alignment;
            public List<String> proficiencies = new List<string>(),
                                traits = new List<String>(),
                                languages = new List<String>(),
                                weapons = new List<String>();
            public short hitDiceSides;

            public Enemy(String name, String spellcasting, List<String> proficiencies, String[] savingThrows, short hitDiceSides)
            {
                this.spellcasting = spellcasting;
                this.proficiencies = proficiencies;
                this.hitDiceSides = hitDiceSides;
            }
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
            int[] sortedRolls = statRolls;
            statRolls = new int[6] { -1, -1, -1, -1, -1, -1 };
            Array.Sort(sortedRolls);
            Array.Reverse(sortedRolls);
            for (int i = 0; i < preferredStatsIRA.Count; i++)
            {
                switch (preferredStatsIRA[i])
                {
                    case "STR": statRolls[0] = sortedRolls[i]; break;
                    case "CON": statRolls[1] = sortedRolls[i]; break;
                    case "DEX": statRolls[2] = sortedRolls[i]; break;
                    case "INT": statRolls[3] = sortedRolls[i]; break;
                    case "WIS": statRolls[4] = sortedRolls[i]; break;
                    case "CHA": statRolls[5] = sortedRolls[i]; break;
                    default: statRolls[i] = sortedRolls[i]; break;
                }
                sortedRolls[i] = -1;
            }
            for (int i = 0; i < 6; i++)
            {
                if (statRolls[i] < 0)
                {
                    statRolls[i] = sortedRolls.Max();
                    sortedRolls[Array.IndexOf(sortedRolls, sortedRolls.Max())] = -1;
                }
            }
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
                    enemy.alignment = "Lawful Good";
                    break;
                case 1:
                    enemy.alignment = "Neutral Lawful";
                    break;
                case 2:
                    enemy.alignment = "Lawful Evil";
                    break;
                case 3:
                    enemy.alignment = "Neutral Good";
                    break;
                case 4:
                    enemy.alignment = "True Neutral";
                    break;
                case 5:
                    enemy.alignment = "Neutral Evil";
                    break;
                case 6:
                    enemy.alignment = "Chaotic Good";
                    break;
                case 7:
                    enemy.alignment = "Chaotic Neutral";
                    break;
                case 8:
                    enemy.alignment = "Chaotic Evil";
                    break;
                default:
                    enemy.alignment = "True Neutral";
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

        public class Weapon
        {
            public int damageDiceSides, numDamageDice;
            public List<String> propertyList = new List<string>();
            public String damageType, name;

            public Weapon(String name, int damageDiceSides, int numDamageDice, List<string> propertyList, string damageType)
            {
                this.name = name;
                this.damageDiceSides = damageDiceSides;
                this.numDamageDice = numDamageDice;
                this.propertyList = propertyList;
                this.damageType = damageType;
            }
        }
    }
}
