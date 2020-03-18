using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIA_Sys.Classes
{
    class TeamContainer
    {
        private List<Team> teams = new List<Team>();
        public void AddTeam(string name, string country, string city, string mainSponsor, int foundingYear, string director)
        {
            teams.Add(new Team(name, country, city, mainSponsor, foundingYear, director));
        }
    } 
}
