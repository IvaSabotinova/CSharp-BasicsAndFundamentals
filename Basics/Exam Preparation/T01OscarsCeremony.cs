using System;

namespace T01OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statuettes = 1.0 * rent * 0.70;
            double catering = statuettes * 0.85;
            double sound = catering * 1 / 2;

            double totalExpenses = rent + statuettes + catering + sound;
            Console.WriteLine($"{totalExpenses:f2}");
        }
    }
}
