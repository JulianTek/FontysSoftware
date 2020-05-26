using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    class Boat
    {

        public Boat(int maxWeight, List<Container> containers)
        {
            MaxWeight = maxWeight;
            Containers = containers;
            CurrentWeight = 0;
            WeightLeft = 0;
            WeightRight = 0;
        }

        public int MaxWeight { get; private set; }
        public int CurrentWeight { get; private set; }
        public int WeightLeft { get; private set; }
        public int WeightRight { get; private set; }
        public List<Container> Containers { get; private set; }
        public List<Container> ContainersLeft { get; private set; }
        public List<Container> ContainersRight { get; private set; }
        public List<Container> ContainersInFrontLeft { get; private set; }
        public List<Container> ContainersInFrontRight { get; private set; }

        public void AddContainerToShip(Container container)
        {
            Containers.Add(container);
        }

        private void AddContainerRight(Container container)
        {
            ContainersRight.Add(container);
            Containers.Remove(container);
        }

        private void AddContainerLeft(Container container)
        {
            ContainersLeft.Add(container);
            Containers.Remove(container);
        }

        private void AddContainerToFrontLeft(Container container)
        {
            ContainersInFrontLeft.Add(container);
            Containers.Remove(container);
        }

        private void AddContainerToFrontRight(Container container)
        {
            ContainersInFrontRight.Add(container);
            Containers.Remove(container);
        }

        private ShipPosition CheckPlacementLeft(Container container, int containerWeight, int shipWeight, int shipWeightLeft)
        {
            int result = (shipWeightLeft / shipWeight * 100);
            if (result > 60)
            {
                if (container.ContentNeedsCooling)
                {
                    return ShipPosition.FrontRight;
                }
                else
                {
                    return ShipPosition.Right;
                }
            }

            if (container.ContentNeedsCooling)
            {
                return ShipPosition.FrontLeft;
            }

            return ShipPosition.Left;
        }

        private bool CheckIfContainerGoesOnTop(Container container, int weightOnTop)
        {
            if (weightOnTop < 120 && !container.ValuableContent)
            {
                return true;
            }

            return false;
        }
    }
}
