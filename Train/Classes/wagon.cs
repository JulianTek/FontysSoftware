using System;
using System.Collections.Generic;

namespace Train.Classes
{
    class Wagon
    {
        public Wagon()
        {
            hasCarnivoreS = false;
            hasCarnivoreM = false;
            hasCarnivoreL = false;
        }

        private List<Animal> animals = new List<Animal>();
        private List<Animal> animalsInWagon = new List<Animal>();
        private List<Animal> templist = new List<Animal>();
        public bool hasCarnivoreS { get; private set; }
        public bool hasCarnivoreM { get; private set; }
        public bool hasCarnivoreL { get; set; }

        public void Fill()
        {

            int wagonPoints = 0;
            for (int i = 0; i < animals.Count; i++)
            {
                Animal animal = animals[i];
                switch (animal.size)
                {
                    case size.small:
                        if (hasCarnivoreS || hasCarnivoreM || hasCarnivoreL)
                        {
                            TooDangerous();
                            break;
                        }

                        if (CheckIfSmallAnimalFits(wagonPoints))
                        {
                            AddAnimalS(animal, wagonPoints, this);
                            break;
                        }
                        WagonFull();
                        break;
                    case size.medium:
                        if (hasCarnivoreM || hasCarnivoreL)
                        {
                            TooDangerous();
                            break;
                        }
                        if (CheckIfMediumAnimalFits(wagonPoints))
                        {
                            AddAnimalM(animal, wagonPoints, this);

                            break;
                        }
                        WagonFull();
                        break;
                    case size.large:
                        if (hasCarnivoreL)
                        {
                            TooDangerous();
                            break;
                        }

                        if (CheckIfLargeAnimalFits(wagonPoints))
                        {
                            AddAnimalL(animal, wagonPoints, this);
                            break;
                        }
                        WagonFull();
                        break;
                }
            }
            
        }

        public void WagonFull()
        {
            animalsInWagon.Clear();
            Console.WriteLine("De wagon is vol!");
            if (!(animals.Count >= 0))
            {
                NewWagon();
            }
            else
            {
                Console.WriteLine("Er zijn geen dieren meer om te sorteren!");
            }
        }

        public void TooDangerous()
        {
            Console.WriteLine("Het is te gevaarlijk om een dier in deze wagon toe te voegen!");
            if (!(animals.Count <= 0))
            {
                NewWagon();
            }
        }

        public void NewWagon()
        {
            Console.WriteLine("Nieuwe wagon!");
            Wagon wagonNew = new Wagon();
            foreach (Animal animal in animals)
            {
                wagonNew.animals.Add(animal);
            }
            wagonNew.Fill();
        }

        public void AddToList()
        {
            animals.Add(new Animal(size.large, "Dinosaur", true));
            animals.Add(new Animal(size.medium, "Big Fish", false));
            animals.Add(new Animal(size.small, "Mouse", false));
            animals.Add(new Animal(size.large, "Dragon", true));
            animals.Add(new Animal(size.small, "Ant", true));
        }

        private void AddAnimalS(Animal animal, int wagonPoints, Wagon wagon)
        {
            animalsInWagon.Add(animal);
            animals.Remove(animal);
            Console.WriteLine(animal.species);
            wagonPoints += 1;
            if (animal.eatsMeat)
            {
               wagon.hasCarnivoreS  = true;
            }
        }
        private void AddAnimalM(Animal animal, int wagonPoints, Wagon wagon)
        {
            animalsInWagon.Add(animal);
            animals.Remove(animal);
            Console.WriteLine(animal.species);
            wagonPoints += 3;
            if (animal.eatsMeat)
            {
                wagon.hasCarnivoreM = true;
            }
        }

        private void AddAnimalL(Animal animal, int wagonPoints, Wagon wagon)
        {
            animalsInWagon.Add(animal);
            animals.Remove(animal);
            Console.WriteLine(animal.species);
            wagonPoints += 5;
            if (animal.eatsMeat)
            {
                wagon.hasCarnivoreL = true;
            }
        }

        private bool CheckIfSmallAnimalFits(int wagonPoints)
        {
            if (wagonPoints + 1 <= 10)
            {
                return true;
            }

            return false;
        }

        private bool CheckIfMediumAnimalFits(int wagonPoints)
        {
            if (wagonPoints + 3 <= 10)
            {
                return true;
            }

            return false;
        }

        private bool CheckIfLargeAnimalFits(int wagonPoints)
        {
            if (wagonPoints + 5 <= 10)
            {
                return true;
            }

            return false;
        }
    }
}
