using System;

namespace T12TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int contolValueM = int.Parse(Console.ReadLine());

            int count = 0;

            int aa = 0;
            int bb = 0;
            int cc = 0;
            int dd = 0;
            bool flag = false;


            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a * b + c * d == contolValueM && a < b && c > d)
                            {

                                count++;

                                Console.Write($"{a}{b}{c}{d} ");
                                if (count == 4)
                                {
                                    
                                    aa = a;
                                    bb = b;
                                    cc = c;
                                    dd = d;
                                    flag = true;

                                }

                            }
                            
                        }
                    }
                }
                
                
            }
            if (flag)
            {
                Console.WriteLine();
                Console.WriteLine($"Password: {aa}{bb}{cc}{dd}");
            }
            if (count == 0)
            {
                Console.WriteLine("No!");
            }
            else if (count < 4 && count >=0)
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }




        }
    }
}
