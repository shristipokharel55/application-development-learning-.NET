using System;

namespace Workshop6
{
    public class BuiltInDelegateTasks
    {
        // This method receives an array of numbers
        // and a Func<int, bool> condition.
        // Func<int, bool> means: takes an int input, returns true/false.
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            // Inform user that processing is happening
            Console.WriteLine("Processing numbers...");

            // Loop through each number
            foreach (int num in numbers)
            {
                // Check the condition passed by the Func delegate
                if (condition(num))
                {
                    // If condition is true, print the number
                    Console.WriteLine(num);
                }
            }
        }
    }
}
