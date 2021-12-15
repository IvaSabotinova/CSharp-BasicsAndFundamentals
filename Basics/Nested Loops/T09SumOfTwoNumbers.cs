using System;

namespace T09SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int countCombinations = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {

                    countCombinations++;

                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{countCombinations} ({i} + {j} = {magicNumber})"); return;
                    }
                }
                
            }
            Console.WriteLine($"{countCombinations} combinations - neither equals {magicNumber}");



        }
    }
}
