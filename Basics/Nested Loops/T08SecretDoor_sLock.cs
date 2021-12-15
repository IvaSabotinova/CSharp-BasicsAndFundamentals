using System;

namespace T08SecretDoor_sLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int F1Ceiling = int.Parse(Console.ReadLine());
            int F2Ceiling = int.Parse(Console.ReadLine());
            int F3Ceiling = int.Parse(Console.ReadLine());

            

            for (int i = 1; i <= F1Ceiling; i++)
            {
                for (int j = 2; j <= F2Ceiling; j++)
                {
                    for (int k = 1; k <= F3Ceiling; k++)
                    {
                        if (i % 2 == 0 && k % 2 == 0 && j != 4 && j != 6 && j != 8 && j != 9)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        
                        }

                    }
                }
            }
        }
    }
}
