using System;
using System.Collections.Generic;
using Train.Classes;
using System.Text;

namespace Train.Classes
{
    class Wagon
    {
        public Wagon()
        {

        }

        private List<Animal> animals = new List<Animal>();
        private List<Animal> animalsInWagon = new List<Animal>();
        private List<Animal> templist = new List<Animal>();

        public void Fill()
        {
            bool hasCarnivoreS = false;
            bool hasCarnivoreM = false;
            bool hasCarnivoreL = false;

            int wagonPoints = 0;
            for (int i = 0; i < animals.Count; i++)
            {
                Animal animal = animals[i];
                switch (animal.size)
                {
                    case size.small:
                        if (hasCarnivoreS || hasCarnivoreM || hasCarnivoreL)
                        {
                            TooDangerous(animal);
                            break;
                        }

                        if (wagonPoints < 10)
                        {
                            animalsInWagon.Add(animal);
                            animals.Remove(animals[i]);
                            Console.WriteLine(animal.species);
                            wagonPoints += 1;
                            if (animal.eatsMeat)
                            {
                                hasCarnivoreS = true;
                            }
                            break;
                        }
                        WagonFull(animal);
                        break;
                    case size.medium:
                        if (hasCarnivoreM || hasCarnivoreL)
                        {
                            TooDangerous(animal);
                            break;
                        }
                        if (wagonPoints < 8)
                        {
                            animalsInWagon.Add(animal);
                            animals.Remove(animals[i]);
                            Console.WriteLine(animal.species);
                            wagonPoints += 3;
                            if (animal.eatsMeat)
                            {
                                hasCarnivoreM = true;
                            }

                            break;
                        }
                        WagonFull(animal);
                        break;
                    case size.large:
                        if (hasCarnivoreL)
                        {
                            TooDangerous(animal);
                            break;
                        }

                        if (wagonPoints < 6)
                        {
                            animalsInWagon.Add(animal);
                            animals.Remove(animals[i]);
                            Console.WriteLine(animal.species);
                            wagonPoints += 5;
                            if (animal.eatsMeat)
                            {
                                hasCarnivoreL = true;
                            }

                            break;
                        }
                        WagonFull(animal);
                        break;
                }
            }
            
        }

        public void WagonFull(Animal animal)
        {
            foreach (Animal _animal in animalsInWagon)
            {
            }
            animalsInWagon.Clear();
            Console.WriteLine("De wagon is vol!");
            if (!(animals.Count >= 0))
            {
                Console.WriteLine("Nieuwe wagon!");
                Wagon wagonNew = new Wagon();
                wagonNew.Fill();
            }
            else
            {
                Console.WriteLine("Er zijn geen dieren meer om te sorteren!");
            }
        }

        public void TooDangerous(Animal animal)
        {
            Console.WriteLine("Het is te gevaarlijk om een dier in deze wagon toe te voegen!");
            if (!(animals.Count >= 0))
            {
                Console.WriteLine("Nieuwe wagon!");
                Wagon wagonNew = new Wagon();
                wagonNew.Fill();
            }
        }

        public void AddToList()
        {
            animals.Add(new Animal(size.large, "Dinosaur", true));
            animals.Add(new Animal(size.medium, "Big Fish", false));
            animals.Add(new Animal(size.small, "Mouse", false));
            animals.Add(new Animal(size.large, "Dragon", true));
            animals.Add(new Animal(size.small, "Ant", true));
        }
    }
}
