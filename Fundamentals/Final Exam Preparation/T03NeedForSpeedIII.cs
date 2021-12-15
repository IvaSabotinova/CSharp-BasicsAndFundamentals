using System;
using System.Collections.Generic;
using System.Linq;


namespace T03NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, int> cars_Mileage = new Dictionary<string, int>();
            Dictionary<string, int> cars_Fuel = new Dictionary<string, int>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carsMileageFuel = Console.ReadLine().Split("|");
                string car = carsMileageFuel[0];
                int mileage = int.Parse(carsMileageFuel[1]);
                int fuel = int.Parse(carsMileageFuel[2]);

                cars_Mileage.Add(car, mileage);
                cars_Fuel.Add(car, fuel);
                
            }

            string[] command = Console.ReadLine().Split(" : ");

            while (command[0] != "Stop")
            {
                string car = command[1];
                
                if (command[0] == "Drive")
                {
                    int distance = int.Parse(command[2]);
                    int consumedFuel = int.Parse(command[3]);
                    
                    if (cars_Fuel[car] < consumedFuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else if (cars_Fuel[car] >= consumedFuel)
                    {
                        cars_Fuel[car] -= consumedFuel;
                        cars_Mileage[car] += distance;
                        Console.WriteLine(
                            $"{car} driven for {distance} kilometers. {consumedFuel} liters of fuel consumed.");
                        if (cars_Mileage[car] >= 100000)
                        {
                            
                            Console.WriteLine($"Time to sell the {car}!");
                            cars_Fuel.Remove(car);
                            cars_Mileage.Remove(car);
                        }
                       
                    }
                }
                else if (command[0] == "Refuel")
                {
                    int fuel = int.Parse(command[2]);

                    int oldFuelAmount = cars_Fuel[car];

                    cars_Fuel[car] += fuel;
                    if (cars_Fuel[car] > 75)
                    {
                        cars_Fuel[car] = 75;
                        Console.WriteLine($"{car} refueled with {75-oldFuelAmount} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }

                }
                else if (command[0] == "Revert")
                {
                    int mileage = int.Parse(command[2]);
                    cars_Mileage[car] -= mileage;
                    if (cars_Mileage[car] < 10000)
                    {
                        cars_Mileage[car] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {mileage} kilometers");
                    }
                }
               

                command = Console.ReadLine().Split(" : ");
            }

            foreach (KeyValuePair<string,int> car in cars_Mileage.OrderByDescending(x=>x.Value).ThenBy(a=>a.Key))
            {
                foreach (KeyValuePair<string, int> item in cars_Fuel)
                {
                    if (car.Key == item.Key)
                    {
                        Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {item.Value} lt.");

                    }
                }
                
            }
        }
    }
}
