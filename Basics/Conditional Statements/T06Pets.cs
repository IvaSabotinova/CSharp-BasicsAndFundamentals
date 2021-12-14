using System;

namespace T06Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysAbsence = int.Parse(Console.ReadLine());
            int kgFoodLeftbyLandlord = int.Parse(Console.ReadLine());
            double kgPerDayNeededForDog = double.Parse(Console.ReadLine());
            double kgPerDayNeededForCat = double.Parse(Console.ReadLine());
            double gramsPerDayNeedeForTurtle = double.Parse(Console.ReadLine());

            double kgFoodNeededForAll = kgPerDayNeededForDog * daysAbsence + kgPerDayNeededForCat * daysAbsence + gramsPerDayNeedeForTurtle * daysAbsence / 1000;

            if (kgFoodLeftbyLandlord >= kgFoodNeededForAll)
            {
                double kgFoodLeft = Math.Floor(kgFoodLeftbyLandlord - kgFoodNeededForAll);

                Console.WriteLine($"{kgFoodLeft} kilos of food left.");
            }
            else
            {
                double kgFoodShort = Math.Ceiling(kgFoodNeededForAll - kgFoodLeftbyLandlord);
                Console.WriteLine($"{kgFoodShort} more kilos of food are needed.");
            }
        }
    }
}
