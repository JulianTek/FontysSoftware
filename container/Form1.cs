using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace container
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Container> containers = new List<Container>();
        ContainerGenerator gen = new ContainerGenerator();

        private void GenCoolContainer_Click(object sender, EventArgs e)
        {
           Container container = gen.GenerateCooledContainer((int) udMaxWeight.Value);
            lbContainers.Items.Add("Container with" + container.ValuableContent + " valuable content and " + container.ContentNeedsCooling + " cooling requirement and " + container.Weight + " weight");
            containers.Add(container);
        }

        private void GenValContainer_Click(object sender, EventArgs e)
        {
            Container container = gen.GenerateValuableContainer((int)udMaxWeight.Value);
            lbContainers.Items.Add("Container with" + container.ValuableContent + " valuable content and " + container.ContentNeedsCooling + " cooling requirement and " + container.Weight + " weight");
            containers.Add(container);
        }

        private void btnGenRandom_Click(object sender, EventArgs e)
        {
            List<Container> generatedContainers = gen.GenerateRandomContainers((int) udContainers.Value, (int) udMaxWeight.Value);

            foreach (Container container in generatedContainers)
            {
                lbContainers.Items.Add("Container with" + container.ValuableContent + " valuable content and " + container.ContentNeedsCooling + " cooling requirement and " + container.Weight + " weight");
                containers.Add(container);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Boat b = new Boat((int)udBoatWeight.Value, (int)udWidth.Value, (int)udHeight.Value);
            b.Sort(containers);
            lbContainers.Items.Clear();
            ProcessResults(containers, b.ContainersLeft, b.ContainersInFrontLeft, b.ContainersInBackLeft,
                b.ContainersRight, b.ContainersInFrontRight, b.ContainersInBackRight);
        }

        private void ProcessResults(List<Container> containersLeftOver, List<Container> containersLeft,
            List<Container> containersFrontLeft, List<Container> containersBackLeft, List<Container> containersRight, List<Container> containersFrontRight, List<Container> containersBackRight)
        {
            foreach (Container container in containersBackRight)
            {
                lbBackRight.Items.Add("Container with weight " + container.Weight);
                containers.Remove(container);
            }

            foreach (Container container in containersRight)
            {
                lbRight.Items.Add("Container with weight " + container.Weight);
                containers.Remove(container);
            }

            foreach (Container container in containersFrontRight)
            {
                lbFrontRight.Items.Add("Container with weight " + container.Weight);
                containers.Remove(container);
            }

            foreach (Container container in containersBackLeft)
            {
                lbBackRight.Items.Add("Container with weight " + container.Weight);
                containers.Remove(container);
            }

            foreach (Container container in containersLeft)
            {
                lbBackRight.Items.Add("Container with weight " + container.Weight);
                containers.Remove(container);
            }

            foreach (Container container in containersFrontLeft)
            {
                lbBackRight.Items.Add("Container with weight " + container.Weight);
                containers.Remove(container);
            }

            foreach (Container container in containersLeftOver)
            {
                lbContainers.Items.Add("Container with" + container.ValuableContent + " valuable content and " + container.ContentNeedsCooling + " cooling requirement and " + container.Weight + " weight");
            }
        }
    }
}
