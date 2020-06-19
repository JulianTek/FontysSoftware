using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container.Classes
{
    // This class is to add containers
    public static class Crane
    {
        ////This method adds the given container to the right side of the ship
        public static void AddContainerRight(Boat b, Container container, int widthToStack)
        {
            b.ContainersRight[widthToStack].StackedContainers.Add(container);
            b.Weight.CurrentWeight += container.Weight;
            b.Weight.WeightRight += container.Weight;
            b.Containers.Remove(container);
        }

        // Ditto, except for the left of the ship
        public static void AddContainerLeft(Boat b, Container container, int widthToStack)
        {
            b.ContainersLeft[widthToStack].StackedContainers.Add(container);
            b.Weight.CurrentWeight += container.Weight;
            b.Weight.WeightRight += container.Weight;
            b.Containers.Remove(container);
        }

        // Ditto, except for the front left (in case container content needs to be cooled)
        public static void AddContainerToFrontLeft(Boat b, Container container, int widthToStack)
        {
            b.ContainersInFrontLeft[widthToStack].StackedContainers.Add(container);
            b.Weight.CurrentWeight += container.Weight;
            b.Weight.WeightLeft += container.Weight;
            b.Containers.Remove(container);
        }

        // Ditto, except for the front right
        public static void AddContainerToFrontRight(Boat b, Container container, int widthToStack)
        {
            b.ContainersInFrontRight[widthToStack].StackedContainers.Add(container);
            b.Weight.CurrentWeight += container.Weight;
            b.Weight.WeightRight += container.Weight;
            b.Containers.Remove(container);
        }

        //Ditto, except for back left
        public static void AddContainerToBackLeft(Boat b, Container container, int widthToStack)
        {
            b.ContainersInBackLeft[widthToStack].StackedContainers.Add(container);
            b.Weight.CurrentWeight += container.Weight;
            b.Weight.WeightLeft += container.Weight;
            b.Containers.Remove(container);
        }

        //Ditto, except for back right
        public static void AddContainerToBackRight(Boat b, Container container, int widthToStack)
        {
            b.ContainersInBackRight[widthToStack].StackedContainers.Add(container);
            b.Weight.CurrentWeight += container.Weight;
            b.Weight.WeightRight += container.Weight;
            b.Containers.Remove(container);
        }
    }
}
