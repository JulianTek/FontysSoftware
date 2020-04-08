using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public class Calculator
    {

        public static double Add(double first, double second)
        {
            double result = first + second;
            return result;
        }

        public static double Subtract(double first, double second)
        {
            double result = first - second;
            return result;
        }

        public static double Multiply(double first, double second)
        {
            double result = first * second;
            return result;
        }

        public static double Divide(double first, double second)
        {
            if (second != 0)
            {
                double result = first / second;
                return result;
            }
            MessageBox.Show("Cannot divide by 0!");
            return 1;
        }

        public static double Square(double first)
        {
            double result = first * first;
            return result;
        }

        public static double Root(double first)
        {
            double result = Math.Sqrt(first);
            return result;
        }
    }


}
