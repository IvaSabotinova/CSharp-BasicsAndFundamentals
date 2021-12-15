using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T02MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            string pattern = @"([@|#]+)(?<word1>[A-Za-z]{3,})(\1)(\1)(?<word2>[A-Za-z]{3,})(\1)";

            Regex regex = new Regex(pattern);


            MatchCollection matches = regex.Matches(text);
            List<string> pairs = new List<string>();

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");

            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                foreach (Match match in matches)
                {
                    string word1 = match.Groups["word1"].Value.ToString();
                    string word2 = match.Groups["word2"].Value.ToString();
                    string reversedWord1 = String.Empty;
                    for (int i = word1.Length - 1; i >= 0; i--)
                    {
                        reversedWord1 += word1[i];

                    }

                    if (reversedWord1 == word2)
                    {
                        string newString = $"{word1} <=> {word2}";
                        pairs.Add(newString);
                    }
                }
            }

            if (pairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", pairs));
            }


        }
    }
}
