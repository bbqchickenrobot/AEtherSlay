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
        public List<String> damageTypes = new List<String>() { "Fire", "Force", "Radiant", "Necrotic", "Lightning", "Thunder", "Cold", "Poison", "Slashing", "Piercing", "Bludgeoning" };
        public List<String> abilities = new List<String>() { "Darkvision", "Blindvision" };
        public List<String> proficiencies = new List<String>() { "Stealth", "Perception", "Investigation", "Acrobatics", "Athletics", "Arcana" };
        public int movement = 30;
        String difficulty = "Med";
        Int32[] statRolls = new int[6];
        Random rand = new Random();
        int ac;

        public frmCreatureCreation()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            #region Get Variables From Form
            difficulty = grpDiff.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;
            MessageBox.Show(difficulty);
            #endregion
            #region Generate Base Stats
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
                statRolls[stat] = ((rolls.Sum() - 10) / 2);
                switch(difficulty)
                {
                    case "Easy": statRolls[stat] -= 2; break;
                    case "Hard": statRolls[stat] += 2; break;
                }
            }
            ac = statRolls[2];
            switch (difficulty)
            {
                case "Easy": ac -= 2; break;
                case "Hard": ac += 2; break;
            }
            #endregion
            #region Generate Proficiencies

            #endregion
            #region Generate Attack(s)

            #endregion
            #region Fill rtbCreatureStats and lblStats
            lblStr.Text = statRolls[0].ToString();
            lblCon.Text = statRolls[1].ToString();
            lblDex.Text = statRolls[2].ToString();
            lblInt.Text = statRolls[3].ToString();
            lblWis.Text = statRolls[4].ToString();
            lblCha.Text = statRolls[5].ToString();
            #endregion
        }
    }

    public class Attack
    {
        public int damageRoll, damageDice, atkModifier;
        public String atkType;

        public Attack(int damageRoll, int damageDice, int atkModifier, string atkType)
        {
            this.damageRoll = damageRoll;
            this.damageDice = damageDice;
            this.atkModifier = atkModifier;
            this.atkType = atkType;
        }

        public int avgDamage()
        {
            int avgRoll = Convert.ToInt32(Math.Round(Convert.ToDouble(this.damageRoll / 2), 0) + 1);
            return Convert.ToInt32(avgRoll * this.damageDice + (Math.Floor(Convert.ToDouble(this.damageDice / 2) + 1)));
        }
    }

}
