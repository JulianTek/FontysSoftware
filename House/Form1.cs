using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using House.Classes;

namespace House
{
    public partial class Form1 : Form
    {

        List<Home> homeList = new List<Home>();
        List<Door> doorList = new List<Door>();
        List<Person> personList = new List<Person>();


        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            addToList();
            makeVisible();
        }

        public void addToList()
        {
            Home home = new Home();
            int width = Convert.ToInt32(udWidth.Value);
            int lenght = Convert.ToInt32(udLength.Value);
            int area = lenght * width;
            lblHouseInfo.Text = home.getData(area);
            homeList.Add(home);

            string color = tbColor.Text;
            Door door = new Door();
            lblDoorInfo.Text = door.getData(color);
            doorList.Add(door);

            genderType gender;
            string name = tbName.Text;
            if (rbMan.Checked)
            {
                gender = "man";
            }
            else
            {
               gender = "woman";
            }
            Person person = new Person();
            lblPersonInfo.Text = person.getData(name, gender);
            personList.Add(person);
        }

        public void makeVisible()
        {
            lblHouseInfo.Visible = true;
            lblPersonInfo.Visible = true;
            lblDoorInfo.Visible = true;
        }
    }
}
