using System;
using System.Collections.Generic;
using System.Linq;



namespace T03HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neededHeartsInHouse = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();

            int cupidIndexPosition = 0;


            while (commands != "Love!")
            {
                string[] command = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int jump = int.Parse(command[1]);

                cupidIndexPosition += jump;


                if (cupidIndexPosition >= neededHeartsInHouse.Count)
                {
                    cupidIndexPosition = 0;
                }

                neededHeartsInHouse[cupidIndexPosition] -= 2;


                if (neededHeartsInHouse[cupidIndexPosition] == 0)
                {
                    Console.WriteLine($"Place {cupidIndexPosition} has Valentine's day.");

                }
                else if (neededHeartsInHouse[cupidIndexPosition] < 0)
                {
                    Console.WriteLine($"Place {cupidIndexPosition} already had Valentine's day.");

                }


                commands = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {cupidIndexPosition}.");
            int countOfSuccess = 0;
            for (int i = 0; i < neededHeartsInHouse.Count; i++)
            {
                if (neededHeartsInHouse[i] <= 0)
                {
                    countOfSuccess++;
                }
            }

            if (countOfSuccess == neededHeartsInHouse.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else if (countOfSuccess < neededHeartsInHouse.Count)
            {
                Console.WriteLine($"Cupid has failed {neededHeartsInHouse.Count - countOfSuccess} places.");
            }

            //    if (!neededHeartsInHouse.Any(el => el > 0))
            //{
            //    Console.WriteLine("Mission was successful.");
            //}
            //else
            //{
            //    Console.WriteLine($"Cupid has failed {neededHeartsInHouse.Count(el => el > 0)} places.");
            //}

        }
    }
}
