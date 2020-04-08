using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrestlingSim.Classes
{
    class Wrestler
    {
        public string name { get; private set; }
        public int health { get; private set; }
        public int weight { get; private set; }
        public bool gender { get; private set; }

        public Wrestler(string name, int health, int weight, bool gender)
        {
            this.name = name;
            this.health = health;
            this.weight = weight;
            this.gender = gender;
        }
    }
}
