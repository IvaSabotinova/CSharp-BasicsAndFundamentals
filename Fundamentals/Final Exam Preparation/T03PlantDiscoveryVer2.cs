using System;
using System.Collections.Generic;
using System.Linq;


namespace T03PlantDiscoveryVer2
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            List<Plant> allPlants = new List<Plant>();


            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string currentPlantName = input[0];
                int currentPlantRarity = int.Parse(input[1]);

                if (!allPlants.Any(el => el.Name == currentPlantName))
                {
                    Plant newPlant = new Plant();
                    {
                        newPlant.Name = currentPlantName;
                        newPlant.Rarity = currentPlantRarity;
                        newPlant.Ratings = new List<double>();
                    }
                    allPlants.Add(newPlant);

                }
                else if (allPlants.Any(el => el.Name == currentPlantName))

                {
                    int previousRarity = allPlants.First(el => el.Name == currentPlantName).Rarity;
                    previousRarity = currentPlantRarity;
                }

            }

            string commands = String.Empty;

            while ((commands = Console.ReadLine()) != "Exhibition")
            {
                string[] subcommands = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currPlantName = subcommands[1];

                if (!allPlants.Any(item => item.Name == currPlantName))
                {
                    Console.WriteLine("error");
                }
                else
                {
                    Plant currentPlant = allPlants.First(item => item.Name == currPlantName);
                    if (subcommands[0] == "Rate:")
                    {
                        double currRate = double.Parse(subcommands[3]);
                        currentPlant.Ratings.Add(currRate);
                    }
                    else if (subcommands[0] == "Update:")
                    {
                        int currRarity = int.Parse(subcommands[3]);
                        currentPlant.Rarity = currRarity;

                    }
                    else if (subcommands[0] == "Reset:")
                    {
                        currentPlant.Ratings.Clear();

                    }

                }

            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant item in allPlants.OrderByDescending(x => x.Rarity).ThenByDescending(x => x.Ratings.Count > 0 ? x.Ratings.Average() : 0.00))
            {
                if (item.Ratings.Count > 0)
                {
                    Console.WriteLine($"- {item.Name}; Rarity: {item.Rarity}; Rating: {item.Ratings.Average():f2}");
                }
                else if (item.Ratings.Count == 0)
                {
                    Console.WriteLine($"- {item.Name}; Rarity: {item.Rarity}; Rating: 0.00");
                }
            }
        }
        class Plant
        {
            public string Name { get; set; }
            public int Rarity { get; set; }
            public List<double> Ratings { get; set; }

        }
    }
}
