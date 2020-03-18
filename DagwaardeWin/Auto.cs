using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DagwaardeWin
{
    enum brandstofSoort
    {
        benzine,
        diesel,
        elektrisch,
        LPG
    }
    class Auto
    {
        private decimal kmStand;
        private string kenteken { get; set; }
        private decimal Dagwaarde { get; set; }
        public decimal rijdKilometers(decimal gereden)
        {
            if (gereden >= 0)
            {
                kmStand += gereden;
            }
            return kmStand;
        }
        public Auto(string kenteken, brandstofSoort brandstof)
        {
            this.kmStand = 1;
        }
        public Auto(string kenteken, decimal kmStand, brandstofSoort brandstof)
        {
            if (kmStand == 0)
            {
                this.kmStand = 1;
            }
        }


        public string Calc(brandstofSoort brandstof, string kenteken, decimal kmStand)
        {
            switch (brandstof)
            {
                case brandstofSoort.benzine:
                    Dagwaarde = (500000 / kmStand) * 100;
                    string result = "Auto met kenteken " + Convert.ToString(kenteken) + " en brandstoftype " + Convert.ToString(brandstof) + " met " + Convert.ToString(kmStand) + " op de teller heeft een dagwaade van " + Convert.ToString(Dagwaarde) + " euro";
                    return result;
                case brandstofSoort.diesel:
                    Dagwaarde = (500000 / kmStand) * 150;
                    result = "Auto met kenteken " + Convert.ToString(kenteken) + " en brandstoftype " + Convert.ToString(brandstof) + " met " + Convert.ToString(kmStand) + " op de teller heeft een dagwaade van " + Convert.ToString(Dagwaarde) + " euro";
                    return result;
                case brandstofSoort.elektrisch:
                    Dagwaarde = (500000 / kmStand) * 130;
                    result = "Auto met kenteken " + Convert.ToString(kenteken) + " en brandstoftype " + Convert.ToString(brandstof) + " met " + Convert.ToString(kmStand) + " op de teller heeft een dagwaade van " + Convert.ToString(Dagwaarde) + " euro";
                    return result;
                case brandstofSoort.LPG:
                    Dagwaarde = (500000 / kmStand) * 90;
                    result = "Auto met kenteken " + Convert.ToString(kenteken) + " en brandstoftype " + Convert.ToString(brandstof) + " met " + Convert.ToString(kmStand) + " op de teller heeft een dagwaade van " + Convert.ToString(Dagwaarde) + " euro";
                    return result;
                default:
                    Console.WriteLine("Error");
                    return "Error";
            }
        }


    }
}
