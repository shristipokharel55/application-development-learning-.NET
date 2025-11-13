using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_3
{
    public class DayOfWeekFinder
    {
        public void PrintDayOfWeek()
        {
            Console.Write("Enter a number (1-7) to get the day of the week: ");

            int dayNumber;

            if (int.TryParse(Console.ReadLine(), out dayNumber))
            {
                switch (dayNumber)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a numeric value.");
            }
        }
    }
}
