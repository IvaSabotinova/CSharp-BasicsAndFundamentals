using System;

namespace T03Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCargoes = int.Parse(Console.ReadLine());
            int tonsMicrobus = 0;
            int tonsTruck = 0;
            int tonsTrain = 0;
            int totalTons = 0;
            double totalPriceOfCargo = 0;
            double percentMicrobus = 0;
            double percentTruck = 0;
            double percentTrain = 0;

            for (int i = 1; i <= numberOfCargoes; i++)
            {
                int tonsOfCargo = int.Parse(Console.ReadLine());
                if (tonsOfCargo <= 3)
                {
                    tonsMicrobus += tonsOfCargo;                    
                }
                else if (tonsOfCargo <= 11)
                {
                    tonsTruck += tonsOfCargo;
                }
                else 
                {
                    tonsTrain += tonsOfCargo;
                }
            }
            totalTons = tonsMicrobus + tonsTruck + tonsTrain;
            totalPriceOfCargo = tonsMicrobus * 200 + tonsTruck * 175 + tonsTrain * 120;
            percentMicrobus = (double)tonsMicrobus / totalTons * 100;
            percentTruck = (double)tonsTruck / totalTons * 100;
            percentTrain = (double)tonsTrain / totalTons * 100;
            Console.WriteLine($"{totalPriceOfCargo / totalTons:f2}");
            Console.WriteLine($"{percentMicrobus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");



        }
    }
}
