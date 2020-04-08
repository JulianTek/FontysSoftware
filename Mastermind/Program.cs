using System;
using Mastermind.Classes;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            int bestResult;
            Guesser guesser = new Guesser();
            guesser.setCode();
            guesser.firstGuess();
            foreach (int i in guesser.guessList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
            int firstResult = guesser.compare();
            Console.WriteLine(firstResult);
            guesser.otherGuess();
            Console.WriteLine("");
            foreach (int i in guesser.guessList)
            {
                Console.WriteLine(i);
            }
            int nextResult = guesser.compare();
            Console.WriteLine("");
            Console.WriteLine(nextResult);

            if (nextResult > firstResult)
            {
                bestResult = nextResult;
            }
            else
            {
                bestResult = firstResult;
            }
            firstResult = nextResult;
            Console.WriteLine(bestResult);

        }
    }
}
