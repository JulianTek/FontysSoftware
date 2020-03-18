using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calorie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtBereken_Click(object sender, EventArgs e)
        {
            int leeftijd;
            double output;
            leeftijd = Convert.ToInt32(tbLeeftijd.Text);
            if (rbtMan.Checked)
                {
                if (rbtActief.Checked)
                {
                    if (leeftijd < 50)
                    {
                        output = 2500;
                        tbCal.Text = output.ToString();
                    }
                    else
                    {
                        output = 2300;
                        tbCal.Text = output.ToString();
                    }
                }
                else
                {
                    if (leeftijd < 50)
                    {
                        output = 2500 * 0.9;
                        tbCal.Text = output.ToString();
                    }
                    else
                    {
                        output = 2300 * 0.9;
                        tbCal.Text = output.ToString();
                    }
                }
            }
            else
            {
                if (rbtActief.Checked)
                {
                    if (leeftijd < 50)
                    {
                        output = 2000;
                        tbCal.Text = output.ToString();
                    }
                    else
                    {
                        output = 1800;
                        tbCal.Text = output.ToString();
                    }
                }
                else
                {
                    if (leeftijd < 50)
                    {
                        output = 2000 * 0.9;
                        tbCal.Text = output.ToString();
                    }
                    else
                    {
                        output = 1800 * 0.9;
                        tbCal.Text = output.ToString();
                    }
                }
            }
        }

        private void RbtMan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actief betekent meer dan 30 minuten beweging per dag, inactief betekent minder dan 30 minuten beweging per dag");
        }
    }
}