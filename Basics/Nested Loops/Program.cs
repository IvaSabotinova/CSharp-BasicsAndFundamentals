using System;

namespace T13PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startFirst2Numbers = int.Parse(Console.ReadLine());
            int startSecond2Numbers = int.Parse(Console.ReadLine());
            int difference1Max = int.Parse(Console.ReadLine());
            int difference2Max = int.Parse(Console.ReadLine());


            for (int i = startFirst2Numbers; i <= startFirst2Numbers + difference1Max; i++)
            {
                
                for (int j = startSecond2Numbers; j <= startSecond2Numbers + difference2Max; j++)
                {
                    int count = 0;
                    bool isPrime = false;

                    int count1 = 0;
                    bool isPrime1 = false;

                    for (int k = 1; k <= i; k++)
                    {
                        if (i % k == 0)
                        {
                            count++;

                        }
                    }
                    if (count == 2)
                    {
                        isPrime = true;
                        
                    }

                    
                    for (int l = 1; l <= j; l++)
                    {
                        if (j % l == 0)
                        {
                            count1++;
                        }

                    }
                    if (count1 == 2)

                    {

                        isPrime1 = true;
                        
                    }


                    if (isPrime && isPrime1)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                    


                }
                
            }

            
        }
    }
}
