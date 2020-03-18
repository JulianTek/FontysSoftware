using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIA_Sys.Classes
{
    class Season
    {

        public RaceDiscipline raceDiscipline { get; private set; }
        public int numberOfRaces { get; private set; }
        public string champion { get; private set; }
        public int year { get; private set;  }

        public void addChampion(Season season, string champion)
        {
            season.champion = champion; 
        }

        public Season(RaceDiscipline raceDiscipline,int numberOfRaces, string champion, int year )
        {

        }
    }
}
