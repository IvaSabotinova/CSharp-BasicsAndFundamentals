using System;

namespace T03AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJoinery = int.Parse(Console.ReadLine());
            string typeJoinery = Console.ReadLine(); // "90X130" или "100X150" или "130X180" или "200X300";
            string withOrWithoutDelivery = Console.ReadLine();

            double priceOneJoinery = 0;
            double priceAllJoinery = 0;

            if (numberOfJoinery < 10)
            {
                Console.WriteLine("Invalid order");return;
            }

            else if (numberOfJoinery > 10)
            {
                switch (typeJoinery)
                {
                    case "90X130":
                        priceOneJoinery = 110;
                        if (numberOfJoinery > 30 && numberOfJoinery <= 60)
                        {
                            priceOneJoinery *= 0.95;
                        }
                        else if (numberOfJoinery > 60)
                        {
                            priceOneJoinery *= 0.92;
                        }
                        break;
                    case "100X150":
                        priceOneJoinery = 140;

                        if (numberOfJoinery > 40 && numberOfJoinery <= 80)
                        {
                            priceOneJoinery *= 0.94;
                        }
                        else if (numberOfJoinery > 80)
                        {
                            priceOneJoinery *= 0.90;
                        }
                        break;

                    case "130X180":
                        priceOneJoinery = 190;
                        if (numberOfJoinery > 20 && numberOfJoinery <= 50)
                        {
                            priceOneJoinery *= 0.93;
                        }
                        else if (numberOfJoinery > 50)
                        {
                            priceOneJoinery *= 0.88;
                        }
                        break;

                    case "200X300":
                        priceOneJoinery = 250;
                        if (numberOfJoinery > 25 && numberOfJoinery <= 50)
                        {
                            priceOneJoinery *= 0.91;
                        }
                        else if (numberOfJoinery > 50)
                        {
                            priceOneJoinery *= 0.86;
                        }
                        break;


                }

                priceAllJoinery = priceOneJoinery * numberOfJoinery;
            }

            if (withOrWithoutDelivery == "With delivery")
            {
                priceAllJoinery += 60;
                if (numberOfJoinery > 99)
                {
                    priceAllJoinery *= 0.96;
                }
                else
                {
                    priceAllJoinery += 0;
                }
            }
            else if (withOrWithoutDelivery == "Without delivery")
            {
                if (numberOfJoinery > 99)
                {
                    priceAllJoinery *= 0.96;
                }
                else
                {
                    priceAllJoinery += 0;
                }

            }
            Console.WriteLine($"{priceAllJoinery:f2} BGN");


        }
    }
}
