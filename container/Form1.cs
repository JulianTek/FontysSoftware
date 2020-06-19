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
            Boat b = new Boat((int) udMaxWeight.Value, (int) udWidth.Value, (int) udHeight.Value, containers);
            b.Sort(containers);
            lbContainers.Items.Clear();
            for (int i = 0; i < udWidth.Value; i++)
            {
                if (b.ContainersInBackLeft.ContainsKey(i))
                {
                    ProcessResults(b.ContainersInBackLeft[i].StackedContainers, ShipPosition.BackLeft, i);
                }
                if (b.ContainersInBackRight.ContainsKey(i))
                {
                    ProcessResults(b.ContainersInBackRight[i].StackedContainers, ShipPosition.BackRight, i);
                }
                if (b.ContainersLeft.ContainsKey(i))
                {
                    ProcessResults(b.ContainersLeft[i].StackedContainers, ShipPosition.Left, i);
                }
                if (b.ContainersRight.ContainsKey(i))
                {
                    ProcessResults(b.ContainersRight[i].StackedContainers, ShipPosition.Right, i);
                }
                if (b.ContainersInFrontLeft.ContainsKey(i))
                {
                    ProcessResults(b.ContainersInFrontLeft[i].StackedContainers, ShipPosition.FrontLeft, i);
                }
                if (b.ContainersInFrontRight.ContainsKey(i))
                {
                    ProcessResults(b.ContainersInFrontRight[i].StackedContainers, ShipPosition.FrontRight, i);
                }
            }
        }

        private void ProcessResults(List<Container> list, ShipPosition direction, int width)
        {
            foreach (Container container in list)
            {
                switch (direction)
                {
                    case ShipPosition.FrontLeft:
                        lbFrontLeft.Items.Add("Container with weight " + container.Weight);
                        containers.Remove(container);
                        break;
                    case ShipPosition.FrontRight:
                        lbFrontRight.Items.Add("Container with weight " + container.Weight);
                        containers.Remove(container);
                        break;
                    case ShipPosition.BackLeft:
                        lbBackLeft.Items.Add("Container with weight " + container.Weight);
                        containers.Remove(container);
                        break;
                    case ShipPosition.BackRight:
                        lbBackRight.Items.Add("Container with weight " + container.Weight);
                        containers.Remove(container);
                        break;
                    case ShipPosition.Left:
                        lbLeft.Items.Add("Container with weight " + container.Weight);
                        containers.Remove(container);
                        break;
                    case ShipPosition.Right:
                        lbRight.Items.Add("Container with weight " + container.Weight);
                        containers.Remove(container);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
                }
            }
        }
    }
}
