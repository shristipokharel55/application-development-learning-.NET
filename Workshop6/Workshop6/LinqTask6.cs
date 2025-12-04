using System;
using System.Collections.Generic;
using System.Linq;

namespace Workshop6
{
    // Class representing a Tour Booking
    public class TourBooking
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDays { get; set; }
        public bool IsInternational { get; set; }

        public TourBooking(string customer, string dest, double price, int duration, bool isInternational)
        {
            CustomerName = customer;
            Destination = dest;
            Price = price;
            DurationInDays = duration;
            IsInternational = isInternational;
        }
    }

    public class LinqTask6
    {
        // Method to demonstrate filtering using LINQ
        public static void RunTask6()
        {
            // Creating sample tour bookings
            List<TourBooking> tours = new List<TourBooking>
            {
                new TourBooking("Rohan", "Pokhara", 8000, 3, false),
                new TourBooking("Sita", "Bali", 45000, 5, true),
                new TourBooking("Mina", "Kathmandu", 6000, 2, false),
                new TourBooking("Bishal", "Dubai", 30000, 6, true),
                new TourBooking("Aayush", "Chitwan", 12000, 4, false)
            };

            Console.WriteLine("Task 6: LINQ Continued – Travel Company Report  ");

            // 1. Filter tours above Rs. 10,000
            var expensiveTours = tours.Where(t => t.Price > 10000);

            Console.WriteLine("\nTours Above Rs. 10,000:");
            foreach (var t in expensiveTours)
            {
                Console.WriteLine($"{t.CustomerName}, {t.Destination}, Rs. {t.Price}");
            }

            // 2. Filter tours with duration more than 4 days
            var longTours = tours.Where(t => t.DurationInDays > 4);

            Console.WriteLine("\nTours Longer Than 4 Days:");
            foreach (var t in longTours)
            {
                Console.WriteLine($"{t.CustomerName}, {t.Destination}, {t.DurationInDays} days");
            }
        }
    }
}
