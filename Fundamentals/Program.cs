using System;

namespace T01Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Abracadabra")
            {

                string[] subcommands = command.Split();

                if (subcommands[0] == "Abjuration")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);

                }
                else if (subcommands[0] == "Necromancy")
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (subcommands[0] == "Illusion")
                {
                    int index = int.Parse(subcommands[1]);
                    string letter = subcommands[2];
                    if (index < 0 || index >= input.Length)
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                    else
                    {
                        input = input.Remove(index, 1);
                        input = input.Insert(index, letter);
                        Console.WriteLine("Done!");
                    }

                }
                else if (subcommands[0] == "Divination")
                {
                    string firstSubstring = subcommands[1];
                    string secondSubstring = subcommands[2];
                    if (input.Contains(firstSubstring))
                    {
                        input = input.Replace(firstSubstring, secondSubstring);
                        Console.WriteLine(input);
                    }
                }
                else if (subcommands[0] == "Alteration")
                {
                    string substr = subcommands[1];
                    if (input.Contains(substr))
                    {
                        int index = input.IndexOf(substr);
                        input = input.Remove(index, substr.Length);
                        Console.WriteLine(input);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }


            }


        }
      
        
    }
}
