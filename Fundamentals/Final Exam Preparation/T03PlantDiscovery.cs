using System;
using System.Collections.Generic;
using System.Linq;


namespace T03PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, int> allPlantsAndRarity = new Dictionary<string, int>();

            for (int i = 0; i < number; i++)
            {
                string[] commands = Console.ReadLine().Split("<->");
                string currentPlant = commands[0];
                int currentRarity = int.Parse(commands[1]);
                if (!allPlantsAndRarity.ContainsKey(currentPlant))
                {
                    allPlantsAndRarity.Add(currentPlant, currentRarity);
                }
                else
                {
                    allPlantsAndRarity[currentPlant] = currentRarity;
                }

            }

            string input = String.Empty;
            Dictionary<string, List<double>> allPlants_Ratings = new Dictionary<string, List<double>>();

            foreach (KeyValuePair<string, int> item in allPlantsAndRarity)
            {
                allPlants_Ratings.Add(item.Key, new List<double>());

            }


            while ((input = Console.ReadLine()) != "Exhibition")
            {
                string[] subcommands = input.Split(" ");
                string currentPlant = subcommands[1];

                if (!allPlantsAndRarity.ContainsKey(currentPlant))

                {
                    Console.WriteLine("error");
                }
                else
                {

                    if (subcommands[0] == "Rate:")
                    {
                        double currentRating = double.Parse(subcommands[3]);
                        allPlants_Ratings[currentPlant].Add(currentRating);

                    }

                    else if (subcommands[0] == "Update:")
                    {
                        int currentRarity = int.Parse(subcommands[3]);
                        allPlantsAndRarity[currentPlant] = currentRarity;
                    }

                    else if (subcommands[0] == "Reset:")
                    {
                        allPlants_Ratings[currentPlant].Clear();

                    }
                }
            }


            Dictionary<string, List<double>> final = new Dictionary<string, List<double>>();


            foreach (KeyValuePair<string, int> item in allPlantsAndRarity.OrderByDescending(x => x.Value))
            {
                foreach (KeyValuePair<string, List<double>> plant in allPlants_Ratings.OrderByDescending(x => x.Value.Count > 0 ? x.Value.Average() : 0.00))
                {
                    if (item.Key == plant.Key)
                    {
                        final.Add(item.Key, new List<double>());
                        final[item.Key].Add(item.Value);
                        final[item.Key].Add(plant.Value.Count > 0 ? plant.Value.Average() : 0.00);

                    }
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (KeyValuePair<string, List<double>> item in final.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {

                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
            }


        }
    }
}


