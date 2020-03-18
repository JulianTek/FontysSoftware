using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eurodollar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void ToDollarButton_Click(object sender, EventArgs e)
        {
            Double ingevoerdeHoeveelheid, koers, Output;
            Double.TryParse(tbEuro.Text, out ingevoerdeHoeveelheid);
            if (ingevoerdeHoeveelheid == 0)
            {
                MessageBox.Show("INVALID NUMBER. REVERTING.");
                tbDollar.Text = "1,00";
            }
            koers = Convert.ToDouble(value: udKoers.Text);
            Output = ingevoerdeHoeveelheid * koers;
            tbDollar.Text = Output.ToString();
        }

        private void ToEuro_Click(object sender, EventArgs e)
        {
            Double ingevoerdeHoeveelheid, koers, Output;
            Double.TryParse(tbEuro.Text, out ingevoerdeHoeveelheid);
            if (ingevoerdeHoeveelheid == 0)
            {
                MessageBox.Show("INVALID NUMBER. REVERTING.");
                tbDollar.Text = "1,00";
            }
            koers = Convert.ToDouble(value: udKoers.Text);
            Output = ingevoerdeHoeveelheid / koers;
            tbEuro.Text = Output.ToString();
        }

        private void BtSwitchYen_Click(object sender, EventArgs e)
        {
            lbDollar.Text = "¥";
            udKoers.Text = "119.22";
        }

        private void BtSwitchDollar_Click(object sender, EventArgs e)
        {
            lbDollar.Text = "$";
            udKoers.Text = "1.1";
        }
    }
}
