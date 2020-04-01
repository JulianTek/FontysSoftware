using System;
using System.Collections.Generic;

namespace Pancake
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pancake> pancakes = new List<Pancake>();
            Pancake pancake = new Pancake(1);
            Pancake pancake1 = new Pancake(7);
            Pancake pancake2 = new Pancake(5);
            Pancake pancake3 = new Pancake(34);
            Pancake pancake4 = new Pancake(3);
            Pancake pancake5 = new Pancake(12);
            Pancake pancake6 = new Pancake(100);
            Pancake pancake7 = new Pancake(16);
            Pancake pancake8 = new Pancake(11);
            Pancake pancake9 = new Pancake(19);
            pancakes.Add(pancake1);
            pancakes.Add(pancake2);
            pancakes.Add(pancake3);
            pancakes.Add(pancake4);
            pancakes.Add(pancake5);
            pancakes.Add(pancake6);
            pancakes.Add(pancake7);
            pancakes.Add(pancake8);
            pancakes.Add(pancake9);

            pancake.Sort(pancakes);
        }
    }
}
