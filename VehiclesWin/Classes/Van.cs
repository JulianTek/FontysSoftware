using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesWin.Classes
{
    class Van : Vehicle
    {
        protected bool dualSlidingDoors;

        public bool HasDualSlidingDoors()
        {
            return dualSlidingDoors;
        }
    }
}
