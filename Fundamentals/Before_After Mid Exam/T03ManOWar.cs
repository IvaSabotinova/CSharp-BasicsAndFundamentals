using System;
using System.Collections.Generic;
using System.Linq;


namespace T03ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShipStatus = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> WarShipStatus = Console.ReadLine().Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sectionMaxHealthCapacity = int.Parse(Console.ReadLine());

            string commands = Console.ReadLine();
            while (commands != "Retire")
            {
                string[] command = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);


                if (command[0] == "Fire")
                {
                    int indexToDamage = int.Parse(command[1]);
                    int damageValue = int.Parse(command[2]);

                    if (indexToDamage >= 0 && indexToDamage < WarShipStatus.Count)
                    {
                        WarShipStatus[indexToDamage] -= damageValue;
                        if (WarShipStatus[indexToDamage] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (command[0] == "Defend")
                {
                    int startIndexDmg = int.Parse(command[1]);
                    int endIndexDmg = int.Parse(command[2]);
                    int damageValueToPirateShip = int.Parse(command[3]);

                    if (startIndexDmg >= 0 && startIndexDmg < pirateShipStatus.Count
                        && endIndexDmg >= 0 && endIndexDmg < pirateShipStatus.Count)
                    {
                        
                        for (int i = startIndexDmg; i <= endIndexDmg; i++)
                        {
                            pirateShipStatus[i] -= damageValueToPirateShip;
                            if (pirateShipStatus[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken."); return;

                            }
                        }

                    }
                }
                else if (command[0] == "Repair")
                {
                    int indexToRepair = int.Parse(command[1]);
                    int repairValue = int.Parse(command[2]);
                    if (indexToRepair >= 0 && indexToRepair < pirateShipStatus.Count)
                    {
                        pirateShipStatus[indexToRepair] += repairValue;

                        if (pirateShipStatus[indexToRepair] > sectionMaxHealthCapacity)
                        {
                            pirateShipStatus[indexToRepair] = sectionMaxHealthCapacity;
                        }
                    }
                }
                else if (command[0] == "Status")
                {
                    //int countSectionsForRepair = pirateShipStatus.Count(el => el < 0.20 * sectionMaxHealthCapacity);

                    int countSectionsForRepair = 0;
                    for (int i = 0; i < pirateShipStatus.Count; i++)
                    {
                        if (pirateShipStatus[i] < 0.20 * sectionMaxHealthCapacity)
                        {
                            countSectionsForRepair++;
                        }

                    }
                    Console.WriteLine($"{countSectionsForRepair} sections need repair.");

                }
                commands = Console.ReadLine();
            }

            Console.WriteLine($"Pirate ship status: {pirateShipStatus.Sum()}");
            Console.WriteLine($"Warship status: {WarShipStatus.Sum()}");
        }
    }
}
