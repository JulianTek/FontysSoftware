namespace eurodollar
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
            this.todollar = new System.Windows.Forms.Button();
            this.toeuro = new System.Windows.Forms.Button();
            this.udKoers = new System.Windows.Forms.NumericUpDown();
            this.tbDollar = new System.Windows.Forms.TextBox();
            this.tbEuro = new System.Windows.Forms.TextBox();
            this.lbEuro = new System.Windows.Forms.Label();
            this.lbDollar = new System.Windows.Forms.Label();
            this.btSwitchYen = new System.Windows.Forms.Button();
            this.btSwitchDollar = new System.Windows.Forms.Button();
            this.lbKoers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udKoers)).BeginInit();
            this.SuspendLayout();
            // 
            // todollar
            // 
            this.todollar.Location = new System.Drawing.Point(390, 97);
            this.todollar.Name = "todollar";
            this.todollar.Size = new System.Drawing.Size(47, 35);
            this.todollar.TabIndex = 0;
            this.todollar.Text = ">";
            this.todollar.UseVisualStyleBackColor = true;
            this.todollar.Click += new System.EventHandler(this.ToDollarButton_Click);
            // 
            // toeuro
            // 
            this.toeuro.Location = new System.Drawing.Point(309, 97);
            this.toeuro.Name = "toeuro";
            this.toeuro.Size = new System.Drawing.Size(47, 35);
            this.toeuro.TabIndex = 1;
            this.toeuro.Text = "<";
            this.toeuro.UseVisualStyleBackColor = true;
            this.toeuro.Click += new System.EventHandler(this.ToEuro_Click);
            // 
            // udKoers
            // 
            this.udKoers.AllowDrop = true;
            this.udKoers.DecimalPlaces = 2;
            this.udKoers.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.udKoers.Location = new System.Drawing.Point(35, 184);
            this.udKoers.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.udKoers.Name = "udKoers";
            this.udKoers.ReadOnly = true;
            this.udKoers.Size = new System.Drawing.Size(120, 22);
            this.udKoers.TabIndex = 2;
            this.udKoers.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // tbDollar
            // 
            this.tbDollar.Location = new System.Drawing.Point(515, 103);
            this.tbDollar.Name = "tbDollar";
            this.tbDollar.Size = new System.Drawing.Size(100, 22);
            this.tbDollar.TabIndex = 3;
            this.tbDollar.Text = "1.00";
            // 
            // tbEuro
            // 
            this.tbEuro.Location = new System.Drawing.Point(150, 103);
            this.tbEuro.Name = "tbEuro";
            this.tbEuro.Size = new System.Drawing.Size(100, 22);
            this.tbEuro.TabIndex = 4;
            this.tbEuro.Text = "1.00";
            this.tbEuro.Click += new System.EventHandler(this.ToEuro_Click);
            // 
            // lbEuro
            // 
            this.lbEuro.AutoSize = true;
            this.lbEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEuro.Location = new System.Drawing.Point(120, 103);
            this.lbEuro.Name = "lbEuro";
            this.lbEuro.Size = new System.Drawing.Size(24, 25);
            this.lbEuro.TabIndex = 5;
            this.lbEuro.Text = "€";
            // 
            // lbDollar
            // 
            this.lbDollar.AutoSize = true;
            this.lbDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDollar.Location = new System.Drawing.Point(621, 103);
            this.lbDollar.Name = "lbDollar";
            this.lbDollar.Size = new System.Drawing.Size(24, 25);
            this.lbDollar.TabIndex = 6;
            this.lbDollar.Text = "$";
            // 
            // btSwitchYen
            // 
            this.btSwitchYen.Location = new System.Drawing.Point(528, 153);
            this.btSwitchYen.Name = "btSwitchYen";
            this.btSwitchYen.Size = new System.Drawing.Size(117, 23);
            this.btSwitchYen.TabIndex = 7;
            this.btSwitchYen.Text = "Switch to Yen";
            this.btSwitchYen.UseVisualStyleBackColor = true;
            this.btSwitchYen.Click += new System.EventHandler(this.BtSwitchYen_Click);
            // 
            // btSwitchDollar
            // 
            this.btSwitchDollar.Location = new System.Drawing.Point(528, 184);
            this.btSwitchDollar.Name = "btSwitchDollar";
            this.btSwitchDollar.Size = new System.Drawing.Size(117, 23);
            this.btSwitchDollar.TabIndex = 8;
            this.btSwitchDollar.Text = "Switch to Dollar";
            this.btSwitchDollar.UseVisualStyleBackColor = true;
            this.btSwitchDollar.Click += new System.EventHandler(this.BtSwitchDollar_Click);
            // 
            // lbKoers
            // 
            this.lbKoers.AutoSize = true;
            this.lbKoers.Location = new System.Drawing.Point(35, 161);
            this.lbKoers.Name = "lbKoers";
            this.lbKoers.Size = new System.Drawing.Size(95, 17);
            this.lbKoers.TabIndex = 9;
            this.lbKoers.Text = "Koerswaarde:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 219);
            this.Controls.Add(this.lbKoers);
            this.Controls.Add(this.btSwitchDollar);
            this.Controls.Add(this.btSwitchYen);
            this.Controls.Add(this.lbDollar);
            this.Controls.Add(this.lbEuro);
            this.Controls.Add(this.tbEuro);
            this.Controls.Add(this.tbDollar);
            this.Controls.Add(this.udKoers);
            this.Controls.Add(this.toeuro);
            this.Controls.Add(this.todollar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.udKoers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button todollar;
        private System.Windows.Forms.Button toeuro;
        private System.Windows.Forms.NumericUpDown udKoers;
        private System.Windows.Forms.TextBox tbEuro;
        private System.Windows.Forms.TextBox tbDollar;
        private System.Windows.Forms.Label lbEuro;
        private System.Windows.Forms.Label lbDollar;
        private System.Windows.Forms.Button btSwitchYen;
        private System.Windows.Forms.Button btSwitchDollar;
        private System.Windows.Forms.Label lbKoers;
    }
}

