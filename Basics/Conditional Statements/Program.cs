using System;

namespace T07FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPfMagnolias = int.Parse(Console.ReadLine());
            int numberOfHyacinths = int.Parse(Console.ReadLine());
            int numberOfRoses = int.Parse(Console.ReadLine());
            int numberOfCactuses = int.Parse(Console.ReadLine());
            double priceOfPresent = double.Parse(Console.ReadLine());

            double moneyEarned = numberPfMagnolias * 3.25 + numberOfHyacinths * 4 + numberOfRoses * 3.50 + numberOfCactuses * 8;
            double moneyEarnedAfterTaxes = moneyEarned * 0.95;

            if (priceOfPresent <= moneyEarnedAfterTaxes)
            {
                double moneyLeft = Math.Floor(moneyEarnedAfterTaxes - priceOfPresent);
                Console.WriteLine($"She is left with {moneyLeft} leva.");

            }
            else
            {
                double moneyToBorrow = Math.Ceiling(priceOfPresent - moneyEarnedAfterTaxes);
                Console.WriteLine($"She will have to borrow {moneyToBorrow} leva.");

            }


        }
    }
}
