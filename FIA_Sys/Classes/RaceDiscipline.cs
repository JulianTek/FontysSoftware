using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FIA_Sys.Classes
{
    class RaceDiscipline
    {
        public string name { get; private set; }
        public int activeSince { get; private set; }
        public bool stillActive { get; private set; }
        private List<Season> seasons = new List<Season>();

        public RaceDiscipline(string name, int activeSince, bool stillActive)
        {
            this.name = name;
            this.activeSince = activeSince;
            this.stillActive = stillActive;
        }

        public void addSeason(RaceDiscipline raceDiscipline, int numberOfRaces, string champion, int year)
        {
            seasons.Add(new Season(raceDiscipline, numberOfRaces, champion, year));
        }

        public void removeSeason(Season season)
        {
            seasons.Remove(season);
        }

        public void updateRaceDiscipline(RaceDiscipline raceDiscipline, string name, int activeSince, bool stillActive)
        {
            raceDiscipline.name = name;
            raceDiscipline.stillActive = stillActive;
            raceDiscipline.activeSince = activeSince;
        }
    }
}
