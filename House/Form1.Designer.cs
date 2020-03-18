namespace House
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
            this.lblPerson = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.udWidth = new System.Windows.Forms.NumericUpDown();
            this.udLength = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHouseInfo = new System.Windows.Forms.Label();
            this.lblPersonInfo = new System.Windows.Forms.Label();
            this.lblDoorInfo = new System.Windows.Forms.Label();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLength)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(556, 38);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(57, 17);
            this.lblPerson.TabIndex = 0;
            this.lblPerson.Text = "Person:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(559, 86);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 22);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbWoman);
            this.gbGender.Controls.Add(this.rbMan);
            this.gbGender.Location = new System.Drawing.Point(562, 137);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(200, 100);
            this.gbGender.TabIndex = 3;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender:";
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(6, 31);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(59, 21);
            this.rbMan.TabIndex = 0;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Male";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(6, 58);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(75, 21);
            this.rbWoman.TabIndex = 1;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Female";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // udWidth
            // 
            this.udWidth.Location = new System.Drawing.Point(346, 168);
            this.udWidth.Name = "udWidth";
            this.udWidth.Size = new System.Drawing.Size(92, 22);
            this.udWidth.TabIndex = 4;
            // 
            // udLength
            // 
            this.udLength.Location = new System.Drawing.Point(346, 196);
            this.udLength.Name = "udLength";
            this.udLength.Size = new System.Drawing.Size(92, 22);
            this.udLength.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "House:";
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(346, 241);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(100, 22);
            this.tbColor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Door Color";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Display info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHouseInfo
            // 
            this.lblHouseInfo.AutoSize = true;
            this.lblHouseInfo.Location = new System.Drawing.Point(346, 291);
            this.lblHouseInfo.Name = "lblHouseInfo";
            this.lblHouseInfo.Size = new System.Drawing.Size(46, 17);
            this.lblHouseInfo.TabIndex = 12;
            this.lblHouseInfo.Text = "label6";
            this.lblHouseInfo.Visible = false;
            // 
            // lblPersonInfo
            // 
            this.lblPersonInfo.AutoSize = true;
            this.lblPersonInfo.Location = new System.Drawing.Point(556, 291);
            this.lblPersonInfo.Name = "lblPersonInfo";
            this.lblPersonInfo.Size = new System.Drawing.Size(46, 17);
            this.lblPersonInfo.TabIndex = 13;
            this.lblPersonInfo.Text = "label6";
            this.lblPersonInfo.Visible = false;
            // 
            // lblDoorInfo
            // 
            this.lblDoorInfo.AutoSize = true;
            this.lblDoorInfo.Location = new System.Drawing.Point(346, 327);
            this.lblDoorInfo.Name = "lblDoorInfo";
            this.lblDoorInfo.Size = new System.Drawing.Size(46, 17);
            this.lblDoorInfo.TabIndex = 14;
            this.lblDoorInfo.Text = "label6";
            this.lblDoorInfo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDoorInfo);
            this.Controls.Add(this.lblPersonInfo);
            this.Controls.Add(this.lblHouseInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.udLength);
            this.Controls.Add(this.udWidth);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPerson);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.NumericUpDown udWidth;
        private System.Windows.Forms.NumericUpDown udLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHouseInfo;
        private System.Windows.Forms.Label lblPersonInfo;
        private System.Windows.Forms.Label lblDoorInfo;
    }
}

