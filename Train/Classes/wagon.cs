using System;
using System.Collections.Generic;
using Train.Classes;
using System.Text;

namespace Train.Classes
{
    class wagon
    {
        public wagon()
        {

        }

        private List<Animal> animals = new List<Animal>();
        private List<Animal> animalsInWagon = new List<Animal>();

        public string Fill()
        {
            bool hasCarnivoreS = false;
            bool hasCarnivoreM = false;
            bool hasCarnivoreL = false;
            int wagonPoints = 0;
            foreach (Animal animal in animals)
            {

                switch (animal.size)
                {
                    case size.small:
                        if (!(hasCarnivoreS || hasCarnivoreM || hasCarnivoreL))
                        {
                            if (wagonPoints <= 10)
                            {
                                wagonPoints += 1;
                                animalsInWagon.Add(animal);
                                if (animal.eatsMeat)
                                {
                                    hasCarnivoreS = true;
                                }
                            }
                            else
                            {
                                return "De wagon zit vol";
                            }
                        }
                        else
                        {
                            return "Er zitten grotere vleeseters in de wagon";
                        }
                        break;
                    case size.medium:
                        if (!(hasCarnivoreM || hasCarnivoreL))
                        {
                            if (wagonPoints <= 10)
                            {
                                wagonPoints += 3;
                                animalsInWagon.Add(animal);
                                if (animal.eatsMeat)
                                {
                                    hasCarnivoreM = true;
                                }
                            }
                            else
                            {
                                return "De wagon zit vol";
                            }
                        }
                        else
                        {
                            return "Er zitten grotere vleeseters in de wagon";
                        }
                        break;
                    case size.large:
                        if (!(hasCarnivoreL))
                        {
                            if (wagonPoints <= 10)
                            {
                                wagonPoints += 5;
                                animalsInWagon.Add(animal);
                                if (animal.eatsMeat)
                                {
                                    hasCarnivoreL = true;
                                }
                            }
                            else
                            {
                                return "De wagon zit vol";
                            }
                        }
                        else
                        {
                            return "Er zitten andere vleeseters in de wagon";
                        }
                        break;
                }
                if (wagonPoints == 10)
                {
                    printList();
                    return "De wagon zit vol";
                }
            }
            printList();
            return "Done";
        }

        public void printList()
        {
            foreach (Animal animal in animalsInWagon)
            {
                Console.WriteLine(animal.species);
            }
        }

        public void addToList()
        {
            animals.Add(new Animal(size.medium, "Cow", false));
            animals.Add(new Animal(size.large, "Elephant", true));
        }
    }
}
