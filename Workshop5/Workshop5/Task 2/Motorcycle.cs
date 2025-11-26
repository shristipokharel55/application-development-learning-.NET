using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    internal class Motorcycle : Vehicle
    {
        public string Model
        {
            get;
            set;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}, Speed: {speed} km/h, Model: {Model}");
        }
    }
}
