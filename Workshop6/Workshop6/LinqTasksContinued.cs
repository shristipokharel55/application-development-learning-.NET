using System;
using System.Collections.Generic;
using System.Linq;

namespace Workshop6
{
    public class LinqTasksContinued
    {
        // Task 5.1 — Aggregation Operators
        public static void AggregationExample()
        {
            // Creating cashier sales data (dummy data)
            List<CashierSales> salesList = new List<CashierSales>
            {
                new CashierSales("Cashier A", 5000),
                new CashierSales("Cashier B", 6500),
                new CashierSales("Cashier C", 7200),
                new CashierSales("Cashier D", 4300)
            };

            // LINQ aggregation calculations
            int totalCashiers = salesList.Count();              // total number of cashiers
            double totalSales = salesList.Sum(s => s.Sales);    // total sales
            double highest = salesList.Max(s => s.Sales);        // highest sales
            double lowest = salesList.Min(s => s.Sales);         // lowest sales
            double average = salesList.Average(s => s.Sales);    // average sales

            Console.WriteLine("Aggregation Operators");
            Console.WriteLine($"Total Cashiers: {totalCashiers}");
            Console.WriteLine($"Total Sales: Rs. {totalSales}");
            Console.WriteLine($"Highest Sale: Rs. {highest}");
            Console.WriteLine($"Lowest Sale: Rs. {lowest}");
            Console.WriteLine($"Average Sale: Rs. {average}");
        }

        // Task 5.2 — Quantifier Operators
        public static void QuantifierExample()
        {
            // Creating a list of applicants with ages
            List<Applicant> applicants = new List<Applicant>
            {
                new Applicant("Rohan", 19),
                new Applicant("Sita", 17),
                new Applicant("Bishal", 22),
                new Applicant("Mina", 16)
            };

            // Any applicant under 18?
            bool anyUnder18 = applicants.Any(a => a.Age < 18);

            // Are ALL applicants above 16?
            bool allAbove16 = applicants.All(a => a.Age > 16);

            Console.WriteLine("\nQuantifier Operators (Any/All)");
            Console.WriteLine($"Any applicant under 18? {anyUnder18}");
            Console.WriteLine($"Are all applicants above 16? {allAbove16}");
        }

        // Task 5.3 — Element Operators
        public static void ElementExample()
        {
            // List of songs with duration in seconds
            List<Song> songs = new List<Song>
            {
                new Song("Track 1", 150), // 2.5 minutes
                new Song("Track 2", 240), // 4 minutes
                new Song("Track 3", 300), // 5 minutes
                new Song("Track 4", 420)  // 7 minutes
            };

            Console.WriteLine("\nElement Operators (First, Last, FirstOrDefault)");

            // 1. First song
            var firstSong = songs.First();
            Console.WriteLine($"First Song: {firstSong.Title}");

            // 2. Last song
            var lastSong = songs.Last();
            Console.WriteLine($"Last Song: {lastSong.Title}");

            // 3. First song above 4 minutes (240 sec)
            var above4Min = songs.First(s => s.Duration > 240);
            Console.WriteLine($"First Song > 4 min: {above4Min.Title}");

            // 4. Safe search: First song above 10 minutes (600 sec)
            //    If none found → returns null instead of error
            var above10Min = songs.FirstOrDefault(s => s.Duration > 600);

            if (above10Min == null)
                Console.WriteLine("No song found above 10 minutes (safe result).");
            else
                Console.WriteLine($"Song > 10 minutes: {above10Min.Title}");
        }
    }

    public class CashierSales
    {
        public string CashierName { get; set; }
        public double Sales { get; set; }

        public CashierSales(string name, double sales)
        {
            CashierName = name;
            Sales = sales;
        }
    }

    public class Applicant
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Applicant(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Song
    {
        public string Title { get; set; }
        public int Duration { get; set; } // seconds

        public Song(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }
    }
}