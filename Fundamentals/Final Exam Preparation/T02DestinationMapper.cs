using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T02DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection destinations = regex.Matches(input);

            int lengthOfSymbols = 0;

            List<string> allDestinations = new List<string>();
            foreach (Match item in destinations)
            {
                lengthOfSymbols += item.Groups["destination"].Length;
                string destination = item.Groups["destination"].Value;
                allDestinations.Add(destination);

                
            }
            Console.WriteLine($"Destinations: {string.Join(", ", allDestinations)}");
            Console.WriteLine($"Travel Points: {lengthOfSymbols}");
        }
    }
}
