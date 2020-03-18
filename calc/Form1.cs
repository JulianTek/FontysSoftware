using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtPlus_Click(object sender, EventArgs e)
        {
            Double getal1, getal2, result;
            getal1 = Convert.ToDouble(value: tbGetal1.Text);
            getal2 = Convert.ToDouble(value: tbGetal2.Text);
            result = getal1 + getal2;
            if (result < 0)
            {
                tbUitkomst.ForeColor = Color.Red;
                tbUitkomst.Text = "Uitkomst: " + result.ToString();
            }
            else
            {
                tbUitkomst.Text = "Uitkomst: " + result.ToString();
            }
        }

        private void BtMul_Click(object sender, EventArgs e)
        {
            Double getal1, getal2, result;
            getal1 = Convert.ToDouble(value: tbGetal1.Text);
            getal2 = Convert.ToDouble(value: tbGetal2.Text);
            result = getal1 * getal2;
            if (result < 0)
            {
                tbUitkomst.ForeColor = Color.Red;
                tbUitkomst.Text = "Uitkomst: " + result.ToString();
            }
            else
            {
                tbUitkomst.Text = "Uitkomst: " + result.ToString();
            }
        }

        private void BtWort_Click(object sender, EventArgs e)
        {
            Double getal1, result;
            getal1 = Convert.ToDouble(value: tbGetal1.Text);
            result = Math.Sqrt(getal1);
            if (result < 0)
            {
                tbUitkomst.ForeColor = Color.Red;
                tbUitkomst.Text = "Uitkomst: " + result.ToString();
            }
            else
            {
                tbUitkomst.Text = "Uitkomst: " + result.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Double getal1, getal2, result;
            getal1 = Convert.ToDouble(value: tbGetal1.Text);
            getal2 = Convert.ToDouble(value: tbGetal2.Text);
            if (getal2 != 0)
            {
                result = getal1 / getal2;
                if (result < 0)
                {
                    tbUitkomst.ForeColor = Color.Red;
                    tbUitkomst.Text = "Uitkomst: " + result.ToString();
                }
                else
                {
                    tbUitkomst.Text = "Uitkomst: " + result.ToString();
                }
            }
            else
            {
                MessageBox.Show("Error: Kan niet door 0 delen");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Double getal1, result;
            getal1 = Convert.ToDouble(value: tbGetal1.Text);
            result = getal1 * getal1;
                if (result < 0)  
                {
                    tbUitkomst.ForeColor = Color.Red;
                    tbUitkomst.Text = "Uitkomst: " + result.ToString();
                }
                else
                {
                    tbUitkomst.Text = "Uitkomst: " + result.ToString();
                }
            }

        private void BtMin_Click(object sender, EventArgs e)
        {
            Double getal1, getal2, result;
            getal1 = Convert.ToDouble(value: tbGetal1.Text);
            getal2 = Convert.ToDouble(value: tbGetal2.Text);
            result = getal1 - getal2;
            if (result < 0)
            {
                tbUitkomst.ForeColor = Color.Red;
                tbUitkomst.Text = "Uitkomst: " + result.ToString();
            }
            else
            {
                tbUitkomst.Text = "Uitkomst: " + result.ToString();
            }
        }
    }
    }
