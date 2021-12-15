using System;

namespace T05AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                int figure = int.Parse(Console.ReadLine());

                sum += figure;
               

            }
            Console.WriteLine($"{1.0 * sum / number:f2}");
        }
    }
}
