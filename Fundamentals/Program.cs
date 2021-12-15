using System;

namespace _01._Burger_Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            double totalProfit = 0;

            for (int i = 1; i <= numberOfCities; i++)
            {

                string cityName = Console.ReadLine();
                double earnedMoneyPerCity = double.Parse(Console.ReadLine());
                double expensesPerCity = double.Parse(Console.ReadLine());


                if (i % 3 == 0 && i % 5 != 0)
                {
                    expensesPerCity *= 1.50;
                }

                if (i % 5 == 0)
                {
                    earnedMoneyPerCity *= 0.90;

                }

                earnedMoneyPerCity -= expensesPerCity;




                totalProfit += earnedMoneyPerCity;

                Console.WriteLine($"In {cityName} Burger Bus earned {earnedMoneyPerCity:f2} leva.");

            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
