using System;

namespace T04Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int kmTotal = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double priceTaxiDay = 0.70 + 0.79 * kmTotal;
            double priceTaxiNight = 0.70 + 0.90 * kmTotal;


            if (kmTotal < 20 && dayOrNight == "day")
            {
                Console.WriteLine($"{priceTaxiDay:f2}");
            }
            else if (kmTotal < 20 && dayOrNight == "night")
            {
                Console.WriteLine($"{priceTaxiNight:f2}");
            }
            else if (kmTotal >= 20 && kmTotal < 100 && dayOrNight == "day")
            {

                double priceBusDayNight = 0.09 * kmTotal;
                Console.WriteLine($"{priceBusDayNight:f2}");
            }
            else if (kmTotal >= 20 && kmTotal < 100 && dayOrNight == "night")
            {

                double priceBusDayNight = 0.09 * kmTotal;
                Console.WriteLine($"{priceBusDayNight:f2}");
            }
            else
            {
                double priceTrainDayNight = 0.06 * kmTotal;
                Console.WriteLine($"{priceTrainDayNight:f2}");
            }

        }
    }
}
