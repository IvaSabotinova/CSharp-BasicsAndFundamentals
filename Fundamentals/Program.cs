using System;
using System.Collections.Generic;
using System.Linq;


namespace T02MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int bitcoins = 0;
            List<string> rooms = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();



            for (int i = 0; i < rooms.Count; i++)
            {
                string[] currRoom = rooms[i].Split(" ");

                if (currRoom[0] == "potion")
                {
                    int hp = initialHealth;
                    initialHealth += int.Parse(currRoom[1]);
                    if (initialHealth > 100)
                    {
                        initialHealth = 100;

                    }

                    Console.WriteLine($"You healed for {initialHealth - hp} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");


                }

                else if (currRoom[0] == "chest")
                {
                    int foundBitcoins = int.Parse(currRoom[1]);
                    bitcoins += foundBitcoins;
                    Console.WriteLine($"You found {foundBitcoins} bitcoins.");
                }
                else
                {
                    string montster = currRoom[0];
                    int monsterAttack = int.Parse(currRoom[1]);
                    initialHealth -= monsterAttack;
                    if (initialHealth > 0)
                    {
                        Console.WriteLine($"You slayed {montster}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {montster}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }

                }

            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {initialHealth}");

        }
    }
}
