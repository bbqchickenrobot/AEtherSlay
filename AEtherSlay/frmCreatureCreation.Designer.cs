namespace AEtherSlay
{
    partial class frmCreatureCreation
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpDiff = new System.Windows.Forms.GroupBox();
            this.rbDiffHard = new System.Windows.Forms.RadioButton();
            this.rbDiffMed = new System.Windows.Forms.RadioButton();
            this.rbDiffEasy = new System.Windows.Forms.RadioButton();
            this.rtbCreatureStats = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clbResistance = new System.Windows.Forms.CheckedListBox();
            this.clbImmunity = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCha = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpDiff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(420, 194);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 48);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Generate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // grpDiff
            // 
            this.grpDiff.BackColor = System.Drawing.Color.Black;
            this.grpDiff.Controls.Add(this.rbDiffHard);
            this.grpDiff.Controls.Add(this.rbDiffMed);
            this.grpDiff.Controls.Add(this.rbDiffEasy);
            this.grpDiff.Location = new System.Drawing.Point(170, 188);
            this.grpDiff.Name = "grpDiff";
            this.grpDiff.Size = new System.Drawing.Size(240, 53);
            this.grpDiff.TabIndex = 1;
            this.grpDiff.TabStop = false;
            // 
            // rbDiffHard
            // 
            this.rbDiffHard.AutoSize = true;
            this.rbDiffHard.Location = new System.Drawing.Point(155, 22);
            this.rbDiffHard.Name = "rbDiffHard";
            this.rbDiffHard.Size = new System.Drawing.Size(60, 21);
            this.rbDiffHard.TabIndex = 2;
            this.rbDiffHard.Text = "Hard";
            this.rbDiffHard.UseVisualStyleBackColor = true;
            // 
            // rbDiffMed
            // 
            this.rbDiffMed.AutoSize = true;
            this.rbDiffMed.Checked = true;
            this.rbDiffMed.Location = new System.Drawing.Point(93, 22);
            this.rbDiffMed.Name = "rbDiffMed";
            this.rbDiffMed.Size = new System.Drawing.Size(56, 21);
            this.rbDiffMed.TabIndex = 1;
            this.rbDiffMed.TabStop = true;
            this.rbDiffMed.Text = "Med";
            this.rbDiffMed.UseVisualStyleBackColor = true;
            // 
            // rbDiffEasy
            // 
            this.rbDiffEasy.AutoSize = true;
            this.rbDiffEasy.Location = new System.Drawing.Point(27, 22);
            this.rbDiffEasy.Name = "rbDiffEasy";
            this.rbDiffEasy.Size = new System.Drawing.Size(60, 21);
            this.rbDiffEasy.TabIndex = 0;
            this.rbDiffEasy.Text = "Easy";
            this.rbDiffEasy.UseVisualStyleBackColor = true;
            // 
            // rtbCreatureStats
            // 
            this.rtbCreatureStats.Location = new System.Drawing.Point(22, 310);
            this.rtbCreatureStats.Name = "rtbCreatureStats";
            this.rtbCreatureStats.Size = new System.Drawing.Size(498, 183);
            this.rtbCreatureStats.TabIndex = 2;
            this.rtbCreatureStats.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resistances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Immunities";
            // 
            // clbResistance
            // 
            this.clbResistance.FormattingEnabled = true;
            this.clbResistance.Location = new System.Drawing.Point(266, 33);
            this.clbResistance.Name = "clbResistance";
            this.clbResistance.Size = new System.Drawing.Size(120, 89);
            this.clbResistance.TabIndex = 5;
            // 
            // clbImmunity
            // 
            this.clbImmunity.FormattingEnabled = true;
            this.clbImmunity.Location = new System.Drawing.Point(395, 33);
            this.clbImmunity.Name = "clbImmunity";
            this.clbImmunity.Size = new System.Drawing.Size(120, 89);
            this.clbImmunity.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "STR";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblStr.Location = new System.Drawing.Point(71, 264);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(29, 31);
            this.lblStr.TabIndex = 8;
            this.lblStr.Text = "0";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCon.Location = new System.Drawing.Point(148, 264);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(29, 31);
            this.lblCon.TabIndex = 10;
            this.lblCon.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "CON";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDex.Location = new System.Drawing.Point(225, 264);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(29, 31);
            this.lblDex.TabIndex = 12;
            this.lblDex.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "DEX";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblInt.Location = new System.Drawing.Point(302, 264);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(29, 31);
            this.lblInt.TabIndex = 14;
            this.lblInt.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "INT";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblWis.Location = new System.Drawing.Point(379, 264);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(29, 31);
            this.lblWis.TabIndex = 16;
            this.lblWis.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "WIS";
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblCha.Location = new System.Drawing.Point(456, 264);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(29, 31);
            this.lblCha.TabIndex = 18;
            this.lblCha.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(424, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "CHA";
            // 
            // frmCreatureCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(545, 505);
            this.Controls.Add(this.lblCha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblWis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbImmunity);
            this.Controls.Add(this.clbResistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbCreatureStats);
            this.Controls.Add(this.grpDiff);
            this.Controls.Add(this.btnCreate);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmCreatureCreation";
            this.Text = "frmCreatureeCreation";
            this.grpDiff.ResumeLayout(false);
            this.grpDiff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grpDiff;
        private System.Windows.Forms.RadioButton rbDiffHard;
        private System.Windows.Forms.RadioButton rbDiffMed;
        private System.Windows.Forms.RadioButton rbDiffEasy;
        private System.Windows.Forms.RichTextBox rtbCreatureStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbResistance;
        private System.Windows.Forms.CheckedListBox clbImmunity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.Label label13;
    }
}