using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    internal class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price)
        {
        }
        public void EnableCamera()
        {
            Console.WriteLine("Camera enabled.");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"\nSmartphone Brand: {Brand}, Price: {Price}");
        }
    }
}
