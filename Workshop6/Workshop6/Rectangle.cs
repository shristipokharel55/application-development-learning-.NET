using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Rectangle
    {
        private double length;   // stores the length of rectangle
        private double breadth;  // stores the breadth of rectangle

        // Expression-bodied property for Length (get and set)
        public double Length
        {
            get => length;        // return length
            set => length = value; // store new value in length
        }

        // Expression-bodied property for Breadth (get and set)
        public double Breadth
        {
            get => breadth;        // return breadth
            set => breadth = value; // store new value in breadth
        }

        // Calculates area of rectangle
        public double GetArea() => length * breadth;

        // Shows the details of the rectangle
        public string ShowDetails() => $"Length: {length}, Breadth: {breadth}";

        // Calculates the perimeter of rectangle
        public double GetPerimeter() => 2 * (length + breadth);
    }
}
