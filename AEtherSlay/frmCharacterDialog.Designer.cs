namespace AEtherSlay
{
    partial class frmCharacterDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.chkIRA = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(89, 15);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(160, 24);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCategory.Location = new System.Drawing.Point(16, 18);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblClass.Location = new System.Drawing.Point(16, 52);
            this.lblClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(42, 17);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "Class";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(89, 48);
            this.cmbClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(160, 24);
            this.cmbClass.TabIndex = 2;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblRace.Location = new System.Drawing.Point(16, 85);
            this.lblRace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(41, 17);
            this.lblRace.TabIndex = 5;
            this.lblRace.Text = "Race";
            // 
            // cmbRace
            // 
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Location = new System.Drawing.Point(89, 81);
            this.cmbRace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(160, 24);
            this.cmbRace.TabIndex = 4;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(260, 16);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(115, 121);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // chkIRA
            // 
            this.chkIRA.AutoSize = true;
            this.chkIRA.Checked = true;
            this.chkIRA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIRA.Location = new System.Drawing.Point(27, 116);
            this.chkIRA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkIRA.Name = "chkIRA";
            this.chkIRA.Size = new System.Drawing.Size(220, 21);
            this.chkIRA.TabIndex = 7;
            this.chkIRA.Text = "Use Intelligent Roll Allocation?";
            this.chkIRA.UseVisualStyleBackColor = true;
            // 
            // frmCharacterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(391, 151);
            this.Controls.Add(this.chkIRA);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCharacterDialog";
            this.Text = "frmCharacterDialog";
            this.Load += new System.EventHandler(this.FrmCharacterDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckBox chkIRA;
    }
}