using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIA_Sys.Classes
{
    class Team
    {
        public string name { get; private set; }
        public string country { get; private set; }
        public string city { get; private set; }
        public string mainSponsor { get; private set; }
        public int foundingYear { get; private set; }
        public string director { get; private set; }

        public Team(string name, string country, string city, string mainSponsor, int foundingYear, string director)
        {
            this.name = name;
            this.country = country;
            this.city = city;
            this.mainSponsor = mainSponsor;
            this.foundingYear = foundingYear;
            this.director = director;
        }

        public void updateTeam(string name, string country, string city, string mainSponsor, int foundingYear, string director)
        {
            this.name = name;
            this.country = country;
            this.city = city;
            this.mainSponsor = mainSponsor;
            this.foundingYear = foundingYear;
            this.director = director;
        }
    }
}
