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
    public partial class frmNewArmor : Form
    {
        public Catalog.Armor createdArmor { get; set; }
        public frmNewArmor()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            short dexLim = (short)numDexLimit.Value;
            if(chkNoLimit.Checked) { dexLim = 100; }
            createdArmor = new Catalog.Armor(txtName.Text, dexLim, (short)numAC.Value, chkStealth.Checked);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
