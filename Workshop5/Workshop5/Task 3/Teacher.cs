using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    internal class Teacher
    {
        public string Name;
        public virtual void Teaching()
        {
            // Default implementation (can be empty or have base logic)
        }
        public void SalaryInfo()
        {
            Console.WriteLine($"{Name} has a monthly salary of Rs. 30000");
        }
    }
}
