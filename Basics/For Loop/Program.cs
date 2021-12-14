using System;

namespace T05DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberp1 = 0;
            int numberp2 = 0;
            int numberp3 = 0;


            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    numberp1++;
                }
                if (number % 3 == 0)
                {
                    numberp2++;
                }
                if (number % 4 == 0)
                {
                    numberp3++;
                }
            }
            double p1 = 1.0 * numberp1 / n * 100;
            double p2 = (double)numberp2 / n * 100;
            double p3 = (double)numberp3 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}
