using System;

namespace T11HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfHoursPerDay = int.Parse(Console.ReadLine());

            double totalParkingTax = 0;


            for (int i = 1; i <= numberOfDays; i++)
            {
                double parkingTax = 0;

                for (int j = 1; j <= numberOfHoursPerDay; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        parkingTax += 2.50;
                        
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        parkingTax += 1.25;
                        
                    }
                    else
                    {
                        parkingTax += 1.00;
                        
                    }
                }
                Console.WriteLine($"Day: {i} - {parkingTax:f2} leva");
                totalParkingTax += parkingTax;
            }
            Console.WriteLine($"Total: {totalParkingTax:f2} leva");
        }
    }
}
