using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Generate")
            {

                string[] subcommands = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                if (subcommands[0] == "Contains")
                {
                    if (input.Contains(subcommands[1]))
                    {
                        Console.WriteLine($"{input} contains {subcommands[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (subcommands[0] == "Flip")
                {
                    int startIndex = int.Parse(subcommands[2]);
                    int endIndex = int.Parse(subcommands[3]);
                    int substringLength = endIndex - startIndex;
                    string substring = input.Substring(startIndex, endIndex-startIndex);


                    if (subcommands[1] == "Upper")
                    {
                        input = input.Remove(startIndex, substringLength);
                        input = input.Insert(startIndex, substring.ToUpper());
                        Console.WriteLine(input);

                    }
                    else
                    {
                        input = input.Remove(startIndex, substringLength);
                        input = input.Insert(startIndex, substring.ToLower());
                        Console.WriteLine(input);
                    }


                }
                else if (subcommands[0] == "Slice")
                {
                    int start = int.Parse(subcommands[1]);
                    int end = int.Parse(subcommands[2]);
                    input = input.Remove(start, end - start);
                    Console.WriteLine(input);
                }

            }

            Console.WriteLine($"Your activation key is: {input}");

        }
    }
}
