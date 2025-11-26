using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    internal class Car : Vehicle
    {
        public int Seat
        {
            get;
            set;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}, Speed: {speed} km/h, Seats: {Seat}");
        }
    }
}
