using System;

namespace T03Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyardAreaX = int.Parse(Console.ReadLine());
            double grapePerSquareMeterY = double.Parse(Console.ReadLine());
            int wineNeededForSaleZ = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double vineyardAreaForWine = vineyardAreaX * 0.40;
            double kgGrapeTotal = grapePerSquareMeterY * vineyardAreaForWine;
            double wineLitresProduced = kgGrapeTotal / 2.5;

            if (wineLitresProduced < wineNeededForSaleZ)
            {
                double wineLitresShort = Math.Floor(wineNeededForSaleZ - wineLitresProduced);

                Console.WriteLine($"It will be a tough winter! More {wineLitresShort} liters wine needed.");
            }
            else
            {
                

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLitresProduced)} liters.");

                double wineLitresMoreEven = Math.Ceiling(wineLitresProduced - wineNeededForSaleZ);
                double wineLitresPerPerson = Math.Ceiling(wineLitresMoreEven / numberOfWorkers);                
             
                Console.WriteLine($"{wineLitresMoreEven} liters left -> {wineLitresPerPerson} liters per person.");

                }


               }
    }
}
