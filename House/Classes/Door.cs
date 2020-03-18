using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using House.Classes;

namespace House.Classes
{
    class Door
    {
        private string color { get; set; }

        public string getData(string color)
        {
            this.color = color;
            return "The color of the door is " + color;
        }

        public Door()
        {
            this.color = "Brown";
        }

        public Door(string color)
        {
            this.color = color;
        }
    }
}
