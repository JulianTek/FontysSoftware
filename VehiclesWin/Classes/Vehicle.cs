using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesWin.Classes
{
    class Vehicle
    {
        protected string make { get; set; }
        protected string model { get; set; }
        protected int year { get; set; }

        public Vehicle()
        {

        }

        public Vehicle (string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public void Drive()
        {
            Start();
            Accelerate();
            Driving();
            Driving();
            Decelerate();
            Stop();
        }

        public void Accelerate()
        {

        }

        public void Driving()
        {

        }

        public void Decelerate()
        {

        }

        public void Start()
        {

        }

        public void Stop()
        {

        }
    }
}
