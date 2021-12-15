using System;

namespace _03._Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfParticipants = int.Parse(Console.ReadLine());
            double scores = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); // "summer" или "winter"
            string BGOrAbroad = Console.ReadLine();
            double moneyPrize = 0;

            switch (BGOrAbroad)
            {
                case "Bulgaria": moneyPrize = numberOfParticipants * scores;
                    if (season == "summer")
                    {
                        moneyPrize *= 0.95;
                    }
                    else if (season == "winter")
                    {
                        moneyPrize *= 0.92;
                    }                    
                    
                    break;

                case "Abroad": moneyPrize = numberOfParticipants * scores * 1.50;
                    if (season == "summer")
                    {
                        moneyPrize *= 0.90;
                    }
                    else if (season == "winter")
                    {
                        moneyPrize *= 0.85;
                    }

                    break;

                default:
                    break;
            }
            double charity = moneyPrize * 0.75;
            double leftPrize = moneyPrize - charity;
            double moneyPerParticipant = leftPrize / numberOfParticipants;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerParticipant:f2}");

        }
    }
}
