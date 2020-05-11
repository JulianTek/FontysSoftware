using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintAI
{
   public static class Sort
    {

        public static string Calc(List<Button> buttons)
        {
            int whiteButtons = 0;
            int blueButtons = 0;
            int orangeButtons = 0;
            foreach(Button button in buttons)
            {
                if (button.BackColor == Color.White)
                {
                    whiteButtons++;
                }
                else if (button.BackColor == Color.Blue)
                {
                    blueButtons++;
                }
                else
                {
                    orangeButtons++;
                }
            }

            return GetResult(whiteButtons, blueButtons, orangeButtons);
        }

        public static double Divide(int numberToDivide)
        {
            double index = numberToDivide / 45.0;
            double result = index * 100;
            return Math.Round(result, 2);
        }

        public static string GetResult(int whiteButtons, int blueButtons, int orangeButtons)
        {
            double whitePercentage = Divide(whiteButtons);
            double bluePercentage = Divide(blueButtons);
            double orangePercentage = Divide(orangeButtons);
            return "Percentage white buttons: " + whitePercentage + ". Percentage blue buttons:" + bluePercentage +
                   ". Percentage orange buttons: " + orangePercentage;
        }
    }
}
