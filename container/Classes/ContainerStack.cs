using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container.Classes
{
    public class ContainerStack
    {
        public ContainerStack()
        {
            StackedContainers = new List<Container>();
            WeightOnTop = 0;
            CanStack = true;
        }

        public List<Container> StackedContainers { get; set; }
        public int WeightOnTop { get; set; }
        public bool CanStack { get; set; }

        // This method checks if can go on top of another
        public bool CheckIfContainerGoesOnTop(List<Container> containers, int containerWeight)
        {
  
            foreach (Container containerToCheck in containers)
            {
                if (containerToCheck.ValuableContent)
                {
                    return false;
                }

                WeightOnTop += containerToCheck.Weight;
            }
            if (WeightOnTop + containerWeight <= 120)
            {
                return true;
            }

            return false;
        }

        public void AddContainerToStack(Container container, Boat b, ShipPosition direction)
        {
            StackedContainers.Add(container);
            b.CurrentContainerCount += container.Weight;
            if (direction == ShipPosition.BackRight || direction == ShipPosition.Right ||
                direction == ShipPosition.FrontRight)
            {
                b.Weight.WeightRight += container.Weight;
            }
            else
            {
                b.Weight.WeightLeft += container.Weight;
            }
            b.Containers.Remove(container);
        }

        public static bool CheckIfStackExists(Dictionary<int, ContainerStack> stacks, int width)
        {
            if (stacks.ContainsKey(width))
            {
                return true;
            }

            return false;
        }
    }
}
