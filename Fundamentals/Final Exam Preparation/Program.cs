using System;
using System.Collections.Generic;
using System.Linq;

namespace T03ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> allPieces_Composers_Keys = new Dictionary<string, List<string>>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string currentPiece = input[0];
                string currentComposer = input[1];
                string currentKey = input[2];

                allPieces_Composers_Keys.Add(currentPiece, new List<string>());
                allPieces_Composers_Keys[currentPiece].Add(currentComposer);
                allPieces_Composers_Keys[currentPiece].Add(currentKey);
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] subcommands = command.Split("|");
                string currPiece = subcommands[1];

                if (subcommands[0] == "Add")
                {
                    string currComposer = subcommands[2];
                    string currKey = subcommands[3];
                    if (!allPieces_Composers_Keys.ContainsKey(currPiece))
                    {
                        allPieces_Composers_Keys.Add(currPiece, new List<string>());
                        allPieces_Composers_Keys[currPiece].Add(currComposer);
                        allPieces_Composers_Keys[currPiece].Add(currKey);
                        Console.WriteLine($"{currPiece} by {currComposer} in {currKey} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{currPiece} is already in the collection!");
                    }

                }
                else if (subcommands[0] == "Remove")
                {

                    if (allPieces_Composers_Keys.ContainsKey(currPiece))
                    {
                        Console.WriteLine($"Successfully removed {currPiece}!");
                        allPieces_Composers_Keys.Remove(currPiece);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currPiece} does not exist in the collection.");
                    }
                }
                else if (subcommands[0] == "ChangeKey")
                {
                    string newKey = subcommands[2];
                    if (allPieces_Composers_Keys.ContainsKey(currPiece))
                    {
                        Console.WriteLine($"Changed the key of {currPiece} to {newKey}!");
                        allPieces_Composers_Keys[currPiece][1] = newKey;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {currPiece} does not exist in the collection.");
                    }

                }


            }

            foreach (KeyValuePair<string, List<string>> piece in allPieces_Composers_Keys.OrderBy(x => x.Key).ThenBy(v => v.Value[0]))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
