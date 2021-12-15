using System;

namespace T06Barcode_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int s1 = start / 1000;
            int s2 = start / 100 % 10;
            int s3 = start / 10 % 10;
            int s4 = start % 10;
            
            int e1 = end / 1000;
            int e2 = end / 100 % 10;
            int e3 = end / 10 % 10;
            int e4 = end % 10;



            


                for (int currF1 = s1; currF1 <= e1; currF1++)
                {
                    for (int currF2 = s2; currF2 <= e2; currF2++)
                    {
                        for (int currF3 = s3; currF3 <= e3; currF3++)
                        {
                            for (int currF4 = s4; currF4 <= e4; currF4++)
                            {
                                if (currF1 % 2 != 0 && currF2 % 2 != 0 && currF3 % 2 != 0 && currF4 % 2 != 0)
                                {
                                    Console.Write($"{currF1}{currF2}{currF3}{currF4} ");
                                }
                            }
                        }
                    }
                }

            
        }


    }
}

