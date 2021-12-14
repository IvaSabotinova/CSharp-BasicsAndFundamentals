using System;

namespace T03Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            double oddSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenSum = 0;

            for (int i = 1; i <= n; i++)
            {
                double figure = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += figure;
                    if (figure > oddMax)
                    {
                        oddMax = figure;

                    }

                    if (figure < oddMin)
                    {
                        oddMin = figure;
                    }

                }

                else
                {
                    evenSum += figure;
                    if (figure > evenMax)
                    {
                        evenMax = figure;
                    }
                    if (figure < evenMin)
                    {
                        evenMin = figure;
                    }


                }
            }

            if (n == 0)
            {

                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");

            }
            else if (n == 1)
            {

                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");

            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }


        }
    }
}
