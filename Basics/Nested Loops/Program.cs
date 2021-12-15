using System;

namespace T05SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkCapacity = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int suitcaseCount = 0;
           

            while (input != "End")
            {
                double suitcaseVolume = double.Parse(input);
                suitcaseCount++;

                if (suitcaseCount % 3 == 0)
                {
                    trunkCapacity -= (suitcaseVolume * 1.10);
                }
                else
                {
                    trunkCapacity -= suitcaseVolume;
                }

                if (trunkCapacity < 0)
                {
                    Console.WriteLine("No more space!");
                    Console.WriteLine($"Statistic: {suitcaseCount - 1} suitcases loaded."); return;
                }
                

                input = Console.ReadLine();
            }

            Console.WriteLine("Congratulations! All suitcases are loaded!");
            Console.WriteLine($"Statistic: {suitcaseCount} suitcases loaded.");
        }
    }
}
