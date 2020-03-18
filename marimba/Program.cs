using System;

namespace marimba
{
    class Program
    {
        static void Main(string[] args)
        {
            cMarimba Marimba = new cMarimba();
            Marimba.playNote("d");
            Marimba.playNote("a");
            Marimba.playNote("f#");
            Marimba.playNote("c");
        }
    }
}
