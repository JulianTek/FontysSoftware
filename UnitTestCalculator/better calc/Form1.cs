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
            Calculator Calculator = new Calculator();
            tbUitkomst.Text = Convert.ToString(Calculator.Add(Convert.ToDouble(tbGetal1.Text), Convert.ToDouble(tbGetal2.Text)));
        }

        private void BtMul_Click(object sender, EventArgs e)
        {
            Calculator Calculator = new Calculator();
            tbUitkomst.Text = Convert.ToString(Calculator.Multiply(Convert.ToDouble(tbGetal1.Text), Convert.ToDouble(tbGetal2.Text)));
        }

        private void BtWort_Click(object sender, EventArgs e)
        {
            Calculator Calculator = new Calculator();
            tbUitkomst.Text = Convert.ToString(Calculator.Root(Convert.ToDouble(tbGetal1.Text)));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Calculator Calculator = new Calculator();
            tbUitkomst.Text = Convert.ToString(Calculator.Divide(Convert.ToDouble(tbGetal1.Text), Convert.ToDouble(tbGetal2.Text)));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Calculator Calculator = new Calculator();
            tbUitkomst.Text = Convert.ToString(Calculator.Square(Convert.ToDouble(tbGetal1.Text)));
        }

        private void BtMin_Click(object sender, EventArgs e)
        {
            Calculator Calculator = new Calculator();
            tbUitkomst.Text = Convert.ToString(Calculator.Subtract(Convert.ToDouble(tbGetal1.Text), Convert.ToDouble(tbGetal2.Text)));
        }
    }
}
