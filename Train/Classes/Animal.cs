using System;
using System.Collections.Generic;
using System.Text;

namespace Train.Classes
{
    enum size
    {
        small,
        medium,
        large
    }
    class Animal
    {

        public Animal(size size, string species, bool eatsMeat)
        {
            this.eatsMeat = eatsMeat;
            this.species = species;
            this.size = size;
        }
        public string species { get; private set; }
        public bool eatsMeat { get; private set; }
        public size size { get; private set; }



    }
}
