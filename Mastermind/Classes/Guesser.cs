using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind.Classes
{
    class Guesser
    {
        private List<int> codeList = new List<int>();
        public List<int> guessList = new List<int>();
        Random rng = new Random();

        public void setCode()
        {
            codeList.Add(1);
            codeList.Add(0);
            codeList.Add(0);
            codeList.Add(1);
            codeList.Add(1);
            codeList.Add(0);
        }

        public void firstGuess() 
        {
            for (int i = 0; i < codeList.Count; i ++) {
            guessList.Add(rng.Next(0, 2));
            }
            }
        public int compare()
        {
            int correct = 0;
            for (int i = 0; i < guessList.Count; i++)
            {
                if (codeList[i] == guessList[i])
                {
                    correct++;
                }
            }
            return correct;
        }

        public void otherGuess()
        {
          int toChange =  rng.Next(0, guessList.Count + 1);
            if (guessList[toChange] == 0)
            {
                guessList[toChange] = 1;
            }
            else
            {
                guessList[toChange] = 0;
            }
        }
    }
}

