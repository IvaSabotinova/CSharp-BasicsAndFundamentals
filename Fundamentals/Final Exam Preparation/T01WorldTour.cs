using System;
using System.Linq;

namespace T01WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Travel")
            {

                string[] subcommands = command.Split(":");
                if (subcommands[0] == "Add Stop")
                {
                    int index = int.Parse(subcommands[1]);
                    string substringToInsert = subcommands[2];
                    if (index >= 0 && index < input.Length)
                    {
                        input = input.Insert(index, substringToInsert);
                        
                    }

                    Console.WriteLine(input);

                }
                else if (subcommands[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(subcommands[1]);
                    int endIndex = int.Parse(subcommands[2]);
                    if (startIndex >= 0 && startIndex < input.Length && endIndex >= 0 && endIndex < input.Length)
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                        
                    }
                    Console.WriteLine(input);
                }
                else if (subcommands[0] == "Switch")
                {
                    string oldString = subcommands[1];
                    string newString = subcommands[2];
                    if (input.Contains(oldString))
                    {
                        input = input.Replace(oldString, newString);
                        
                    }
                    Console.WriteLine(input);
                }


            }

            Console.WriteLine($"Ready for world tour! Planned stops: {input}");
        }
    }
}
