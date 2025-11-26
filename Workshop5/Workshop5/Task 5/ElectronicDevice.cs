using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    internal abstract class ElectronicDevice
    {
        private string brand;
        private double price;

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public ElectronicDevice(string brand, double price)
        {
            this.brand = brand;
            this.price = price;
        }

        public abstract void ShowInfo();
    }
}
