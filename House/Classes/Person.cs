using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using House.Classes;

namespace House.Classes
{
    class Person
    {
        private string name { get; set; }
        private genderType gender { get; set; }
        public enum genderType
        {
            Man,
            Vrouw,
            Unknown
        }

        public string getData(string name, genderType p_gender)
        {
            this.gender = p_gender;
            this.name = name;
            return name + " is a " + p_gender;
        }
    }
}
