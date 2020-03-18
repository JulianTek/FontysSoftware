namespace diceloop
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
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.lbWorpen = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblWorpen = new System.Windows.Forms.Label();
            this.btGooi = new System.Windows.Forms.Button();
            this.lbHigh = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbSettings.SuspendLayout();
            this.gbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.btGooi);
            this.gbSettings.Controls.Add(this.lblWorpen);
            this.gbSettings.Controls.Add(this.numericUpDown1);
            this.gbSettings.Location = new System.Drawing.Point(38, 46);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(212, 136);
            this.gbSettings.TabIndex = 0;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Instellingen";
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.textBox1);
            this.gbResults.Controls.Add(this.lbHigh);
            this.gbResults.Controls.Add(this.lbWorpen);
            this.gbResults.Location = new System.Drawing.Point(519, 46);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(269, 294);
            this.gbResults.TabIndex = 1;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Resultaten";
            // 
            // lbWorpen
            // 
            this.lbWorpen.FormattingEnabled = true;
            this.lbWorpen.ItemHeight = 16;
            this.lbWorpen.Location = new System.Drawing.Point(6, 62);
            this.lbWorpen.Name = "lbWorpen";
            this.lbWorpen.Size = new System.Drawing.Size(162, 180);
            this.lbWorpen.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(115, 22);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblWorpen
            // 
            this.lblWorpen.AutoSize = true;
            this.lblWorpen.Location = new System.Drawing.Point(4, 23);
            this.lblWorpen.Name = "lblWorpen";
            this.lblWorpen.Size = new System.Drawing.Size(102, 17);
            this.lblWorpen.TabIndex = 1;
            this.lblWorpen.Text = "Aantal worpen:";
            // 
            // btGooi
            // 
            this.btGooi.Location = new System.Drawing.Point(53, 88);
            this.btGooi.Name = "btGooi";
            this.btGooi.Size = new System.Drawing.Size(106, 42);
            this.btGooi.TabIndex = 2;
            this.btGooi.Text = "Gooi dobbelstenen";
            this.btGooi.UseVisualStyleBackColor = true;
            this.btGooi.Click += new System.EventHandler(this.BtGooi_Click);
            // 
            // lbHigh
            // 
            this.lbHigh.AutoSize = true;
            this.lbHigh.Location = new System.Drawing.Point(6, 27);
            this.lbHigh.Name = "lbHigh";
            this.lbHigh.Size = new System.Drawing.Size(99, 17);
            this.lbHigh.TabIndex = 1;
            this.lbHigh.Text = "Hoogste worp:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(111, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 15);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbSettings);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.ListBox lbWorpen;
        private System.Windows.Forms.Label lblWorpen;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btGooi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbHigh;
    }
}

