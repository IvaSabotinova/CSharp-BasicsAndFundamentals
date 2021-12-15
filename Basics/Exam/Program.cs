using System;

namespace _06._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int figure1Ceiling = int.Parse(Console.ReadLine());
            int figure2Ceiling = int.Parse(Console.ReadLine());
            int figure3Ceiling = int.Parse(Console.ReadLine());

            

            for (int f1 = 2; f1 <= figure1Ceiling; f1 += 2)
            {
                for (int f2 = 2; f2 <= figure2Ceiling; f2++)
                {
                    for (int f3 = 2; f3 <= figure3Ceiling; f3 += 2)
                    {
                        if (f2 != 4 && f2 != 6 && f2 != 8 && f2 !=9)
                        {
                            Console.WriteLine($"{f1} {f2} {f3}");
                        }
                    }
                }
            }
        }
    }
}
