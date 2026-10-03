using System;
using System.Collections.Generic;
using System.Text;
using Vehicleclass.Domain;


namespace Vehicleclass.Domain
{ 

    public class Vehicle
    {
        private string _licensePlate;
        private int _id;
        private int _chilometers;
        private double _dailyRate;
        private double _fuelLevelPercentuage;

        public string LicensePlate { get; private set; } // sia get che set sono pubblici
        public int Chilometers {
            get
            {
                return _chilometers;
            }
            private set
            { if (value < 0) throw new ArgumentException("Chilometers cannot be negative");
                _chilometers = value;

            }
        }



        public double DailyRate { get; private set; }
        public double FuelLevelPercentuage { get; private set; };

        public string GetLicensePlate() // è un metodo quindi una fuzione che restituisce un valore, in questo caso una stringa
        {
            return _licensePlate;

        }

        public Vehicle(string licencePlate) // STO DICENDO CHE UN MODO PER COSTRUIRE UN OGGETTO DI TIPO VEHICLE E' PASSARE UNA STRINGA!!! L'unico modo per costruirlo è passare una stringa( in questo caso la targa)
        {
            LicensePlate = licencePlate;
        }
        
        public Vehicle(string licenceplate, int chilometers, double dailyRate, double fuelLevelPercentuage)
        {
            LicensePlate = licenceplate;
            
        }
    }
}
