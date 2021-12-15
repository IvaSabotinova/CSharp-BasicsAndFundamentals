using System;

namespace T01Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBottles = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            const int bottleDetergent = 750;
            const int detergentPerDish = 5;
            const int detergentPerPot = 15;
            int availableDetergent = numberOfBottles * bottleDetergent;
            int dishRechargeCounter = 0;
            int dishesCleaned = 0;
            int potsCleaned = 0;

            while (input != "End")
            {
                int numberOfDishesOrPots = int.Parse(input);
                dishRechargeCounter++;   
                
                if (dishRechargeCounter % 3 == 0)
                {
                    availableDetergent -= numberOfDishesOrPots * detergentPerPot;
                    potsCleaned += numberOfDishesOrPots;

                }
                else
                {
                    availableDetergent -= numberOfDishesOrPots * detergentPerDish;
                    dishesCleaned += numberOfDishesOrPots;
                }
                if (availableDetergent < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(availableDetergent)} ml. more necessary!"); return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{dishesCleaned} dishes and {potsCleaned} pots were washed.");
            Console.WriteLine($"Leftover detergent {availableDetergent} ml.");
        }
    }
}
