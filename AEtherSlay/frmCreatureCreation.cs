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
        List<String>
            weapons = new List<string>(),
            armors = new List<string>(),
            simpleMelee = new List<Weapon>() {
                    new Weapon("Club",
                    "Dagger",
                    "Greatclub",
                    "Handaxe",
                    "Javelin",
                    "Light Hammer",
                    "Mace",
                    "Quarterstaff",
                    "Sickle",
                    "Spear",
                    "Unarmed Strike"
            },
            simpleRanged = new List<String>() {
                    "Crossbow [light]",
                    "Dart",
                    "Shortbow",
                    "Sling"
            },
            martialMelee = new List<String>() {
                    "Battleaxe",
                    "Flail",
                    "Glaive",
                    "Greataxe",
                    "Greatsword",
                    "Halberd",
                    "Lance",
                    "Longsword",
                    "Maul",
                    "Morningstar",
                    "Pike",
                    "Rapier",
                    "Scimitar",
                    "Shortsword",
                    "Trident",
                    "War Pick",
                    "Warhammer",
                    "Whip"
            },
            martialRanged = new List<string>()
            {
                    "Blowgun",
                    "Crossbow [hand]",
                    "Crossbow [heavy]",
                    "Longbow",
                    "Net"
            },
            simple,
            martial,
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
