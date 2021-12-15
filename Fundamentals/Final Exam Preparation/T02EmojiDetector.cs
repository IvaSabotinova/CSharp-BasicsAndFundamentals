using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace T02EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(::|\*\*)(?<emoji>[A-Z][a-z]{2,})(\1)";

            string patternDigits = @"\d";

            Regex regex = new Regex(pattern);
            Regex numbers = new Regex(patternDigits);


            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);
            MatchCollection numbersMatches = numbers.Matches(input);

            BigInteger result = 1;
            foreach (Match number in numbersMatches)
            {
                result *= int.Parse(number.ToString());
            }

            Console.WriteLine($"Cool threshold: {result}");

            List<string> coolEmojies = new List<string>();
            foreach (Match match in matches)
            {
                int sum = 0;
                string currentWord = match.Groups["emoji"].Value.ToString();
                for (int i = 0; i < currentWord.Length; i++)
                {
                    sum += (char)currentWord[i];
                }

                if (sum > result)
                {
                    coolEmojies.Add(match.ToString());
                }
            }

            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(String.Join("\n", coolEmojies));




        }
    }
}
