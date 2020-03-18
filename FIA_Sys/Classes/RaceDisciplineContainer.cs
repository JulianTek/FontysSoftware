using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIA_Sys.Classes
{

    class RaceDisciplineContainer
    {
        private List<RaceDiscipline> raceDisciplines = new List<RaceDiscipline>();

        public void addRaceDiscipline(string name, int activeSince, bool stillActive)
        {
            raceDisciplines.Add(new RaceDiscipline(name, activeSince, stillActive));
        }

        public void removeRaceDiscipline(RaceDiscipline raceDiscipline)
        {
            raceDisciplines.Remove(raceDiscipline);
            }


        }
    }
