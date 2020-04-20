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
                        if (hasCarnivoreS || hasCarnivoreM || hasCarnivoreL)
                        {
                            Console.WriteLine("Het is te gevaarlijk om een dier in deze wagon toe te voegen!");
                            //Create end point
                        }

                        if (wagonPoints < 10)
                        {
                            animalsInWagon.Add(animal);
                            wagonPoints += 1;
                            if (animal.eatsMeat)
                            {
                                hasCarnivoreS = true;
                            }
                        }
                        //Create end point for when wagon is full
                        break;
                    case size.medium:
                        if (hasCarnivoreM || hasCarnivoreL)
                        {
                            Console.WriteLine("Het is te gevaarlijk om een dier in deze wagon toe te voegen!");
                            //Create end point
                        }
                        if (wagonPoints < 8)
                        {
                            animalsInWagon.Add(animal);
                            wagonPoints += 3;
                            if (animal.eatsMeat)
                            {
                                hasCarnivoreM = true;
                            }
                        }
                        //Create end point for when wagon is full
                        break;
                    case size.large:
                        if (hasCarnivoreL)
                        {
                            Console.WriteLine("Het is te gevaarlijk om een dier in deze wagon toe te voegen!");
                            //Create end point
                        }

                        if (wagonPoints < 6)
                        {
                            animalsInWagon.Add(animal);
                            wagonPoints += 5;
                            if (animal.eatsMeat)
                            {
                                hasCarnivoreL = true;
                            }
                        }
                        //Create end point for when wagon is full
                        break;
                }
            }
        }
    }
}
