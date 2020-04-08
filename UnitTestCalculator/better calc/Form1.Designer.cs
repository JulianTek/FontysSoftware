namespace calc
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
            this.lbGetal1 = new System.Windows.Forms.Label();
            this.lbGetal2 = new System.Windows.Forms.Label();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.tbUitkomst = new System.Windows.Forms.TextBox();
            this.btPlus = new System.Windows.Forms.Button();
            this.btMul = new System.Windows.Forms.Button();
            this.btWort = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btMin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGetal1
            // 
            this.lbGetal1.AutoSize = true;
            this.lbGetal1.Location = new System.Drawing.Point(87, 58);
            this.lbGetal1.Name = "lbGetal1";
            this.lbGetal1.Size = new System.Drawing.Size(58, 17);
            this.lbGetal1.TabIndex = 0;
            this.lbGetal1.Text = "Getal 1:";
            // 
            // lbGetal2
            // 
            this.lbGetal2.AutoSize = true;
            this.lbGetal2.Location = new System.Drawing.Point(214, 58);
            this.lbGetal2.Name = "lbGetal2";
            this.lbGetal2.Size = new System.Drawing.Size(58, 17);
            this.lbGetal2.TabIndex = 1;
            this.lbGetal2.Text = "Getal 2:";
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(217, 95);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(78, 22);
            this.tbGetal2.TabIndex = 2;
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(90, 95);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(78, 22);
            this.tbGetal1.TabIndex = 3;
            // 
            // tbUitkomst
            // 
            this.tbUitkomst.BackColor = System.Drawing.SystemColors.Control;
            this.tbUitkomst.Location = new System.Drawing.Point(128, 161);
            this.tbUitkomst.Name = "tbUitkomst";
            this.tbUitkomst.ReadOnly = true;
            this.tbUitkomst.Size = new System.Drawing.Size(144, 22);
            this.tbUitkomst.TabIndex = 4;
            this.tbUitkomst.Text = "Uitkomst:";
            this.tbUitkomst.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // btPlus
            // 
            this.btPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlus.Location = new System.Drawing.Point(331, 80);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(37, 32);
            this.btPlus.TabIndex = 5;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.BtPlus_Click);
            // 
            // btMul
            // 
            this.btMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMul.Location = new System.Drawing.Point(331, 118);
            this.btMul.Name = "btMul";
            this.btMul.Size = new System.Drawing.Size(37, 31);
            this.btMul.TabIndex = 6;
            this.btMul.Text = "x";
            this.btMul.UseVisualStyleBackColor = true;
            this.btMul.Click += new System.EventHandler(this.BtMul_Click);
            // 
            // btWort
            // 
            this.btWort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWort.Location = new System.Drawing.Point(393, 155);
            this.btWort.Name = "btWort";
            this.btWort.Size = new System.Drawing.Size(37, 31);
            this.btWort.TabIndex = 7;
            this.btWort.Text = "√";
            this.btWort.UseVisualStyleBackColor = true;
            this.btWort.Click += new System.EventHandler(this.BtWort_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(393, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "÷";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btMin
            // 
            this.btMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMin.Location = new System.Drawing.Point(393, 80);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(37, 32);
            this.btMin.TabIndex = 9;
            this.btMin.Text = "-";
            this.btMin.UseVisualStyleBackColor = true;
            this.btMin.Click += new System.EventHandler(this.BtMin_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "x^2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 208);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btMin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btWort);
            this.Controls.Add(this.btMul);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.tbUitkomst);
            this.Controls.Add(this.tbGetal1);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.lbGetal2);
            this.Controls.Add(this.lbGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbGetal1;
        private System.Windows.Forms.Label lbGetal2;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.TextBox tbUitkomst;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button btMul;
        private System.Windows.Forms.Button btWort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Button button2;
    }
}

