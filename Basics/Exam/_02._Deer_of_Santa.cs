using System;

namespace _02._Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysAbsence = int.Parse(Console.ReadLine());
            int foodLeftKg = int.Parse(Console.ReadLine());
            double deer1FoodPerdayNeeded = double.Parse(Console.ReadLine());
            double deer2FoodPerdayNeeded = double.Parse(Console.ReadLine());
            double deer3FoodPerdayNeeded = double.Parse(Console.ReadLine());

            double totalFoodNeeded = deer1FoodPerdayNeeded * daysAbsence + deer2FoodPerdayNeeded * daysAbsence + deer3FoodPerdayNeeded * daysAbsence;

            if (foodLeftKg >= totalFoodNeeded)
            {
                Console.WriteLine($"{Math.Floor(foodLeftKg - totalFoodNeeded)} kilos of food left.");
            }
            else 
            {

                Console.WriteLine($"{Math.Ceiling(totalFoodNeeded - foodLeftKg)} more kilos of food are needed.");
            }
        }
    }
}
