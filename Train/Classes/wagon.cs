using System;
using System.Collections.Generic;

namespace Train.Classes
{
    public class Wagon
    {
        public Wagon()
        {
            hasCarnivoreS = false;
            hasCarnivoreM = false;
            hasCarnivoreL = false;
            wagonPoints = 0;
        }

        public List<Animal> animals = new List<Animal>();
        public List<Animal> animalsInWagon = new List<Animal>();
        public bool hasCarnivoreS { get; private set; }
        public bool hasCarnivoreM { get; private set; }
        public bool hasCarnivoreL { get; private set; }
        public int wagonPoints { get; set; }

        public void Fill()
        {

            for (int i = 0; i < animals.Count; i++)
            {
                Animal animal = animals[i];
                switch (animal.size)
                {
                    case size.small:
                        if (CheckIfSmallAnimalIsSafe(this))
                        {
                            TooDangerous();
                            break;
                        }

                        if (CheckIfSmallAnimalFits(wagonPoints))
                        {
                            AddAnimalS(animal, this);
                            break;
                        }
                        WagonFull();
                        break;
                    case size.medium:
                        if (CheckIfMedAnimalIsSafe(this))
                        {
                            TooDangerous();
                            break;
                        }
                        if (CheckIfMediumAnimalFits(wagonPoints))
                        {
                            AddAnimalM(animal, this);

                            break;
                        }
                        WagonFull();
                        break;
                    case size.large:
                        if (CheckIfLargeAnimalIsSafe(this))
                        {
                            TooDangerous();
                            break;
                        }

                        if (CheckIfLargeAnimalFits(wagonPoints))
                        {
                            AddAnimalL(animal, this);
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


        public void AddAnimalS(Animal animal, Wagon wagon)
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
        public void AddAnimalM(Animal animal, Wagon wagon)
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

        public void AddAnimalL(Animal animal, Wagon wagon)
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

        public bool CheckIfSmallAnimalFits(int wagonPoints)
        {
            if (wagonPoints + 1 <= 10)
            {
                return true;
            }

            return false;
        }

        public bool CheckIfMediumAnimalFits(int wagonPoints)
        {
            if (wagonPoints + 3 <= 10)
            {
                return true;
            }

            return false;
        }

        public bool CheckIfLargeAnimalFits(int wagonPoints)
        {
            if (wagonPoints + 5 <= 10)
            {
                return true;
            }

            return false;
        }

        public bool CheckIfSmallAnimalIsSafe(Wagon wagon)
        {
            if (wagon.hasCarnivoreS || wagon.hasCarnivoreM || wagon.hasCarnivoreL)
            {
                return false;
            }

            return true;
        }

        public bool CheckIfMedAnimalIsSafe(Wagon wagon)
        {
            if (wagon.hasCarnivoreM || wagon.hasCarnivoreL)
            {
                return false;
            }

            return true;
        }

        public bool CheckIfLargeAnimalIsSafe(Wagon wagon)
        {
            if (wagon.hasCarnivoreL)
            {
                return false;
            }

            return true;
        }
    }
}
