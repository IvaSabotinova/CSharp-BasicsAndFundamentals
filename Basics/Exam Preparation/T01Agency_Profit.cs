using System;

namespace T01Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string airLine = Console.ReadLine();
            int ticketNumberAdults = int.Parse(Console.ReadLine());
            int ticketNumberKids = int.Parse(Console.ReadLine());
            double netTicketPricePerAdult = double.Parse(Console.ReadLine());
            double serviceTax = double.Parse(Console.ReadLine());

            double ticketPricePerAdult = netTicketPricePerAdult + serviceTax;
            double ticketPricePerKid = (netTicketPricePerAdult * 0.30) + serviceTax;

            double airLineNetProfit = ((ticketNumberAdults * ticketPricePerAdult) + (ticketNumberKids * ticketPricePerKid)) * 0.20;
            
            Console.WriteLine($"The profit of your agency from {airLine} tickets is {airLineNetProfit:f2} lv.");

        }
    }
}
