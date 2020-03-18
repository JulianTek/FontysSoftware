using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehiclesWin.Classes;

/* Using Visual Studio, create a project and the corresponding classes (using several files) for this classes diagram. Each class must include the attributes and methods shown in the diagram, as well as Get and Set methods for Vehicle and "Has" methods ("HasDualSlidingDoors") for MiniVan.

You must create also a test program, which will create an object belonging to each class and tell it to "Drive". */
namespace VehiclesWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Van van = new Van();
            Car car = new Car();
            Minivan minivan = new Minivan();
            Sportscar sportscar = new Sportscar();

            van.Drive();
            car.Drive();
            minivan.Drive();
            sportscar.Drive();
        }
    }
}
