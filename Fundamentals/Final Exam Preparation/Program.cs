using System;
using System.Collections.Generic;

using System.Linq;

namespace T04Santa_sNewList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> allChildren_NumberOfToys = new Dictionary<string, int>();
            Dictionary<string, int> allPresents_Quantity = new Dictionary<string, int>();

            
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split("->");
                if (command[0] != "Remove")
                {
                    string currentChildName = command[0];
                    string currentPresent = command[1];
                    int currentNumberOfPresents = int.Parse(command[2]);
                    if (!allChildren_NumberOfToys.ContainsKey(currentChildName))
                    {
                        allChildren_NumberOfToys.Add(currentChildName, 0);
                    }

                    if (!allPresents_Quantity.ContainsKey(currentPresent))
                    {
                        allPresents_Quantity.Add(currentPresent, 0);
                    }

                    allChildren_NumberOfToys[currentChildName] += currentNumberOfPresents;
                    allPresents_Quantity[currentPresent] += currentNumberOfPresents;

                }
                else
                {
                    string child = command[1];
                    allChildren_NumberOfToys.Remove(child);
                }
            }

            Console.WriteLine("Children:");
            foreach (KeyValuePair<string, int> child in allChildren_NumberOfToys.OrderByDescending(v=>v.Value).ThenBy(k=>k.Key))
            {
                Console.WriteLine($"{child.Key} -> {child.Value}");
            }

            Console.WriteLine("Presents:");
            foreach (KeyValuePair<string, int> present in allPresents_Quantity)
            {
                Console.WriteLine($"{present.Key} -> {present.Value}");
            }

          


            
        }
    }
}
