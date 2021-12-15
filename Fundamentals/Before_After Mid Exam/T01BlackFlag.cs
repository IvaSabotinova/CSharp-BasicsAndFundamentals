using System;

namespace MidExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDaysPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int i = 1; i <= numberOfDaysPlunder; i++)
            {
                totalPlunder += dailyPlunder;
                if (i % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 0.50;
                }

                if (i % 5 == 0)
                {
                    totalPlunder *= 0.70;
                }
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {totalPlunder / expectedPlunder*100:f2}% of the plunder.");
            }
        }
    }
}
