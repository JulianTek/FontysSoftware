using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container.Classes
{
    public class BoatWeight
    {
        public BoatWeight(int maxWeight)
        {
            MaxWeight = maxWeight;
            CurrentWeight = 0;
            WeightLeft = 0;
            WeightRight = 0;
        }
        public int MaxWeight { get; set; }
        public int CurrentWeight { get; set; }
        public int WeightLeft { get; set; }
        public int WeightRight { get; set; }


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


        public bool CheckIfWeightLimitReached(int boatCurrentWeight, int boatMaxWeight, int containerWeight)
        {
            if (boatCurrentWeight + containerWeight > boatMaxWeight)
            {
                return true;
            }

            return false;
        }

        public bool CheckIfShipCanLeave(int currentWeight, int maxWeight)
        {
            if (currentWeight >= (maxWeight / 2))
            {
                return true;
            }

            return false;
        }
    }
}
