namespace Workshop6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1: Expression Bodied Members 
            Console.WriteLine("Task 1: Expression Bodied Members \n");

            Rectangle rect = new Rectangle();

            rect.Length = 10;
            rect.Breadth = 5;

            Console.WriteLine(rect.ShowDetails());
            Console.WriteLine("Area = " + rect.GetArea());
            Console.WriteLine("Perimeter = " + rect.GetPerimeter());


            // Task 2: Custom Delegate 
            // Part A — Create delegate 'Calculate', Add(), Subtract()
            Console.WriteLine("\nTask 2: Custom Delegate \n");

            Console.WriteLine("Custom Delegate: Add & Subtract");

            // Creating delegate objects for Add and Subtract
            Calculate calcAdd = DelegateTasks.Add;
            Calculate calcSub = DelegateTasks.Subtract;

            Console.WriteLine("Add: " + calcAdd(10, 5));
            Console.WriteLine("Subtract: " + calcSub(10, 5));


            // Task 2: Discount Strategy Delegate
            // FestivalDiscount, SeasonalDiscount, NoDiscount
            double price = 1000;

            Console.WriteLine("\nDiscount Strategy Using Delegates");

            Console.WriteLine("Festival Discount (20%): " +
                DelegateTasks.CalculateFinalPrice(price, DelegateTasks.FestivalDiscount));

            Console.WriteLine("Seasonal Discount (10%): " +
                DelegateTasks.CalculateFinalPrice(price, DelegateTasks.SeasonalDiscount));

            Console.WriteLine("No Discount: " +
                DelegateTasks.CalculateFinalPrice(price, DelegateTasks.NoDiscount));


            // Task 2.1 — Method: CalculateFinalPrice()
            // (Already used above when applying each discount)
            // ✔ Task 2.1: Create CalculateFinalPrice() — DONE
            // ✔ Task 2.2: Call it with all discount methods — DONE above
            // ✔ Task 2.3: Call it using Lambda — below

            // Task 2.3 — Lambda Expression (30% discount)
            Console.WriteLine("\n30% Discount Using Lambda");

            // Passing lambda as delegate
            double finalWithLambda = DelegateTasks.CalculateFinalPrice(price,
                p => p * 0.70);  // 30% discount

            Console.WriteLine("Lambda 30% Discount: " + finalWithLambda);

            // Task 3 : Built-in Delegates
            Console.WriteLine("\nTask 3: Built-In Delegate (Func)\n");

            // Sample array of numbers
            int[] nums = { 2, 5, 12, 7, 20, 3, 15 };

            // 1️ Printing only even numbers
            Console.WriteLine("Even Numbers:");
            BuiltInDelegateTasks.ProcessNumbers(nums, n => n % 2 == 0);

            // 2️ Printing numbers greater than 10
            Console.WriteLine("\nNumbers Greater Than 10:");
            BuiltInDelegateTasks.ProcessNumbers(nums, n => n > 10);

            // Task 4: LINQ
            Console.WriteLine("\nTask 4: LINQ Basics\n");

            // 4.1 Squaring Numbers
            LinqTasks.SquareNumbers();

            // 4.2 Filter books above Rs. 1000
            LinqTasks.FilterPremiumBooks();

            // 4.3 Sort student names
            LinqTasks.SortStudents();

            // Task 5: LINQ Continued

            Console.WriteLine("\nTask 5: LINQ Continued\n");

            LinqTasksContinued.AggregationExample();
            LinqTasksContinued.QuantifierExample();
            LinqTasksContinued.ElementExample();

            // Task 6: LINQ Continued
            Console.WriteLine("\nTask 6: Travel Company LINQ Filtering\n");

            LinqTask6.RunTask6();
        }
    }
}
