namespace Workshop_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("Task 1: Opeartors");
            Operators ops = new Operators();
            int a = 10;
            int b = 5;
            int add = ops.Add(a, b);
            Console.WriteLine($"Addition of number {a} and {b} is {add}");

            int sub = ops.Subtract(a, b);
            Console.WriteLine($"Difference of number {a} and {b} is {sub}");

            int multiply = ops.Multiply(a, b);
            Console.WriteLine($"Multiplication of the number {a} and {b} is {multiply}");

            double div = ops.Divide(a, b);
            Console.WriteLine($"Division of the number {a} and {b} is {div}");

            ops.OddEvenFinder(a);
            ops.OddEvenFinder(b);

            //task 2
            Console.WriteLine("\nTask 2: Null Operations");
            NullOperations nullOps = new NullOperations();
            nullOps.PerformNullChecks();

            //task 3
            Console.WriteLine("\nTask 3: Age Checker");
            AgeChecker ageChecker = new AgeChecker();
            ageChecker.checkAgeCatagory();

            //task 4
            Console.WriteLine("\nTask 4: Day of the Week Finder");
            DayOfWeekFinder dayFinder = new DayOfWeekFinder();
            dayFinder.PrintDayOfWeek();

            //task 5
            Console.WriteLine("\nTask 5: Loop Tasks");
            LoopTask loopTask = new LoopTask();
            loopTask.SumFrom1toN();
            loopTask.PrintNumbersWithConditions();
            loopTask.SumArrayElements();

            //task 6
            Console.WriteLine("\nTask 6: Exception Handling Operations");
            ExceptionHandlingTasks exceptionTasks = new ExceptionHandlingTasks();
            exceptionTasks.ConvertToInteger();
            exceptionTasks.PasswordCheck();


            Console.ReadLine();
        }
    }
}