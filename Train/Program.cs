using System;
using System.Collections.Generic;
using Train.Classes;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            wagon Wagon = new wagon();
            Wagon.addToList();
            Console.WriteLine(Wagon.Fill());
        }
    }
}
