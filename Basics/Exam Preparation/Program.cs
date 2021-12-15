using System;

namespace T04Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallHeight = int.Parse(Console.ReadLine());
            int wallWidth = int.Parse(Console.ReadLine());
            int percentOfAllAreaNotToBePainted = int.Parse(Console.ReadLine());

            double totalAreaForPainting = Math.Ceiling((1.0 * wallHeight * wallWidth * 4) * (1.0 * (100 - percentOfAllAreaNotToBePainted) / 100));

            string command = Console.ReadLine();

            while (command != "Tired!")
            {
                int paintLitres = int.Parse(command);               
                totalAreaForPainting -= paintLitres;
                if (totalAreaForPainting < 0)
                {

                    Console.WriteLine($"All walls are painted and you have {Math.Abs(totalAreaForPainting)} l paint left!"); break;

                }
                else if (totalAreaForPainting == 0)
                {

                    Console.WriteLine("All walls are painted! Great job, Pesho!"); break;
                }


                command = Console.ReadLine();
            }

            if (totalAreaForPainting > 0)
            {
                Console.WriteLine($"{totalAreaForPainting} quadratic m left.");
            }
        }
    }
}
