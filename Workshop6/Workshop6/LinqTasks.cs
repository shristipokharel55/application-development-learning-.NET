using System;
using System.Collections.Generic;
using System.Linq;

namespace Workshop6
{
    public class LinqTasks
    {
        // Task 4.1 → Squaring numbers using LINQ
        public static void SquareNumbers()
        {
            // List of integers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Using LINQ Select() to square each number
            var squared = numbers.Select(n => n * n);

            Console.WriteLine("Squared Numbers:");
            foreach (var num in squared)
                Console.WriteLine(num);
        }


        // Task 4.2 → Filtering premium books using LINQ
        public static void FilterPremiumBooks()
        {
            // Creating a list of book objects
            List<Book> books = new List<Book>
            {
                new Book("C# Programming", 850),
                new Book("AI Fundamentals", 1200),
                new Book("Cloud Computing", 1500),
                new Book("Basic HTML", 500)
            };

            // Using Where() to get books priced above 1000
            var premium = books.Where(b => b.Price > 1000);

            Console.WriteLine("\nBooks Priced Above Rs. 1000:");
            foreach (var b in premium)
                Console.WriteLine($"{b.Title} - Rs. {b.Price}");
        }


        // Task 4.3 → Sorting student names alphabetically
        public static void SortStudents()
        {
            // Creating a list of student objects
            List<Student> students = new List<Student>
            {
                new Student("Salina"),
                new Student("Anuj"),
                new Student("Darshan"),
                new Student("Aagya"),
                new Student("Alzeena"),
                new Student("Samana"),
                new Student("Dibya"),
                new Student("Nikesh"),
                new Student("Dev"),
                new Student("Shovan")
            };

            // Sorting student names alphabetically
            var sortedStudents = students.OrderBy(s => s.Name);

            Console.WriteLine("\nStudents Sorted Alphabetically:");
            foreach (var s in sortedStudents)
                Console.WriteLine(s.Name);
        }
    }


    // Simple Book class
    public class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }

        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }
    }

    // Simple Student class
    public class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }
}
