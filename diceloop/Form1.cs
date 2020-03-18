using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diceloop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtGooi_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int worp, aantalworpen, i;
            aantalworpen = Convert.ToInt32(value: numericUpDown1.Text);
            lbWorpen.Items.Clear();
            for (i = 0; i < aantalworpen; i++)
            {
                worp = rnd.Next(1, 7);
                lbWorpen.Items.Add(worp);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
