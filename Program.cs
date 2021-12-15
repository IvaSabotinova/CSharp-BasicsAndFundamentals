using System;

namespace T07VendingMachineVer2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Your vending machine only works with 0.1, 0.2, 0.5, 1, and 2 coins. 
            // Nuts", "Water", "Crisps", "Soda", "Coke". The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively.

            double productPrice = 0;
            double totalInsertedMoney = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Start")
                {
                    break;
                }

                double insertedCoins = double.Parse(input);

                if (insertedCoins == 0.1 || insertedCoins == 0.2 || insertedCoins == 0.5 ||
                    insertedCoins == 1 || insertedCoins == 2)
                {
                    totalInsertedMoney += insertedCoins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertedCoins}"); 
                }

            }



            while (true)
            {
                string product = Console.ReadLine();

                if (product == "End")
                {
                    break;
                }

                switch (product)
                {
                    // Nuts", "Water", "Crisps", "Soda", "Coke". The prices are: 2.0, 0.7, 1.5, 0.8, 1.0 respectively.
                    case "Nuts": productPrice = 2.0; break;
                    case "Water": productPrice = 0.7; break;
                    case "Crisps": productPrice = 1.5; break;
                    case "Soda": productPrice = 0.8; break;
                    case "Coke": productPrice = 1.0; break;
                    default: Console.WriteLine("Invalid product"); continue;
                }

                totalInsertedMoney -= productPrice;

                if (totalInsertedMoney >= 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    totalInsertedMoney += productPrice;
                    Console.WriteLine($"Sorry, not enough money");
                }


            }


            Console.WriteLine($"Change: {totalInsertedMoney:f2}");

        }

    }
}
