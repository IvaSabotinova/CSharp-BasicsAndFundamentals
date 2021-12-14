using System;

namespace T01BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            int age = 17;

            for (int i = 1800; i <= yearToLive; i++)
            {

                if (i % 2 == 0)
                {

                    age++;
                    inheritedMoney -= 12000;

                }
                else
                {
                    age++;
                    inheritedMoney -= (12000 + 50 * age);

                }
            }

            if (inheritedMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }

        }
    }
}
