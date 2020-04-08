namespace CashMockup
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
            this.btnHBurger = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.ListBox();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCBurger = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHBurger
            // 
            this.btnHBurger.BackColor = System.Drawing.Color.Red;
            this.btnHBurger.FlatAppearance.BorderSize = 0;
            this.btnHBurger.Location = new System.Drawing.Point(12, 12);
            this.btnHBurger.Name = "btnHBurger";
            this.btnHBurger.Size = new System.Drawing.Size(102, 61);
            this.btnHBurger.TabIndex = 0;
            this.btnHBurger.Text = "Hamburger";
            this.btnHBurger.UseVisualStyleBackColor = false;
            this.btnHBurger.Click += new System.EventHandler(this.btnHBurger_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.FormattingEnabled = true;
            this.lbOrder.ItemHeight = 16;
            this.lbOrder.Location = new System.Drawing.Point(662, 12);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(126, 324);
            this.lbOrder.TabIndex = 1;
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(662, 356);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(126, 22);
            this.tbTotalPrice.TabIndex = 2;
            // 
            // btnCBurger
            // 
            this.btnCBurger.BackColor = System.Drawing.Color.Yellow;
            this.btnCBurger.FlatAppearance.BorderSize = 0;
            this.btnCBurger.Location = new System.Drawing.Point(120, 12);
            this.btnCBurger.Name = "btnCBurger";
            this.btnCBurger.Size = new System.Drawing.Size(108, 61);
            this.btnCBurger.TabIndex = 3;
            this.btnCBurger.Text = "Cheeseburger";
            this.btnCBurger.UseVisualStyleBackColor = false;
            this.btnCBurger.Click += new System.EventHandler(this.btnCBurger_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.Location = new System.Drawing.Point(563, 18);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 48);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Product";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Fuchsia;
            this.btnCancel.Location = new System.Drawing.Point(563, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 48);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel Transaction";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Lime;
            this.btnCheckout.Location = new System.Drawing.Point(662, 399);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(126, 39);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCBurger);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.btnHBurger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHBurger;
        private System.Windows.Forms.ListBox lbOrder;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Button btnCBurger;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckout;
    }
}

