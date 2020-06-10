namespace container
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
            this.udHeight = new System.Windows.Forms.NumericUpDown();
            this.udBoatWeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.udWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBackLeft = new System.Windows.Forms.ListBox();
            this.lbBackRight = new System.Windows.Forms.ListBox();
            this.lbLeft = new System.Windows.Forms.ListBox();
            this.lbRight = new System.Windows.Forms.ListBox();
            this.lbFrontLeft = new System.Windows.Forms.ListBox();
            this.lbFrontRight = new System.Windows.Forms.ListBox();
            this.lbContainers = new System.Windows.Forms.ListBox();
            this.GenValContainer = new System.Windows.Forms.Button();
            this.GenCoolContainer = new System.Windows.Forms.Button();
            this.btnGenRandom = new System.Windows.Forms.Button();
            this.udContainers = new System.Windows.Forms.NumericUpDown();
            this.udMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoatWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udContainers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // udHeight
            // 
            this.udHeight.Location = new System.Drawing.Point(0, 60);
            this.udHeight.Name = "udHeight";
            this.udHeight.Size = new System.Drawing.Size(72, 22);
            this.udHeight.TabIndex = 0;
            // 
            // udBoatWeight
            // 
            this.udBoatWeight.Location = new System.Drawing.Point(0, 127);
            this.udBoatWeight.Name = "udBoatWeight";
            this.udBoatWeight.Size = new System.Drawing.Size(72, 22);
            this.udBoatWeight.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max. Weight";
            // 
            // udWidth
            // 
            this.udWidth.Location = new System.Drawing.Point(101, 60);
            this.udWidth.Name = "udWidth";
            this.udWidth.Size = new System.Drawing.Size(72, 22);
            this.udWidth.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width:";
            // 
            // lbBackLeft
            // 
            this.lbBackLeft.FormattingEnabled = true;
            this.lbBackLeft.ItemHeight = 16;
            this.lbBackLeft.Location = new System.Drawing.Point(782, 40);
            this.lbBackLeft.Name = "lbBackLeft";
            this.lbBackLeft.Size = new System.Drawing.Size(120, 116);
            this.lbBackLeft.TabIndex = 7;
            // 
            // lbBackRight
            // 
            this.lbBackRight.FormattingEnabled = true;
            this.lbBackRight.ItemHeight = 16;
            this.lbBackRight.Location = new System.Drawing.Point(1054, 40);
            this.lbBackRight.Name = "lbBackRight";
            this.lbBackRight.Size = new System.Drawing.Size(120, 116);
            this.lbBackRight.TabIndex = 8;
            // 
            // lbLeft
            // 
            this.lbLeft.FormattingEnabled = true;
            this.lbLeft.ItemHeight = 16;
            this.lbLeft.Location = new System.Drawing.Point(782, 196);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(120, 116);
            this.lbLeft.TabIndex = 9;
            // 
            // lbRight
            // 
            this.lbRight.FormattingEnabled = true;
            this.lbRight.ItemHeight = 16;
            this.lbRight.Location = new System.Drawing.Point(1054, 196);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(120, 116);
            this.lbRight.TabIndex = 10;
            // 
            // lbFrontLeft
            // 
            this.lbFrontLeft.FormattingEnabled = true;
            this.lbFrontLeft.ItemHeight = 16;
            this.lbFrontLeft.Location = new System.Drawing.Point(782, 347);
            this.lbFrontLeft.Name = "lbFrontLeft";
            this.lbFrontLeft.Size = new System.Drawing.Size(120, 116);
            this.lbFrontLeft.TabIndex = 11;
            // 
            // lbFrontRight
            // 
            this.lbFrontRight.FormattingEnabled = true;
            this.lbFrontRight.ItemHeight = 16;
            this.lbFrontRight.Location = new System.Drawing.Point(1054, 347);
            this.lbFrontRight.Name = "lbFrontRight";
            this.lbFrontRight.Size = new System.Drawing.Size(120, 116);
            this.lbFrontRight.TabIndex = 12;
            // 
            // lbContainers
            // 
            this.lbContainers.FormattingEnabled = true;
            this.lbContainers.ItemHeight = 16;
            this.lbContainers.Location = new System.Drawing.Point(12, 321);
            this.lbContainers.Name = "lbContainers";
            this.lbContainers.Size = new System.Drawing.Size(526, 164);
            this.lbContainers.TabIndex = 13;
            // 
            // GenValContainer
            // 
            this.GenValContainer.Location = new System.Drawing.Point(12, 255);
            this.GenValContainer.Name = "GenValContainer";
            this.GenValContainer.Size = new System.Drawing.Size(134, 60);
            this.GenValContainer.TabIndex = 14;
            this.GenValContainer.Text = "Generate Valuable Container";
            this.GenValContainer.UseVisualStyleBackColor = true;
            this.GenValContainer.Click += new System.EventHandler(this.GenValContainer_Click);
            // 
            // GenCoolContainer
            // 
            this.GenCoolContainer.Location = new System.Drawing.Point(153, 255);
            this.GenCoolContainer.Name = "GenCoolContainer";
            this.GenCoolContainer.Size = new System.Drawing.Size(134, 60);
            this.GenCoolContainer.TabIndex = 15;
            this.GenCoolContainer.Text = "Generate Cooled Container";
            this.GenCoolContainer.UseVisualStyleBackColor = true;
            this.GenCoolContainer.Click += new System.EventHandler(this.GenCoolContainer_Click);
            // 
            // btnGenRandom
            // 
            this.btnGenRandom.Location = new System.Drawing.Point(293, 255);
            this.btnGenRandom.Name = "btnGenRandom";
            this.btnGenRandom.Size = new System.Drawing.Size(134, 60);
            this.btnGenRandom.TabIndex = 16;
            this.btnGenRandom.Text = "Generate Random Containers";
            this.btnGenRandom.UseVisualStyleBackColor = true;
            this.btnGenRandom.Click += new System.EventHandler(this.btnGenRandom_Click);
            // 
            // udContainers
            // 
            this.udContainers.Location = new System.Drawing.Point(74, 227);
            this.udContainers.Name = "udContainers";
            this.udContainers.Size = new System.Drawing.Size(72, 22);
            this.udContainers.TabIndex = 17;
            // 
            // udMaxWeight
            // 
            this.udMaxWeight.Location = new System.Drawing.Point(74, 189);
            this.udMaxWeight.Name = "udMaxWeight";
            this.udMaxWeight.Size = new System.Drawing.Size(72, 22);
            this.udMaxWeight.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Max Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "No. of";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "containers";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(92, 127);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(81, 23);
            this.btnSort.TabIndex = 22;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 518);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.udMaxWeight);
            this.Controls.Add(this.udContainers);
            this.Controls.Add(this.btnGenRandom);
            this.Controls.Add(this.GenCoolContainer);
            this.Controls.Add(this.GenValContainer);
            this.Controls.Add(this.lbContainers);
            this.Controls.Add(this.lbFrontRight);
            this.Controls.Add(this.lbFrontLeft);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.Controls.Add(this.lbBackRight);
            this.Controls.Add(this.lbBackLeft);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.udBoatWeight);
            this.Controls.Add(this.udHeight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.udHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBoatWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udContainers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown udHeight;
        private System.Windows.Forms.NumericUpDown udBoatWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown udWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbBackLeft;
        private System.Windows.Forms.ListBox lbBackRight;
        private System.Windows.Forms.ListBox lbLeft;
        private System.Windows.Forms.ListBox lbRight;
        private System.Windows.Forms.ListBox lbFrontLeft;
        private System.Windows.Forms.ListBox lbFrontRight;
        private System.Windows.Forms.ListBox lbContainers;
        private System.Windows.Forms.Button GenValContainer;
        private System.Windows.Forms.Button GenCoolContainer;
        private System.Windows.Forms.Button btnGenRandom;
        private System.Windows.Forms.NumericUpDown udContainers;
        private System.Windows.Forms.NumericUpDown udMaxWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSort;
    }
}

