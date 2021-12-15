using System;

namespace T07SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswordsNumber = int.Parse(Console.ReadLine());

            int countCombinations = 0;

            for (int A = 35; A <= 55; A++)
            {
                for (int B = 64; B <= 96; B++)
                {
                    for (int x = 1; x <= a; x++)
                    {
                        for (int y = 1; y <= b; y++)
                        {

                            countCombinations++;
                            Console.Write($"{(char)A}{(char)B}{x}{y}{(char)B}{(char)A}|");
                            
                            A++;
                            B++;

                            if (countCombinations >= maxPasswordsNumber)
                            {
                                return;
                            }
                            if (A > 55)
                            {
                                A = 35;
                            }
                            if (B > 96)
                            {
                                B = 64;
                            }
                            if (x == a && y == b)
                            {
                                return;
                            }
                            
                        }
                    }
                }
            }
        }
    }
}
