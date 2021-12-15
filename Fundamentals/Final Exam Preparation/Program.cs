using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([|#])(?<name>[A-Za-z\s]+)(\1)(?<date>\d{2}/\d{2}/\d{2})(\1)(?<calories>\d{1,5})(\1)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);


            int totalCalories = 0;
            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }

            int numberOfDays = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {numberOfDays} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["name"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
