using System;

namespace T01ChristmasPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollPaperNumber = int.Parse(Console.ReadLine());
            int rollClothNumber = int.Parse(Console.ReadLine());
            double litresGlue = double.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            

            double totalExpenses = (rollPaperNumber * 5.80 + rollClothNumber * 7.20 + litresGlue * 1.20) * (1.0 * (100 - percentDiscount) / 100);
            

            Console.WriteLine($"{totalExpenses:f3}");
        }
    }
}
