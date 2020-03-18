namespace calorie
{
    partial class Form1
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
            this.lbLeeftijd = new System.Windows.Forms.Label();
            this.tbLeeftijd = new System.Windows.Forms.TextBox();
            this.lbCalorie = new System.Windows.Forms.Label();
            this.tbCal = new System.Windows.Forms.TextBox();
            this.btBereken = new System.Windows.Forms.Button();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtMan = new System.Windows.Forms.RadioButton();
            this.gbLevenstijl = new System.Windows.Forms.GroupBox();
            this.rbtInactief = new System.Windows.Forms.RadioButton();
            this.rbtActief = new System.Windows.Forms.RadioButton();
            this.btHelp = new System.Windows.Forms.Button();
            this.gbGeslacht.SuspendLayout();
            this.gbLevenstijl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLeeftijd
            // 
            this.lbLeeftijd.AutoSize = true;
            this.lbLeeftijd.Location = new System.Drawing.Point(63, 195);
            this.lbLeeftijd.Name = "lbLeeftijd";
            this.lbLeeftijd.Size = new System.Drawing.Size(58, 17);
            this.lbLeeftijd.TabIndex = 6;
            this.lbLeeftijd.Text = "Leeftijd:";
            // 
            // tbLeeftijd
            // 
            this.tbLeeftijd.Location = new System.Drawing.Point(63, 215);
            this.tbLeeftijd.Name = "tbLeeftijd";
            this.tbLeeftijd.Size = new System.Drawing.Size(100, 22);
            this.tbLeeftijd.TabIndex = 7;
            // 
            // lbCalorie
            // 
            this.lbCalorie.AutoSize = true;
            this.lbCalorie.Location = new System.Drawing.Point(477, 195);
            this.lbCalorie.Name = "lbCalorie";
            this.lbCalorie.Size = new System.Drawing.Size(111, 17);
            this.lbCalorie.TabIndex = 8;
            this.lbCalorie.Text = "Calorieën nodig:";
            // 
            // tbCal
            // 
            this.tbCal.Location = new System.Drawing.Point(480, 214);
            this.tbCal.Name = "tbCal";
            this.tbCal.ReadOnly = true;
            this.tbCal.Size = new System.Drawing.Size(100, 22);
            this.tbCal.TabIndex = 9;
            // 
            // btBereken
            // 
            this.btBereken.Location = new System.Drawing.Point(276, 196);
            this.btBereken.Name = "btBereken";
            this.btBereken.Size = new System.Drawing.Size(127, 41);
            this.btBereken.TabIndex = 10;
            this.btBereken.Text = "Bereken";
            this.btBereken.UseVisualStyleBackColor = true;
            this.btBereken.Click += new System.EventHandler(this.BtBereken_Click);
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.Controls.Add(this.radioButton1);
            this.gbGeslacht.Controls.Add(this.rbtMan);
            this.gbGeslacht.Location = new System.Drawing.Point(63, 57);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(200, 100);
            this.gbGeslacht.TabIndex = 11;
            this.gbGeslacht.TabStop = false;
            this.gbGeslacht.Text = "Geslacht";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vrouw";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtMan
            // 
            this.rbtMan.AutoSize = true;
            this.rbtMan.Location = new System.Drawing.Point(6, 24);
            this.rbtMan.Name = "rbtMan";
            this.rbtMan.Size = new System.Drawing.Size(56, 21);
            this.rbtMan.TabIndex = 2;
            this.rbtMan.Text = "Man";
            this.rbtMan.UseVisualStyleBackColor = true;
            // 
            // gbLevenstijl
            // 
            this.gbLevenstijl.Controls.Add(this.rbtInactief);
            this.gbLevenstijl.Controls.Add(this.rbtActief);
            this.gbLevenstijl.Location = new System.Drawing.Point(380, 57);
            this.gbLevenstijl.Name = "gbLevenstijl";
            this.gbLevenstijl.Size = new System.Drawing.Size(200, 100);
            this.gbLevenstijl.TabIndex = 12;
            this.gbLevenstijl.TabStop = false;
            this.gbLevenstijl.Text = "Levensstijl";
            // 
            // rbtInactief
            // 
            this.rbtInactief.AutoSize = true;
            this.rbtInactief.Location = new System.Drawing.Point(6, 51);
            this.rbtInactief.Name = "rbtInactief";
            this.rbtInactief.Size = new System.Drawing.Size(74, 21);
            this.rbtInactief.TabIndex = 7;
            this.rbtInactief.TabStop = true;
            this.rbtInactief.Text = "Inactief";
            this.rbtInactief.UseVisualStyleBackColor = true;
            // 
            // rbtActief
            // 
            this.rbtActief.AutoSize = true;
            this.rbtActief.Location = new System.Drawing.Point(6, 24);
            this.rbtActief.Name = "rbtActief";
            this.rbtActief.Size = new System.Drawing.Size(68, 21);
            this.rbtActief.TabIndex = 6;
            this.rbtActief.TabStop = true;
            this.rbtActief.Text = "Actief ";
            this.rbtActief.UseVisualStyleBackColor = true;
            // 
            // btHelp
            // 
            this.btHelp.Location = new System.Drawing.Point(12, 12);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(38, 31);
            this.btHelp.TabIndex = 13;
            this.btHelp.Text = "?";
            this.btHelp.UseVisualStyleBackColor = true;
            this.btHelp.Click += new System.EventHandler(this.BtHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 276);
            this.Controls.Add(this.btHelp);
            this.Controls.Add(this.gbLevenstijl);
            this.Controls.Add(this.gbGeslacht);
            this.Controls.Add(this.btBereken);
            this.Controls.Add(this.tbCal);
            this.Controls.Add(this.lbCalorie);
            this.Controls.Add(this.tbLeeftijd);
            this.Controls.Add(this.lbLeeftijd);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Calorie Tracker";
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            this.gbLevenstijl.ResumeLayout(false);
            this.gbLevenstijl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbLeeftijd;
        private System.Windows.Forms.TextBox tbLeeftijd;
        private System.Windows.Forms.Label lbCalorie;
        private System.Windows.Forms.TextBox tbCal;
        private System.Windows.Forms.Button btBereken;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtMan;
        private System.Windows.Forms.GroupBox gbLevenstijl;
        private System.Windows.Forms.RadioButton rbtInactief;
        private System.Windows.Forms.RadioButton rbtActief;
        private System.Windows.Forms.Button btHelp;
    }
}

