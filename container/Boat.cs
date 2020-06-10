using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    public class Boat
    {

        public Boat(int maxWeight, List<Container> containers, int maxContainerCount)
        {
            MaxWeight = maxWeight;
            Containers = containers;
            ContainersInBackLeft = new List<Container>();
            ContainersInBackRight = new List<Container>();
            ContainersInFrontLeft = new List<Container>();
            ContainersInFrontRight = new List<Container>();
            ContainersLeft = new List<Container>();
            ContainersRight = new List<Container>();
            CurrentWeight = 0;
            WeightLeft = 0;
            WeightRight = 0;
            MaxContainerCount = maxContainerCount;
        }

        public Boat(int maxWeight, int maxContainerCount)
        {
            MaxWeight = maxWeight;
            Containers = new List<Container>();
            ContainersInBackLeft = new List<Container>();
            ContainersInBackRight = new List<Container>();
            ContainersInFrontLeft = new List<Container>();
            ContainersInFrontRight = new List<Container>();
            ContainersLeft = new List<Container>();
            ContainersRight = new List<Container>();
            CurrentWeight = 0;
            WeightLeft = 0;
            WeightRight = 0;
            MaxContainerCount = maxContainerCount;
        }

        public Boat(int maxWeight, int width, int height)
        {
            MaxWeight = maxWeight;
            Containers = new List<Container>();
            ContainersInBackLeft = new List<Container>();
            ContainersInBackRight = new List<Container>();
            ContainersInFrontLeft = new List<Container>();
            ContainersInFrontRight = new List<Container>();
            ContainersLeft = new List<Container>();
            ContainersRight = new List<Container>();
            CurrentWeight = 0;
            WeightLeft = 0;
            WeightRight = 0;
            MaxContainerCount = width * height;
        }

        // Assumptions: weight always in tonnes, MaxContainerCount is based on width and height, there is enough space between containers to walk through, but not access
        public int MaxContainerCount { get; }
        public int CurrentContainerCount { get; private set; }
        public int MaxWeight { get; }
        public int CurrentWeight { get; }
        public int WeightLeft { get; }
        public int WeightRight { get; }
        public List<Container> Containers { get; }
        public List<Container> ContainersLeft { get; }
        public List<Container> ContainersRight { get; }
        public List<Container> ContainersInFrontLeft { get; }
        public List<Container> ContainersInFrontRight { get;}
        public List<Container> ContainersInBackLeft { get; }
        public List<Container> ContainersInBackRight { get; }

        // Assumptions: Containers in the front and back can still be reached from one side
        public void Sort(List<Container> containers)
        {
            for (int i = 0; i < containers.Count; i++)
            {
                if (CheckIfContainerCanBeAdded(containers[i].Weight))
                {
                    switch (CheckPlacement(containers[i], containers[i].Weight, CurrentWeight, WeightLeft))
                    {
                        case ShipPosition.FrontLeft:
                            if (CheckIfContainerGoesOnTop(ContainersInFrontLeft, containers[i].Weight))
                            {
                                AddContainerToFrontLeft(containers[i]);
                            }
                            break;
                        case ShipPosition.FrontRight:
                            if (CheckIfContainerGoesOnTop(ContainersInFrontRight, containers[i].Weight))
                            {
                                AddContainerToFrontLeft(containers[i]);
                            }
                            break;
                        case ShipPosition.Left:
                            if (CheckIfContainerGoesOnTop( ContainersLeft, containers[i].Weight))
                            {
                                AddContainerLeft(containers[i]);
                            }
                            break;
                        case ShipPosition.Right:
                            if (CheckIfContainerGoesOnTop(ContainersRight, containers[i].Weight))
                            {
                                AddContainerRight(containers[i]);
                            }
                            break;
                        case ShipPosition.BackLeft:
                            if (CheckIfContainerGoesOnTop(ContainersInBackLeft, containers[i].Weight))
                            {
                                AddContainerToBackLeft(containers[i]);
                            }
                            break;
                        case ShipPosition.BackRight:
                            if (CheckIfContainerGoesOnTop(ContainersInBackRight, containers[i].Weight))
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

                if (CurrentContainerCount == MaxContainerCount || containers.Count == 0)
                {
                    Depart();
                }
            }
        }

        //If the weight limit has been reached, or the minimum weight has not been reached, return false. else return true
        public bool CheckIfContainerCanBeAdded(int containerWeight)
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



        //This method adds the given container to the right side of the ship
        public void AddContainerRight(Container container)
        {
            ContainersRight.Add(container);
            Containers.Remove(container);
        }

        // Ditto, except for the left of the ship
        public void AddContainerLeft(Container container)
        {
            ContainersLeft.Add(container);
            Containers.Remove(container);
        }

        // Ditto, except for the front left (in case container content needs to be cooled)
        public void AddContainerToFrontLeft(Container container)
        {
            ContainersInFrontLeft.Add(container);
            Containers.Remove(container);
        }

        // Ditto, except for the front right
        public void AddContainerToFrontRight(Container container)
        {
            ContainersInFrontRight.Add(container);
            Containers.Remove(container);
        }

        //Ditto, except for back left
        public void AddContainerToBackLeft(Container container)
        {
            ContainersInBackLeft.Add(container);
            Containers.Remove(container);
        }

        //Ditto, except for back right
        public void AddContainerToBackRight(Container container)
        {
            ContainersInBackRight.Add(container);
            Containers.Remove(container);
        }


        // This method checks where the container needs to be placed
        public ShipPosition CheckPlacement(Container container, int containerWeight, int shipWeight, int shipWeightLeft)
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

                    if (container.ContentNeedsCooling)
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

            if (WeightRight < WeightLeft)
            {
                if (container.ContentNeedsCooling && container.ValuableContent)
                {
                    return ShipPosition.FrontRight;
                }

                if (container.ContentNeedsCooling)
                {
                    return ShipPosition.FrontRight;
                }

                if (container.ValuableContent)
                {
                    return ShipPosition.BackRight;
                }

                return ShipPosition.Right;

            }
            if (container.ContentNeedsCooling && container.ValuableContent)
            {
                return ShipPosition.FrontLeft;
            }

            if (container.ContentNeedsCooling)
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
        public bool CheckIfContainerGoesOnTop(List<Container> containers, int containerWeight)
        {
            int weight = 0;
            foreach (Container containerToCheck in containers)
            {
                if (containerToCheck.ValuableContent)
                {
                    return false;
                }

                weight += containerToCheck.Weight;
            }
            if (weight + containerWeight <= 120)
            {
                return true;
            }

            return false;
        }

        //This method checks if adding the container will go past the weight limit
        public bool CheckIfWeightLimitReached(int boatCurrentWeight, int boatMaxWeight, int containerWeight)
        {
            if (boatCurrentWeight + containerWeight > boatMaxWeight)
            {
                return true;
            }

            return false;
        }

        //This method checks if the minimum weight has been met
        public bool CheckIfShipCanLeave(int currentWeight, int maxWeight)
        {
            if (currentWeight >= (maxWeight / 2))
            {
                return true;
            }

            return false;
        }

        public void Depart()
        {

        }
    }
}
