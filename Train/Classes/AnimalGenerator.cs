using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Train.Classes
{
    class AnimalGenerator
    {

        public Animal GenerateSmallHerb()
        {
            return new Animal(size.small, "SmallHerb", false);
        }

        public Animal GenerateMediumHerb()
        {
            return new Animal(size.medium, "MediumHerb", false);
        }

        public Animal GenerateLargeHerb()
        {
            return new Animal(size.large, "LargeHerb", false);
        }

        public Animal GenerateSmallCarn()
        {
            return new Animal(size.small, "SmallCarn", true);
        }

        public Animal GenerateMediumCarn()
        {
            return new Animal(size.medium, "Carn", true);
        }

        public Animal GenerateLargeCarn()
        {
            return new Animal(size.large, "LargeHerb", true);
        }

        public List<Animal> GenerateRandomAnimals(int amount)
        {
            List<Animal> animals = new List<Animal>();
            for (int i = 0; i < amount; i++)
            {
                var animalSize = RandomSize();
                var animalEatsMeat = RandomBool();
                animals.Add(new Animal(RandomSize(), GetName(animalSize, animalEatsMeat), RandomBool()));
            }

            return animals;
        }

        public bool RandomBool()
        {
            Random rnd = new Random();

            if (rnd.Next(0, 2) == 0)
            {
                return true;
            }

            return false;
        }

        public size RandomSize()
        {
            Random rnd = new Random();

            switch (rnd.Next(0, 3))
            {
                case 0:
                    return size.small;
                case 1:
                    return size.medium;
                case 2:
                    return size.large;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public string GetName(size animalSize, bool animalEatsMeat)
        {
            if (animalEatsMeat)
            {
                switch (animalSize)
                {
                    case size.small:
                        return "SmallCarn";
                    case size.medium:
                        return "MediumCarn";
                    case size.large:
                        return "LargeCarn";
                }
            }

            switch (animalSize)
            {
                case size.small:
                    return "SmallHerb";
                case size.medium:
                    return "MediumHerb";
                case size.large:
                    return "LargeHerb";
            }
            throw new ArgumentOutOfRangeException();
        }
    }
}
