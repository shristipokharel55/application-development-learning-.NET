using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_3
{
    public class Operators
    {
        //task 1
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            return (double)a / b;
        }

        public void OddEvenFinder(int num)
        {
            string result = (num % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine($"{num} is an {result}");
        }
    }
}
