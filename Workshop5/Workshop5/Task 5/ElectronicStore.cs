using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    internal class ElectronicStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
        }

        public void ShowAllDeviceDetails()
        {
            foreach (var device in devices)
            {
                device.ShowInfo();

                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }

                if (device is Smartphone smartphone)
                {
                    smartphone.EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}
