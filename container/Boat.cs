using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    class Boat
    {

        public Boat(int maxWeight, List<Container> containers, int maxContainerCount)
        {
            MaxWeight = maxWeight;
            Containers = containers;
            CurrentWeight = 0;
            WeightLeft = 0;
            WeightRight = 0;
            MaxContainerCount = maxContainerCount;
        }

        // Weight always in tonnes
        public int MaxContainerCount { get; }
        public int CurrentContainerCount { get; private set; }
        public int MaxWeight { get; }
        public int CurrentWeight { get; }
        public int WeightLeft { get; }
        public int WeightRight { get; }
        public List<Container> Containers { get; }
        public List<Container> ContainersLeft { get; private set; }
        public List<Container> ContainersRight { get; private set; }
        public List<Container> ContainersInFrontLeft { get; private set; }
        public List<Container> ContainersInFrontRight { get; private set; }
        public List<Container> ContainersInBackLeft { get; private set; }
        public List<Container> ContainersInBackRight { get; private set; }


        public void Sort(List<Container> containers)
        {
            for (int i = 0; i < containers.Count; i++)
            {
                if (CheckIfContainerCanBeAdded(containers[i].Weight))
                {
                    switch (CheckPlacement(containers[i], containers[i].Weight, CurrentWeight, WeightLeft))
                    {
                        case ShipPosition.FrontLeft:
                            if (CheckIfContainerGoesOnTop(containers[i], containers[i].WeightOnTop))
                            {
                                AddContainerToFrontLeft(containers[i]);
                            }
                            break;
                        case ShipPosition.FrontRight:
                            if (CheckIfContainerGoesOnTop(containers[i], containers[i].WeightOnTop))
                            {
                                AddContainerToFrontLeft(containers[i]);
                            }
                            break;
                        case ShipPosition.Left:
                            if (CheckIfContainerGoesOnTop(containers[i], containers[i].WeightOnTop))
                            {
                                AddContainerLeft(containers[i]);
                            }
                            break;
                        case ShipPosition.Right:
                            if (CheckIfContainerGoesOnTop(containers[i], containers[i].WeightOnTop))
                            {
                                AddContainerRight(containers[i]);
                            }
                            break;
                        case ShipPosition.BackLeft:
                            if (CheckIfContainerGoesOnTop(containers[i], containers[i].WeightOnTop))
                            {
                                AddContainerToBackLeft(containers[i]);
                            }
                            break;
                        case ShipPosition.BackRight:
                            if (CheckIfContainerGoesOnTop(containers[i], containers[i].WeightOnTop))
                            {
                                AddContainerToBackRight(containers[i]);
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                if (CurrentContainerCount < MaxContainerCount)
                {
                    CurrentContainerCount += 1;
                }

                if (CurrentContainerCount == MaxContainerCount)
                {
                    Depart();
                }
            }
        }

        //If the weight limit has been reached, or the minimum weight has not been reached, return false. else return true
        private bool CheckIfContainerCanBeAdded(int containerWeight)
        {
            if (!CheckIfShipCanLeave(CurrentWeight, MaxWeight))
            {
                return true;
            }

            if (!CheckIfWeightLimitReached(CurrentWeight, MaxWeight, containerWeight))
            {
                return true;
            }

            return false;
        }


        // If all requirements are met, this method is run. This one just keeps track of all containers on a ship
        public void AddContainerToShip(Container container)
        {
            Containers.Add(container);
        }

        //This method adds the given container to the right side of the ship
        private void AddContainerRight(Container container)
        {
            ContainersRight.Add(container);
            Containers.Remove(container);
        }

        // Ditto, except for the left of the ship
        private void AddContainerLeft(Container container)
        {
            ContainersLeft.Add(container);
            Containers.Remove(container);
        }

        // Ditto, except for the front left (in case container content needs to be cooled)
        private void AddContainerToFrontLeft(Container container)
        {
            ContainersInFrontLeft.Add(container);
            Containers.Remove(container);
        }

        // Ditto, except for the front right
        private void AddContainerToFrontRight(Container container)
        {
            ContainersInFrontRight.Add(container);
            Containers.Remove(container);
        }

        //Ditto, except for back left
        private void AddContainerToBackLeft(Container container)
        {
            ContainersInBackLeft.Add(container);
            Containers.Remove(container);
        }

        //Ditto, except for back right
        private void AddContainerToBackRight(Container container)
        {
            ContainersInBackRight.Add(container);
            Containers.Remove(container);
        }


        // This method checks where the container needs to be placed
        private ShipPosition CheckPlacement(Container container, int containerWeight, int shipWeight, int shipWeightLeft)
        {
            if (shipWeight != 0)
            {
                int result = (shipWeightLeft / (shipWeight + containerWeight) * 100);
                if (result > 60)
                {
                    if (container.ContentNeedsCooling && container.ValuableContent)
                    {
                        return ShipPosition.FrontRight;
                    }
                    if (container.ValuableContent)
                    {
                        return ShipPosition.BackRight;
                    }

                    return ShipPosition.Right;
                }
            }
            if (container.ContentNeedsCooling && container.ValuableContent)
            {
                return ShipPosition.FrontLeft;
            }

            if (container.ValuableContent)
            {
                return ShipPosition.BackLeft;
            }

            return ShipPosition.Left;

        }

        // This method checks if can go on top of another
        private bool CheckIfContainerGoesOnTop(Container container, int weightOnTop)
        {
            if (weightOnTop < 120 && !container.ValuableContent)
            {
                return true;
            }

            return false;
        }

        //This method checks if adding the container will go past the weight limit
        private bool CheckIfWeightLimitReached(int boatCurrentWeight, int boatMaxWeight, int containerWeight)
        {
            if (boatCurrentWeight + containerWeight > boatMaxWeight)
            {
                return true;
            }

            return false;
        }

        //This method checks if the minimum weight has been met
        private bool CheckIfShipCanLeave(int currentWeight, int maxWeight)
        {
            if (currentWeight >= (maxWeight / 2))
            {
                return true;
            }

            return false;
        }
    }
}
