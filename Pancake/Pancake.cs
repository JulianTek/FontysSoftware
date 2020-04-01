using System;
using System.Collections.Generic;
using System.Text;

namespace Pancake
{
    public class Pancake
    {
        public Pancake(int size)
        {
            this.size = size;
        }
        private int size { get; set; }
        private Pancake max { get; set; }


        public void sort(List<Pancake> pancakes)
        {
            int biggest = 0;
            List<Pancake> sortingList = new List<Pancake>();
            int count = pancakes.Count + 1;
            for (int i = 0; i < count; i++)
            {
                foreach (Pancake pancake in pancakes)
                {
                    if (pancake.size > biggest)
                    {
                        biggest = pancake.size;
                        max = pancake;
                    }
                }
                sortingList.Add(max);
                pancakes.Remove(max);
                biggest = 0;
            }
            pancakes = sortingList;
            foreach (Pancake pancake2 in pancakes)
            {
                Console.WriteLine(pancake2.size);
            }
        }
    }
}
