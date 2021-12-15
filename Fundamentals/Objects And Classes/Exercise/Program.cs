using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T06VehicleCatalogueVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> allVehicles = new List<Vehicle>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                VehicleType vechType;

                bool hasVehicleType = Enum.TryParse(tokens[0], true, out vechType);

                if (hasVehicleType)
                {
                    string vehicleModel = tokens[1];
                    string vehicleColor = tokens[2];
                    int vehicleHorsePower = int.Parse(tokens[3]);

                    Vehicle  newVehicle = new Vehicle(vechType, vehicleModel, vehicleColor, vehicleHorsePower);
                    allVehicles.Add(newVehicle);
                    
                }

                command = Console.ReadLine();
            }

            string newCommand = Console.ReadLine();

            while (newCommand != "Close the Catalogue")
            {
                Vehicle carOrTruck = allVehicles.FirstOrDefault(unit => unit.ModelOfVehicle == newCommand);
                Console.WriteLine(carOrTruck);

                newCommand = Console.ReadLine();
            }

            var Car = allVehicles.Where(unit => unit.TypeOfVehicle == VehicleType.Car);
            var Truck = allVehicles.Where(unit => unit.TypeOfVehicle == VehicleType.Truck);

            double averageCarHorsePower = Car.Any() ? Car.Average(unit => unit.HorsepowerOfVehicle): 0.0;
            double averageTruckHorsePower = Truck.Any() ? Truck.Average(unit => unit.HorsepowerOfVehicle) : 0.0;
            Console.WriteLine($"Cars have average horsepower of: {averageCarHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePower:f2}.");


        }
        enum VehicleType
        {
            Car,
            Truck
        }

        class Vehicle
        {
            public Vehicle(VehicleType vehicleType, string model, string color, int horsePower)
            {
                TypeOfVehicle = vehicleType;
                ModelOfVehicle = model;
                ColorOfVehicle = color;
                HorsepowerOfVehicle = horsePower;

            }



            public VehicleType TypeOfVehicle { get; set; }
            public string ModelOfVehicle { get; set; }
            public string ColorOfVehicle { get; set; }
            public int HorsepowerOfVehicle { get; set; }

            public override string ToString()
            {
                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.AppendLine($"Type: {TypeOfVehicle}");
                stringBuilder.AppendLine($"Model: {ModelOfVehicle}");
                stringBuilder.AppendLine($"Color: {ColorOfVehicle}");
                stringBuilder.AppendLine($"Horsepower: {HorsepowerOfVehicle}");
                return stringBuilder.ToString().TrimEnd();

            }
        }
    }
    
}
