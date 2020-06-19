using System;
using System.Collections.Generic;
using System.Text;

namespace Train.Classes
{
    public enum size
    {
        small,
        medium,
        large
    }
    public class Animal
    {

        public Animal(size size, string species, bool eatsMeat)
        {
            this.eatsMeat = eatsMeat;
            this.species = species;
            this.size = size;
        }

        public string species { get; }
        public bool eatsMeat { get; }
        public size size { get; }



    }
}
