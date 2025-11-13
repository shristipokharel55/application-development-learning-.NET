using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_3
{
    public class LoopTask
    {
        public void SumFrom1toN()
        {
            Console.WriteLine("Enter a number: ");
            int n;
            string input = Console.ReadLine();

            if (int.TryParse(input, out n))
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"Sum from 1 to {n} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        public void PrintNumbersWithConditions()
        {
            int i = 1;
            while (i <= 20)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue; // skip multiples of 4
                }

                if (i == 15)
                {
                    Console.WriteLine("Reached 15, stopping the loop!");
                    break; // stop the loop when number is 15
                }

                Console.WriteLine(i);
                i++;
            }
        }

        public void SumArrayElements()
        {
            int[] numbers = { 3, 6, 9, 12, 15 };
            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("Array elements: " + string.Join(", ", numbers));
            Console.WriteLine($"Sum of all array elements: {sum}");
        }
    }
}
