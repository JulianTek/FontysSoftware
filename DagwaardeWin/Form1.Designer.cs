namespace DagwaardeWin
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
            this.tbKenteken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.udKm = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.lblDagwaarde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udKm)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKenteken
            // 
            this.tbKenteken.Location = new System.Drawing.Point(407, 116);
            this.tbKenteken.Name = "tbKenteken";
            this.tbKenteken.Size = new System.Drawing.Size(100, 22);
            this.tbKenteken.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kenteken:";
            // 
            // lblKm
            // 
            this.lblKm.AutoSize = true;
            this.lblKm.Location = new System.Drawing.Point(404, 210);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(106, 17);
            this.lblKm.TabIndex = 2;
            this.lblKm.Text = "Kilometerstand:";
            // 
            // udKm
            // 
            this.udKm.Location = new System.Drawing.Point(407, 246);
            this.udKm.Name = "udKm";
            this.udKm.Size = new System.Drawing.Size(120, 22);
            this.udKm.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Benzine",
            "Diesel",
            "Elektrisch",
            "LPG"});
            this.comboBox1.Location = new System.Drawing.Point(89, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Brandstofsoort:";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(407, 301);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(88, 49);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Bereken dagwaarde";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDagwaarde
            // 
            this.lblDagwaarde.AutoSize = true;
            this.lblDagwaarde.Location = new System.Drawing.Point(12, 210);
            this.lblDagwaarde.Name = "lblDagwaarde";
            this.lblDagwaarde.Size = new System.Drawing.Size(46, 17);
            this.lblDagwaarde.TabIndex = 7;
            this.lblDagwaarde.Text = "label1";
            this.lblDagwaarde.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(566, 384);
            this.Controls.Add(this.lblDagwaarde);
            this.Controls.Add(this.udKm);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblKm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKenteken);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.udKm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       private System.Windows.Forms.TextBox tbKenteken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.NumericUpDown udKm;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label lblDagwaarde;
    }
}

