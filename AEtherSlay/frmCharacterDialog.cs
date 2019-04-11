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

        public frmCharacterDialog()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Form charCreation = new frmCharacter();
            charCreation.Show();
            this.Dispose();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!changingDropdowns)
            {
                changingDropdowns = true;
                cmbClass.SelectedIndex = -1;
                changingDropdowns = false;
            }
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!changingDropdowns)
            {
                changingDropdowns = true;
                cmbCategory.SelectedIndex = -1;
                changingDropdowns = false;
            }
        }
    }
}
