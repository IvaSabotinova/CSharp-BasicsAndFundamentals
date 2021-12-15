using System;

namespace T03World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stageOfChampionship = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketNumber = int.Parse(Console.ReadLine());
            string tropheyPhoto = Console.ReadLine();

            double priceStandardTicket = 0;
            double pricePremiumTicket = 0;
            double priceVIPTicket = 0;
            double totalPriceAllTickets = 0;

            switch (stageOfChampionship)
            {
                case "Quarter final":
                    priceStandardTicket = 55.50;
                    pricePremiumTicket = 105.20;
                    priceVIPTicket = 118.90; break;

                case "Semi final":
                    priceStandardTicket = 75.88;
                    pricePremiumTicket = 125.22;
                    priceVIPTicket = 300.40; break;

                case "Final":
                    priceStandardTicket = 110.10;
                    pricePremiumTicket = 160.66;
                    priceVIPTicket = 400; break;


                default:
                    break;
            }


            if (ticketType == "Standard")
            {
                totalPriceAllTickets = priceStandardTicket * ticketNumber;
            }
            else if (ticketType == "Premium")
            {
                totalPriceAllTickets = pricePremiumTicket * ticketNumber;
            }
            else if (ticketType == "VIP")
            {
                totalPriceAllTickets = priceVIPTicket * ticketNumber;
            }

              
                        
            if (totalPriceAllTickets > 4000)
            {
                totalPriceAllTickets *= 0.75;

            }
            else if (totalPriceAllTickets <= 4000 & totalPriceAllTickets > 2500)
            {
                if (tropheyPhoto == "Y")
                {
                    totalPriceAllTickets = (totalPriceAllTickets * 0.90) + (ticketNumber * 40);
                }
                else if (tropheyPhoto == "N")
                {
                    totalPriceAllTickets *= 0.90;
                }
            }
            else
            {
                if (tropheyPhoto == "Y")
                {
                    totalPriceAllTickets += (ticketNumber * 40);
                }
                else if (tropheyPhoto == "N")
                {
                    totalPriceAllTickets += 0;
                }
            }


                Console.WriteLine($"{totalPriceAllTickets:f2}");

            }
        }
    }
