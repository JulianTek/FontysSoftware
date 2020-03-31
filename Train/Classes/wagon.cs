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

        public void Fill()
        {
            bool hasCarnivoreS = false;
            bool hasCarnivoreM = false;
            bool hasCarnivoreL = false;
            string result;
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
                                result = "De wagon zit vol";
                                Console.WriteLine(result);
                            }
                        }
                        else
                        {
                            result = "Er zitten grotere vleeseters in de wagon";
                            Console.WriteLine(result);
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
                                result = "De wagon zit vol";
                            }
                        }
                        else
                        {
                            result = "Er zitten grotere vleeseters in de wagon";
                            Console.WriteLine(result);
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
                                result = "De wagon zit vol";
                                Console.WriteLine(result);
                            }
                        }
                        else
                        {
                            result = "Er zitten andere vleeseters in de wagon";
                            Console.WriteLine(result);
                        }
                        break;
                }
                if (wagonPoints == 10)
                {
                    printList();
                    result = "De wagon zit vol";
                    Console.WriteLine(result);
                }
            }
            printList();
            RemoveList();
            if (animals.Count > 0)
            {
                Console.WriteLine("New Wagon");
                wagon wagonNew = new wagon();
                wagonNew.Fill();
            }
            result = "Done";
            Console.WriteLine(result);
        }

        public void printList()
        {
            foreach (Animal animal in animalsInWagon)
            {
                Console.WriteLine(animal.species);
            }
        }

        public void RemoveList()
        {
            foreach(Animal animal in animalsInWagon)
            {
                animals.Remove(animal);
            }
        }

        public void addToList()
        {
            animals.Add(new Animal(size.medium, "Cow", false));
            animals.Add(new Animal(size.large, "Elephant", true));
            animals.Add(new Animal(size.small, "Ant", true));
            animals.Add(new Animal(size.large, "Dinosaur", true));
            animals.Add(new Animal(size.large, "Tiger", true));
            animals.Add(new Animal(size.medium, "Horse", true));
            animals.Add(new Animal(size.large, "Moose", true));
        }
    }
}
