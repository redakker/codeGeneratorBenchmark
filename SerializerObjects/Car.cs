using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializerObjects
{
    public class Car
    {
        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Camry";
        public int Year { get; set; } = 2020;
        public string Color { get; set; } = "Silver";
        public double Price { get; set; } = 25000;
        public string[] Features { get; set; } = { "Bluetooth", "Backup Camera", "Sunroof" };
        public string[] Owners { get; set; } = { "John Doe", "Jane Doe" };
        public string VIN { get; set; } = "1HGCM82633A004352";
        public string EngineType { get; set; } = "V6";
        public int Horsepower { get; set; } = 268;
        public string Transmission { get; set; } = "Automatic";
        public string FuelType { get; set; } = "Gasoline";
        public bool IsElectric { get; set; } = false;
        public bool IsLuxury { get; set; } = false;
        public bool IsFourWheelDrive { get; set; } = false;
    }
}
