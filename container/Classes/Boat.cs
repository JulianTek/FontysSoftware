using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using container.Classes;

namespace container
{
    public class Boat
    {

        public Boat(int maxWeight, int width, int height, List<Container> containers)
        {
            Weight = new BoatWeight(maxWeight);
            Containers = containers;
            for (int i = 0; i < width; i++)
            {
                ContainersInFrontLeft = new Dictionary<int, ContainerStack>();
                ContainersLeft = new Dictionary<int, ContainerStack>();
                ContainersInBackLeft = new Dictionary<int, ContainerStack>();
                ContainersInBackRight = new Dictionary<int, ContainerStack>();
                ContainersRight = new Dictionary<int, ContainerStack>();
                ContainersInFrontRight = new Dictionary<int, ContainerStack>();
            }
        }

        // Assumptions: weight always in tonnes, MaxContainerCount is based on width and height, there is enough space between containers to walk through, but not access
        public int MaxContainerCount { get; set; }
        public int CurrentContainerCount { get; set; }
        public int Width { get; set; }
        public BoatWeight Weight { get; set; }
        public List<Container> Containers { get; }
        public Dictionary<int, ContainerStack> ContainersLeft { get; }
        public Dictionary<int, ContainerStack> ContainersRight { get; }
        public Dictionary<int, ContainerStack> ContainersInFrontLeft { get; }
        public Dictionary<int, ContainerStack> ContainersInFrontRight { get;}
        public Dictionary<int, ContainerStack> ContainersInBackLeft { get; }
        public Dictionary<int, ContainerStack> ContainersInBackRight { get; }

        // Assumptions: Containers in the front and back can still be reached from one side
        public void Sort(List<Container> containers)
        {
            int widthToCheckLeft = 0;
            int widthToCheckFrontLeft = 0;
            int widthToCheckBackLeft = 0;
            int widthToCheckRight = 0;
            int widthToCheckFrontRight = 0;
            int widthToCheckBackRight = 0;
            for (int i = 0; i < containers.Count; i++)
            {
                // Switch case depending on where the container has to be placed
                switch (CheckPlacement(containers[i], Weight.CurrentWeight,
                    Weight.WeightLeft))
                {
                    case ShipPosition.Left:
                        // If there's no definition for dictionary at specific key (or width)
                        if (!ContainerStack.CheckIfStackExists(ContainersLeft ,widthToCheckLeft))
                        {
                            // Create new dictionary and add container immediately
                            ContainersLeft.Add(widthToCheckLeft, new ContainerStack());
                            Crane.AddContainerLeft(this, containers[i], widthToCheckLeft);
                            break;
                        }
                        // If there's still space left
                        if (ContainersLeft[widthToCheckLeft].CanStack)
                        {
                            // If adding the container wouldn't go over the limit
                            if (ContainersLeft[widthToCheckLeft]
                                .CheckIfContainerGoesOnTop(ContainersLeft[widthToCheckLeft].StackedContainers,
                                    containers[i].Weight))
                            {
                                // Then add the container
                                Crane.AddContainerLeft(this, containers[i], widthToCheckLeft);
                            }
                            else
                            {
                                // If the width is at maximum value
                                if (widthToCheckLeft == Width)
                                {
                                    // Cannot stack on middle left anymore
                                    ContainersLeft[widthToCheckLeft].CanStack = false;
                                }
                                else
                                {
                                    // Otherwise increase width to check
                                    widthToCheckLeft++;
                                }
                            }
                        }
                        break;
                    // The following cases repeat the same pattern
                    case ShipPosition.Right:
                        if (!ContainerStack.CheckIfStackExists(ContainersRight, widthToCheckRight))
                        {
                            ContainersRight.Add(widthToCheckRight, new ContainerStack());
                            Crane.AddContainerRight(this, containers[i], widthToCheckRight);
                            break;
                        }
                        if (ContainersRight[widthToCheckRight].CanStack)
                        {
                            if (ContainersRight[widthToCheckRight]
                                .CheckIfContainerGoesOnTop(ContainersRight[widthToCheckRight].StackedContainers,
                                    containers[i].Weight))
                            {
                                Crane.AddContainerRight(this, containers[i], widthToCheckRight);
                            }
                            else
                            {
                                if (widthToCheckRight == Width)
                                {
                                    ContainersRight[widthToCheckRight].CanStack = false;
                                }
                                else
                                {
                                    widthToCheckRight++;
                                }
                            }
                        }
                        break;
                    case ShipPosition.FrontRight:
                        if (!ContainerStack.CheckIfStackExists(ContainersInFrontRight, widthToCheckFrontRight))
                        {
                            ContainersInFrontRight.Add(widthToCheckFrontRight, new ContainerStack());
                            Crane.AddContainerToFrontRight(this, containers[i], widthToCheckLeft);
                            break;
                        }
                        if (ContainersInFrontRight[widthToCheckFrontRight].CanStack)
                        {
                            if (ContainersInFrontRight[widthToCheckFrontRight]
                                .CheckIfContainerGoesOnTop(ContainersInFrontRight[widthToCheckFrontRight].StackedContainers,
                                    containers[i].Weight))
                            {
                                Crane.AddContainerToFrontRight(this, containers[i], widthToCheckFrontRight);
                            }
                            else
                            {
                                if (widthToCheckFrontRight == Width)
                                {
                                    ContainersLeft[widthToCheckFrontRight].CanStack = false;
                                }
                                else
                                {
                                    widthToCheckFrontRight++;
                                }
                            }
                        }
                        break;
                    case ShipPosition.FrontLeft:
                        if (!ContainerStack.CheckIfStackExists(ContainersInFrontLeft, widthToCheckFrontLeft))
                        {
                            ContainersInFrontLeft.Add(widthToCheckFrontLeft, new ContainerStack());
                            Crane.AddContainerToFrontLeft(this, containers[i], widthToCheckFrontLeft);
                            break;
                        }
                        if (ContainersInFrontLeft[widthToCheckFrontLeft].CanStack)
                        {
                            if (ContainersInFrontLeft[widthToCheckFrontLeft]
                                .CheckIfContainerGoesOnTop(ContainersInFrontLeft[widthToCheckFrontLeft].StackedContainers,
                                    containers[i].Weight))
                            {
                                Crane.AddContainerToFrontLeft(this, containers[i], widthToCheckFrontLeft);
                            }
                            else
                            {
                                if (widthToCheckFrontLeft == Width)
                                {
                                    ContainersInFrontLeft[widthToCheckFrontLeft].CanStack = false;
                                }
                                else
                                {
                                    widthToCheckFrontLeft++;
                                }
                            }
                        }
                        break;
                    case ShipPosition.BackRight:
                        if (!ContainerStack.CheckIfStackExists(ContainersInBackRight, widthToCheckBackRight))
                        {
                            ContainersInBackRight.Add(widthToCheckLeft, new ContainerStack());
                            Crane.AddContainerToBackRight(this, containers[i], widthToCheckLeft);
                            break;
                        }
                        if (ContainersInBackRight[widthToCheckBackRight].CanStack)
                        {
                            if (ContainersInBackRight[widthToCheckBackRight]
                                .CheckIfContainerGoesOnTop(ContainersInBackRight[widthToCheckBackRight].StackedContainers,
                                    containers[i].Weight))
                            {
                                Crane.AddContainerToBackRight(this, containers[i], widthToCheckBackRight);
                            }
                            else
                            {
                                if (widthToCheckBackRight == Width)
                                {
                                    ContainersInBackRight[widthToCheckBackRight].CanStack = false;
                                }
                                else
                                {
                                    widthToCheckBackRight++;
                                }
                            }
                        }
                        break;
                    case ShipPosition.BackLeft:
                        if (!ContainerStack.CheckIfStackExists(ContainersInBackLeft, widthToCheckBackLeft))
                        {
                            ContainersLeft.Add(widthToCheckBackLeft, new ContainerStack());
                            Crane.AddContainerToBackLeft(this, containers[i], widthToCheckBackLeft);
                            break;
                        }
                        if (ContainersInBackLeft[widthToCheckFrontRight].CanStack)
                        {
                            if (ContainersLeft[widthToCheckBackLeft]
                                .CheckIfContainerGoesOnTop(ContainersLeft[widthToCheckBackLeft].StackedContainers,
                                    containers[i].Weight))
                            {
                                Crane.AddContainerToBackLeft(this, containers[i], widthToCheckBackLeft);
                            }
                            else
                            {
                                if (widthToCheckBackLeft == Width)
                                {
                                    ContainersInBackLeft[widthToCheckBackLeft].CanStack = false;
                                }
                                else
                                {
                                    widthToCheckBackLeft++;
                                }
                            }
                        }
                        break;
                }
            }
        }




        // This method checks where the container needs to be placed
        public ShipPosition CheckPlacement(Container container, int shipWeight, int shipWeightLeft)
        {
            if (shipWeight != 0)
            {
                if (Weight.WeightRight < Weight.WeightLeft)
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
            }

            return ShipPosition.Right;

        }

        public bool CheckIfContainersLeft(List<Container> containers)
        {
            if (CurrentContainerCount == MaxContainerCount || containers.Count == 0)
            {
                return true;
            }

            return false;
        }

        public bool CheckIfContainerSpaceLeft()
        {
            if (CurrentContainerCount < MaxContainerCount)
            {
                return true;
            }

            return false;
        }

    }
}
