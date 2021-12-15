using System;

namespace T06EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int clientsNumber = int.Parse(Console.ReadLine());

            double paidAmount = 0;
            int itemsCount = 0;
            double totalAmount = 0;

            for (int i = 1; i <= clientsNumber; i++)
            {
                string input = Console.ReadLine();

                while (input != "Finish")
                {
                    if (input == "basket")
                    {
                        itemsCount++;
                        paidAmount += 1.50;
                    }

                    else if (input == "wreath")
                    {
                        itemsCount++;
                        paidAmount += 3.80;
                    }
                    else if (input == "chocolate bunny")
                    {
                        itemsCount++;
                        paidAmount += 7.00;
                    }


                    input = Console.ReadLine();
                }
                if (itemsCount % 2 == 0)
                {
                    paidAmount *= 0.80;
                }

                Console.WriteLine($"You purchased {itemsCount} items for {paidAmount:f2} leva.");
                totalAmount += paidAmount;
                paidAmount = 0;
                itemsCount = 0;
            }

            Console.WriteLine($"Average bill per client is: {totalAmount / clientsNumber:f2} leva.");



        }
    }
}
