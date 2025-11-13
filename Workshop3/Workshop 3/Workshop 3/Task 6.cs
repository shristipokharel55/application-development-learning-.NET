using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_3
{
    public class ExceptionHandlingTasks
    {
        // ?? Task 1: Number Conversion with Exception Handling
        public void ConvertToInteger()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                int number = Convert.ToInt32(input);
                Console.WriteLine($"You entered number {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        // ?? Task 2: Password Length Check with throw
        public void PasswordCheck()
        {
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            try
            {
                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
