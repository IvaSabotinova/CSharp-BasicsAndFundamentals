using System;

namespace T08FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litresInReservoir = double.Parse(Console.ReadLine());

            if (fuelType == "Diesel" && litresInReservoir >= 25)
            {      

                Console.WriteLine($"You have enough {fuelType}.");
            }
            
            else if (fuelType == "Gasoline" && litresInReservoir >= 25)
            {
                
                Console.WriteLine($"You have enough {fuelType}.");
            }
            else if (fuelType == "Gas" && litresInReservoir >= 25)
            {
                
                Console.WriteLine($"You have enough {fuelType}.");
            }
            else if (fuelType == "Diesel" && litresInReservoir < 25)
            {
               
                Console.WriteLine($"Fill your tank with {fuelType}!");
            }
            else if (fuelType == "Gasoline" && litresInReservoir < 25)
            {
                
                Console.WriteLine($"Fill your tank with {fuelType}!");
            }
            else if (fuelType == "Gas" && litresInReservoir < 25)
            {
                
                Console.WriteLine($"Fill your tank with {fuelType}!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
