using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Message_Decrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern =
                @"^([$|%])(?<tag>[A-Z][a-z]{2,})(\1): \[(?<first>\d{1,3})\]\|\[(?<second>\d{1,3})\]\|\[(?<third>\d{1,3})\]\|$";


            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                Regex regex = new Regex(pattern);

                Match match = regex.Match(input);

                if (match.Success)
                {
                    StringBuilder sb = new StringBuilder();
                    char one = Convert.ToChar(int.Parse(match.Groups["first"].Value));
                    char second = Convert.ToChar(int.Parse(match.Groups["second"].Value));
                    char third = Convert.ToChar(int.Parse(match.Groups["third"].Value));
                    sb.Append(one);
                    sb.Append(second);
                    sb.Append(third);

                    Console.WriteLine($"{match.Groups["tag"].Value}: {sb}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }


            }

        }
    }
}
