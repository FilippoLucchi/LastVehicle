using System;
using System.Collections.Generic;
using System.Text;
using Vehicleclass.Domain;
using BlaisePascal.LastVehicle.UiConsole;

namespace BlaisePascal.LastVehicle.UiConsole {
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            string license = vehicle.GetLicensePlate();

            Console.WriteLine($"Vehicle license {license}");
        }
    }
}
