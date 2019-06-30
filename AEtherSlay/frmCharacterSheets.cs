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
    public partial class frmCharacterSheets : Form
    {
        TextBox[] coreStatBoxes;
        TextBox[] statModifierBoxes;

        public frmCharacterSheets()
        {
            InitializeComponent();

            coreStatBoxes = new TextBox[] { txtStr, txtDex, txtCon, txtInt, txtWis, txtCha };
            statModifierBoxes = new TextBox[] { txtStrMod, txtDexMod, txtConMod, txtIntMod, txtWisMod, txtChaMod };
        }

        private void FrmCharacterSheets_Load(object sender, EventArgs e)
        {
            bindCharComboBox(cbCharName);
        }

        private void bindCharComboBox(ComboBox combobox)
        {
            List<Catalog.PlayerCharacter> charSheets = Program.storage.retrieveAllCharacterSheets();
            foreach (Catalog.PlayerCharacter character in charSheets)
            {
                ComboboxItem cmbItem = new ComboboxItem();
                cmbItem.Text = character.name;
                cmbItem.Value = character;

                combobox.Items.Add(cmbItem);
            }
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void CbCharName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem selectedCharacterItem = (ComboboxItem)(cbCharName.SelectedItem);
            Catalog.PlayerCharacter selectedCharacter = (Catalog.PlayerCharacter)selectedCharacterItem.Value;

            Int16 i = 0;

            #region Calculate Core Modifiers
            foreach (TextBox box in statModifierBoxes)
            {
                if (selectedCharacter.stats[i] > 11)
                {
                    box.Text = "+";
                }
                else if (selectedCharacter.stats[i] >= 9 && selectedCharacter.stats[i] <= 11)
                {
                    box.Text += "±";
                }
                box.Text += ((selectedCharacter.stats[i] - 10) / 2).ToString();
                i++;
            }
            #endregion

            i = 0;
            foreach (TextBox box in coreStatBoxes)
            {
                box.Text = selectedCharacter.stats[i].ToString();
                i++;
            }

            txtRace.Text = selectedCharacter.raceName;
            txtClass.Text = selectedCharacter.className;
            txtProf.Text = "2";
            txtSpeed.Text = selectedCharacter.speed.ToString();
            txtAC.Text = selectedCharacter.ac.ToString();
            lblAlignment.Text = selectedCharacter.alignment;
            txtInit.Text = txtDexMod.Text;
            txtHP.Text = (selectedCharacter.hitDiceSides + ((selectedCharacter.stats[2] - 10) / 2)).ToString();

            rtbProficiencies.Text = "PROFICIENCIES\n\n";
            try
            {
                foreach (String prof in selectedCharacter.proficiencies) { rtbProficiencies.Text += prof + "\n"; }
            }
            catch { }

            rtbTraits.Text = "TRAITS\n\n";
            try
            {
                foreach (String trait in selectedCharacter.traits) { rtbTraits.Text += trait + "\n"; }
            }
            catch { }

            rtbLanguages.Text = "LANGUAGES\n\n";
            try
            {
                foreach (String language in selectedCharacter.languages) { rtbLanguages.Text += language + "\n"; }
            }
            catch { }

            rtbEquipment.Text = "EQUIPMENT\n\n";
            try
            {
                foreach (String equip in selectedCharacter.equipment) { rtbEquipment.Text += equip + "\n"; }
            }
            catch { }
        }
    }
}
