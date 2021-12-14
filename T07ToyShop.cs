using System;

namespace T07ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzlesNumber = int.Parse(Console.ReadLine());
            int dollsNumber = int.Parse(Console.ReadLine());
            int teddiesNumber = int.Parse(Console.ReadLine());
            int minionsNumber = int.Parse(Console.ReadLine());
            int trucksNumber = int.Parse(Console.ReadLine());

            const double puzzlePrice = 2.60;
            const double dollPrice = 3.00;
            const double teddyPrice = 4.10;
            const double minionPrice = 8.20;
            const double truckPrice = 2.00;

            int toysTotalNumber = puzzlesNumber + dollsNumber + teddiesNumber + minionsNumber + trucksNumber;
            double earnedMoney = puzzlesNumber * puzzlePrice + dollsNumber * dollPrice + teddiesNumber * teddyPrice + minionsNumber * minionPrice + trucksNumber * truckPrice;
            if (toysTotalNumber >= 50)
            {
                earnedMoney *= 0.75;
            }
            double finalEarnedAmount = earnedMoney * 0.90;

            if (finalEarnedAmount >= excursionPrice)
            {
                double leftMoney = finalEarnedAmount - excursionPrice;
                Console.WriteLine($"Yes! {leftMoney:f2} lv left.");
            }
            else
            {
                double neededMoney = excursionPrice - finalEarnedAmount;
                Console.WriteLine($"Not enough money! {neededMoney:f2} lv needed.");
            }

        }
    }
}
