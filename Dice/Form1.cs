using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtDice_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            switch (dice)
            {
                case 1:
                    Console.WriteLine(pictureBox1.Visible = true);
                    break;
                case 2:
                    Console.WriteLine(pictureBox2.Visible = true);
                    break;
                case 3:
                    Console.WriteLine(pictureBox1.Visible = true);
                    break;
                case 4:
                    Console.WriteLine(pictureBox1.Visible = true);
                    break;
                case 5:
                    Console.WriteLine(pictureBox1.Visible = true);
                    break;
                case 6:
                    Console.WriteLine(pictureBox1.Visible = true);
                    break;
            }
        }
    }
}
