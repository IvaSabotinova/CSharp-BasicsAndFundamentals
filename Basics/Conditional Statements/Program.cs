using System;

namespace T9Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine(); // leap or normal
            int daysHolidays = int.Parse(Console.ReadLine());
            int weekendsInHomeTown = int.Parse(Console.ReadLine());

            const int yearlyWeekends = 48;
            int daysInSofia = yearlyWeekends - weekendsInHomeTown;
            double volleyballInSofia = (1.0 * daysInSofia * 3 / 4) + (1.0 * 2 / 3 * daysHolidays);
            double yearlyPlay = volleyballInSofia + weekendsInHomeTown;



            switch (yearType)
            {
                case "leap":
                    yearlyPlay = (volleyballInSofia + weekendsInHomeTown) * 1.15;
                    break;
                case "normal":
                    yearlyPlay = volleyballInSofia + weekendsInHomeTown;
                    break;

            }
            Console.WriteLine($"{Math.Floor(yearlyPlay)}");




        }
    }
}
