using System;

namespace T05GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGoes = int.Parse(Console.ReadLine());
            double scores1 = 0;
            double scores2 = 0;
            double scores3 = 0;
            double scores4 = 0;
            double scores5 = 0;
            double gameResult = 0;
            for (int i = 0; i <= numberOfGoes; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0 && number > 50);
                {
                    gameResult /= 2;
                }

                if (number >= 0 && number <= 9)
                {
                    scores1 += 0.20 * number;
                }
                else if (number <= 19)
                {
                    scores2 += 0.30 * number;
                }
                else if (number <= 29)
                {
                    scores3 += 0.40 * number;
                }
                else if (number <= 39)
                {
                    scores4 += 50;
                }
                else if (number <= 50)
                {
                    scores5 += 100;
                }
               
            }
            
        }
    }
}
