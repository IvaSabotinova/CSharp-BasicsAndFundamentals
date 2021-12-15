using System;
using System.Collections.Generic;
using System.Linq;

namespace T03P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> allTowns_Population = new Dictionary<string, int>();
            Dictionary<string, int> allTowns_Gold = new Dictionary<string, int>();

            string command1 = string.Empty;

            while ((command1 = Console.ReadLine()) != "Sail")
            {
                string[] subcommands = command1.Split("||");
                string currentTown = subcommands[0];
                int currentPopulation = int.Parse(subcommands[1]);
                int currentGold = int.Parse(subcommands[2]);

                if (!allTowns_Population.ContainsKey(currentTown))
                {
                    allTowns_Population.Add(currentTown, 0);

                }

                if (!allTowns_Gold.ContainsKey(currentTown))
                {
                    allTowns_Gold.Add(currentTown, 0);
                }

                allTowns_Population[currentTown] += currentPopulation;
                allTowns_Gold[currentTown] += currentGold;
            }

            string eventsCommands = string.Empty;
            while ((eventsCommands = Console.ReadLine()) != "End")
            {
                string[] subEventsCommands = eventsCommands.Split("=>");
                string currTown = subEventsCommands[1];

                if (subEventsCommands[0] == "Plunder")
                {
                    int people = int.Parse(subEventsCommands[2]);
                    int gold = int.Parse(subEventsCommands[3]);
                    Console.WriteLine($"{currTown} plundered! {gold} gold stolen, {people} citizens killed.");
                    allTowns_Population[currTown] -= people;
                    allTowns_Gold[currTown] -= gold;
                    if (allTowns_Population[currTown] == 0 || allTowns_Gold[currTown] == 0)
                    {
                        Console.WriteLine($"{currTown} has been wiped off the map!");
                        allTowns_Population.Remove(currTown);
                        allTowns_Gold.Remove(currTown);

                    }
                }
                else if (subEventsCommands[0] == "Prosper")
                {
                    int curGold = int.Parse(subEventsCommands[2]);
                    if (curGold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        allTowns_Gold[currTown] += curGold;
                        Console.WriteLine($"{curGold} gold added to the city treasury. {currTown} now has {allTowns_Gold[currTown]} gold.");
                    }
                }

            }

            if (allTowns_Gold.Count != 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {allTowns_Gold.Count} wealthy settlements to go to:");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }

            foreach (KeyValuePair<string, int> item in allTowns_Gold.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {

                foreach (KeyValuePair<string, int> town in allTowns_Population)
                {
                    if (item.Key == town.Key)
                    {
                        Console.WriteLine($"{item.Key} -> Population: {town.Value} citizens, Gold: {item.Value} kg");
                    }
                }
            }
        }
    }
}
