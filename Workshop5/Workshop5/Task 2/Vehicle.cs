using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    internal class Vehicle
    {
        //proporties of vehicle class
        public string brand;
        public int speed;

        //method creation
        public void Start()
        {
            Console.WriteLine($"{brand} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{brand} is stopping...");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}, Speed: {speed} km/h");
        }
    }
}
