using System;

namespace T02ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double charitySum = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int count = 0;
            
            double totalAmount = 0;
            double amountCash = 0;
            double amountCard = 0;
            int countCash = 0;
            int countCard = 0;

            while (input != "End")
            {
                double amount = double.Parse(input);
                bool isCash = false;
                bool isCard = false;
                count++;
                if (count % 2 != 0)
                {
                    isCash = true;
                }
                else if (count % 2 == 0)
                {
                    isCard = true;
                }
                if (amount < 10 && isCash)
                {
                    totalAmount += amount;
                    countCash++;
                    amountCash += amount;
                                    Console.WriteLine("Product sold!");
                }
                else if (amount < 10 && isCard)
                {
                    Console.WriteLine("Error in transaction!");
                }
                else if (amount >= 10 && amount <= 100 && isCash)
                {
                    totalAmount += amount;
                    amountCash += amount;
                    countCash++;
                    Console.WriteLine("Product sold!");

                }

                else if (amount >= 10 && amount <= 100 && isCard)
                {
                    totalAmount += amount;
                    countCard++;
                    amountCard += amount;
                    Console.WriteLine("Product sold!");
                }
                else if (amount > 100 && isCash)
                {
                    Console.WriteLine("Error in transaction!");

                }
                else if (amount > 100 && isCard)
                {
                    totalAmount += amount;
                    countCard++;
                    amountCard += amount;
                    Console.WriteLine("Product sold!");

                }
                if (totalAmount >= charitySum)
                {
                   
                    Console.WriteLine($"Average CS: {amountCash / countCash:f2}");
                    Console.WriteLine($"Average CC: {amountCard / countCard:f2}");return;
                }


                input = Console.ReadLine();
            }



            if (totalAmount < charitySum)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
