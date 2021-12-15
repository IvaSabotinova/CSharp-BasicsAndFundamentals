using System;

namespace T02AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggageTaxOver20kg = double.Parse(Console.ReadLine());
            double luggageWeight = double.Parse(Console.ReadLine());
            int daysTillFlight = int.Parse(Console.ReadLine());
            int luggageNumber = int.Parse(Console.ReadLine());

            double luggageTaxBelow10kg = luggageTaxOver20kg * 0.20;
            double luggageTaxBetween10And20kg = luggageTaxOver20kg * 0.50;

            if (daysTillFlight > 30)
            {
                if (luggageWeight < 10)
                {
                    Console.WriteLine($"The total price of bags is: {((luggageTaxBelow10kg * luggageNumber) * 1.10):f2} lv.");
                }
                else if (luggageWeight >= 10 && luggageWeight <= 20)
                {
                    Console.WriteLine($"The total price of bags is: {((luggageTaxBetween10And20kg * luggageNumber) * 1.10):f2} lv.");
                }
                else
                {
                    Console.WriteLine($"The total price of bags is: {((luggageTaxOver20kg * luggageNumber) * 1.10):f2} lv.");
                }
            }
            if (daysTillFlight <= 30 && daysTillFlight >=7)
            {
                if (luggageWeight < 10)
                {
                    Console.WriteLine($"The total price of bags is: {((luggageTaxBelow10kg * luggageNumber) * 1.15):f2} lv.");
                }
                else if (luggageWeight >= 10 && luggageWeight <= 20)
                {
                    Console.WriteLine($"The total price of bags is: {((luggageTaxBetween10And20kg * luggageNumber) * 1.15):f2} lv.");
                }
                else
                {
                    Console.WriteLine($"The total price of bags is: {((luggageTaxOver20kg * luggageNumber) * 1.15):f2} lv.");
                }
            }
            if (daysTillFlight <7)
            {
                if (luggageWeight < 10)
                {
                    Console.WriteLine($"The total price of bags is: {((luggageTaxBelow10kg * luggageNumber) * 1.40):f2} lv.");
                }
                else if (luggageWeight >= 10 && luggageWeight <= 20)
                {
                    Console.WriteLine($"The total price of bags is: {((luggageTaxBetween10And20kg * luggageNumber) * 1.40):f2} lv.");
                }
                else
                {
                    Console.WriteLine($"The total price of bags is: {((luggageTaxOver20kg * luggageNumber) * 1.40):f2} lv.");
                }
            }


        }
    }
}
