using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DagwaardeWin
{
    public partial class Form1 : Form
    {

        brandstofSoort brandstof;

        List<Auto> AutoList = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbKenteken.Text))
            {
                MessageBox.Show("Voer aub een kenteken in");
            }
            else
            {
                addToList();
            }
        }

        public void addToList()
        {
            string kenteken = tbKenteken.Text;
            decimal kmStand = udKm.Value;


                Auto auto = new Auto(kenteken, brandstof);
                lblDagwaarde.Text = auto.Calc(brandstof, kenteken, kmStand);
                lblDagwaarde.Visible = true;
                AutoList.Add(auto);

        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
                case "Benzine":
                    brandstof = brandstofSoort.benzine;
                    break;
                case "Diesel":
                    brandstof = brandstofSoort.diesel;
                    break;
                case "Elektrisch":
                    brandstof = brandstofSoort.elektrisch;
                    break;
                case "LPG":
                    brandstof = brandstofSoort.LPG;
                    break;
                default:
                    MessageBox.Show("Kies aub een waarde");
                    break;
            }
        }
    }
 }
