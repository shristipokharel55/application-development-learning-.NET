using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_3
{
    public class AgeChecker
    {
        public void checkAgeCatagory()
        {
            Console.WriteLine("Enter your age: ");

            string input = Console.ReadLine();
            int age;
            if (int.TryParse(input, out age))
            {
                if (age < 13)
                {
                    Console.WriteLine("You are a Child.");
                }
                else if (age >= 13 && age <= 19)
                {
                    Console.WriteLine("You are a Teenager.");
                }
                else if (age >= 20)
                {
                    Console.WriteLine("You are an Adult.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
