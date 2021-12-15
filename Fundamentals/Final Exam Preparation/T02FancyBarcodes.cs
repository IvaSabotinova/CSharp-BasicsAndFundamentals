using System;
using System.Text.RegularExpressions;

namespace T02FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                string pattern = @"@[#]+(?<word>[A-Z][A-Za-z0-9]{4,}[A-Z])@[#]+";

                Regex regex = new Regex(pattern);

                bool isValid = regex.IsMatch(input);

                if (isValid)
                {
                    Match match = regex.Match(input);
                    
                    string myWord = match.Groups["word"].Value.ToString();
                    string productGroup = String.Empty;
                    for (int j = 0; j < myWord.Length; j++)
                    {
                        if (char.IsDigit(myWord[j]))
                        {
                            productGroup += myWord[j];
                        }

                    }

                    if (productGroup.Length == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
