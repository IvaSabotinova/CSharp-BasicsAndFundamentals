using System;
using System.Collections.Generic;
using System.Linq;

namespace T03WildZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string command = String.Empty;

            Dictionary<string, int> allAnimals_FoodQuantity = new Dictionary<string, int>();
            Dictionary<string, List<string>> allAreas_Animals = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "EndDay")
            {
                string[] subcommands = command.Split(new char[] {' ', '-'});

                string currentAnimalName = subcommands[1];
                int currentFoodQuantity = int.Parse(subcommands[2]);
                if (subcommands[0] == "Add:")
                {

                    string currentArea = subcommands[3];
                    if (!allAnimals_FoodQuantity.ContainsKey(currentAnimalName))
                    {
                        allAnimals_FoodQuantity.Add(currentAnimalName, 0);
                    }
                    allAnimals_FoodQuantity[currentAnimalName] += currentFoodQuantity;

                    if (!allAreas_Animals.ContainsKey(currentArea))
                    {
                        allAreas_Animals.Add(currentArea, new List<string>());
                    }

                    if (!allAreas_Animals.Values.Any(x => x.Contains(currentAnimalName)))
                    {
                        allAreas_Animals[currentArea].Add(currentAnimalName);
                    }

                }
                else if (subcommands[0] == "Feed:")
                {
                    if (allAnimals_FoodQuantity.ContainsKey(currentAnimalName))
                    {
                        allAnimals_FoodQuantity[currentAnimalName] -= currentFoodQuantity;
                        if (allAnimals_FoodQuantity[currentAnimalName] <= 0)
                        {
                            allAnimals_FoodQuantity.Remove(currentAnimalName);
                            allAreas_Animals.Values.Any(x => x.Remove(currentAnimalName));
                            Console.WriteLine($"{currentAnimalName} was successfully fed");
                            
                        }
                    }

                }

            }

            Console.WriteLine("Animals:");
            foreach (KeyValuePair<string, int> animal in allAnimals_FoodQuantity.OrderByDescending(x=>x.Value).ThenBy(k=>k.Key))
            {
                Console.WriteLine($" {animal.Key} -> {animal.Value}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (KeyValuePair<string, List<string>> area in allAreas_Animals.Where(x=>x.Value.Count > 0).OrderByDescending(v=>v.Value.Count).ThenBy(k=>k.Key))
            {
                Console.WriteLine($" {area.Key}: {area.Value.Count}");
            }
        }
    }
}
