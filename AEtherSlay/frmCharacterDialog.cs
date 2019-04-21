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
    public partial class frmCharacterDialog : Form
    {
        bool changingDropdowns = false;
        bool initialisingForm = true;

        public frmCharacterDialog()
        {
            InitializeComponent();
            initialisingForm = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Cat: " + cmbCategory.SelectedIndex.ToString() + "Class: " + cmbClass.SelectedIndex.ToString() + "Race: " + cmbRace.SelectedIndex.ToString());
            Form charCreation = new frmCharacter(cmbCategory.SelectedIndex, cmbClass.SelectedIndex, cmbRace.SelectedIndex, chkIRA.Checked);
            charCreation.Show();
            this.Dispose();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!changingDropdowns && !initialisingForm)
            {
                changingDropdowns = true;
                cmbClass.SelectedIndex = -1;
                changingDropdowns = false;
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!changingDropdowns && !initialisingForm)
            {
                changingDropdowns = true;
                cmbCategory.SelectedIndex = -1;
                changingDropdowns = false;
            }
        }

        private void FrmCharacterDialog_Load(object sender, EventArgs e)
        {
            List<String> comboSource = new List<String>();
            comboSource.Add("Barbarian");
            comboSource.Add("Bard");
            comboSource.Add("Cleric");
            comboSource.Add("Druid");
            comboSource.Add("Fighter");
            comboSource.Add("Monk");
            comboSource.Add("Paladin");
            comboSource.Add("Ranger");
            comboSource.Add("Rogue");
            comboSource.Add("Sorcerer");
            comboSource.Add("Warlock");
            comboSource.Add("Wizard");
            cmbClass.DataSource = comboSource;

            comboSource = new List<String>();
            comboSource.Add("High Elf");
            comboSource.Add("Wood Elf");
            comboSource.Add("Hill Dwarf");
            comboSource.Add("Mountain Dwarf");
            comboSource.Add("Dark Elf");
            comboSource.Add("Lightfoot Halfling");
            comboSource.Add("Stout Halfling");
            comboSource.Add("Human");
            comboSource.Add("Dragonborn");
            comboSource.Add("Forest Gnome");
            comboSource.Add("Rock Gnome");
            comboSource.Add("Half-Elf");
            comboSource.Add("Half-Orc");
            comboSource.Add("Tiefling");
            cmbRace.DataSource = comboSource;

            comboSource = new List<String>();
            comboSource.Add("Ranged");
            comboSource.Add("Melee");
            comboSource.Add("Spellcaster");
            comboSource.Add("Support");
            cmbCategory.DataSource = comboSource;

            cmbCategory.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRace.SelectedIndex = -1;
        }
    }
}
