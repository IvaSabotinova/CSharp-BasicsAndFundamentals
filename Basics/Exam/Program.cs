using System;

namespace _04._Grandpa_Stavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double totalLitresRakia = 0;
            double totalDegreesRakia = 0;

            for (int i = 1; i <= days; i++)
            {
                double rakiaLitresPerDay = double.Parse(Console.ReadLine());
                double rakiaDegrees = double.Parse(Console.ReadLine());

                double allRakiaDegreesPerDay = rakiaLitresPerDay * rakiaDegrees;

                totalLitresRakia += rakiaLitresPerDay;
                totalDegreesRakia += allRakiaDegreesPerDay;


            }
            double averageRakiaDegrees = totalDegreesRakia / totalLitresRakia;

            Console.WriteLine($"Liter: {totalLitresRakia:f2}");
            
            Console.WriteLine($"Degrees: {averageRakiaDegrees:f2}");

            if (averageRakiaDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");

            }
            else if (averageRakiaDegrees >= 38 && averageRakiaDegrees <= 42)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Dilution with distilled water!");
            }


        }
    }
}
