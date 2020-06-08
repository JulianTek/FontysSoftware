﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    class ContainerGenerator
    {
        public  Random rnd = new Random();

        //Method that generates x amount of random containers
        public  List<Container> GenerateRandomContainers(int amount, int maxWeight)
        {
            List<Container> containers = new List<Container>();
            for (int i = 0; i < amount; i++)
            {
                Container container = new Container(RandomBool(), RandomBool(), RandomBool(), rnd.Next(0, maxWeight / 2));
                containers.Add(container);
            }

            return containers;
        }

        //Generates one contianer with cooled content
        public Container GenerateCooledContainer(int maxWeight)
        {
            return new Container(false, true, RandomBool(), rnd.Next(0, maxWeight / 2));
        }

        //Generates empty container
        public Container GenerateEmptyContainer(int maxWeight)
        {
            return new Container(true, false, false, rnd.Next(0, maxWeight / 2));
        }

        //Generates one container with valuable content
        public Container GenerateValuableContainer(int maxWeight)
        {
            return new Container(false, false, true, rnd.Next(0, maxWeight / 2));
        }

        //Generates one container with valuable and cooled content
        public Container GenerateValuableCooledContainer(int maxWeight)
        {
            return new Container(false, true, true, rnd.Next(0, maxWeight / 2));
        }


        private bool RandomBool()
        {
            if (rnd.Next(0, 2) == 0)
            {
                return true;
            }

            return false;
        }
    }
}