using System.Runtime.InteropServices;
using Workshop4;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Workshop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1 (Class, Object & Fields)
            Console.WriteLine("Task 1: Class, Object & Fields\n");

            //creating first student object
            Student st = new Student();
            st.name = "Shristi Pokharel";
            st.age = 20;
            st.address = "Itahari-2, Shantinagar";

            //creating another student object
            Student st2 = new Student();
            st2.name = "Aaska Ghimire";
            st2.age = 19;
            st2.address = "Itahari-20, Sunsari";

            // Display details of first student
            Console.WriteLine("Student 1 Details:");
            Console.WriteLine($"Name: {st.name}");
            Console.WriteLine($"Age: {st.age} years");
            Console.WriteLine($"Address: {st.address}");

            // Display details of second student
            Console.WriteLine("\nStudent 2 Details:");
            Console.WriteLine($"Name: {st2.name}");
            Console.WriteLine($"Age: {st2.age} years");
            Console.WriteLine($"Address: {st2.address}");

            // Display static field
            Console.WriteLine($"\nSchool Name (Static Field): {Student.schoolName} \n");

            //task 2
            Console.WriteLine("Task 2: Methods and Return types\n");

            Calculator calc = new Calculator();

            //Call method 1
            calc.PrintWelcome();



            //call method 2
            int num1 = 5;
            int num2 = 8;
            int sum = calc.Add(num1, num2);
            Console.WriteLine($"Addition of the number {num1} and {num2} is {sum}");

            //call method 3
            int multiply = calc.Multiply(num1, num2);
            Console.WriteLine($"Product of the number {num1} and {num2} is {multiply}");

            //task 3
            Console.WriteLine("\nTask 3: Parameter types\n");

            ParameterDemo demo = new ParameterDemo();

            //Calling Increase using ref
            int value = 20;
            demo.Increase(ref value);
            Console.WriteLine("After Increase: " + value);

            //Calling GetFullName using out
            string myName;
            demo.GetFullName(out myName);
            Console.WriteLine("Full Name: " + myName);

            //Calling SumAll using params
            int total = demo.SumAll(5, 10, 15, 20);
            Console.WriteLine("Sum of all numbers: " + total);

            //task 4
            Console.WriteLine("\nTask 4: Constructors\n");

            //Object using default constructor
            Player p1 = new Player();

            //Printing values (they will be default since not initialized)
            Console.WriteLine("\nPlayer 1 Details:");
            Console.WriteLine("Name: " + p1.playerName);
            Console.WriteLine("Level: " + p1.level);
            Console.WriteLine("Health: " + p1.health);

            // Object using parameterized constructor
            Player p2 = new Player("Siri", 5, 100);

            // Printing values
            Console.WriteLine("\nPlayer 2 Details:");
            Console.WriteLine("Name: " + p2.playerName);
            Console.WriteLine("Level: " + p2.level);
            Console.WriteLine("Health: " + p2.health);

            //task 5 Enums and Records
            Console.WriteLine("\nTask 5: Enums and Records\n");

            Console.Write("Enter a day: ");
            string day = Console.ReadLine().Trim().ToLower();

            DayType type;

            if (day == "friday" || day == "saturday")
            {
                type = DayType.Weekend;
            }
            else
            {
                type = DayType.Weekday;
            }

            Console.WriteLine($"It is: {type}");

            // Original book object
            Book book1 = new Book("C# Basics", "Khilendra Chaudhary", 500.75);

            // Create second object using with expression (changing title & price)
            Book book2 = book1 with { title = "Advanced C#", price = 800.60 };

            // Print first object
            Console.WriteLine("\nBook 1:");
            Console.WriteLine(book1);


            // Deconstructing book2
            var (title, author, price) = book2;

            Console.WriteLine("\nBook 2 (Deconstructed):");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");

            //task 6: Debugging
            Console.WriteLine("\nTask 6: Debugging\n");

            Console.Write("Enter marks: ");
            bool isMarksValid = int.TryParse(Console.ReadLine(), out int marks);


            Console.Write("Enter total: ");
            bool isTotalValid = int.TryParse(Console.ReadLine(), out int totalMarks);

            if (!isMarksValid || !isTotalValid)
            {
                Console.WriteLine("Invalid input. Please enter integer values.");
                return;
            }

            // BREAKPOINT - before calculation
            double percentage = marks / totalMarks * 100;

            // BREAKPOINT 2 - after calculation
            Console.WriteLine("Percentage = " + percentage);

            //Why was the output incorrect?
            //The output was incorrect because marks and total are integers. Dividing two integers in C# results in integer division, which removes decimal values. So, marks / total gave 0 for many inputs, leading to the wrong percentage.

            //How to correct the program?
            //Convert one operand to double before division:
            //double percentage = (double)marks / total * 100;
        }
    }
}


