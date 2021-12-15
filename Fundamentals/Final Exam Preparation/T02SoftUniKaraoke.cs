using System;
using System.Collections.Generic;

using System.Linq;

namespace T02SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> allParticipants_Awards = new Dictionary<string, List<string>>();

            
            string[] allParicipants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            string[] allSongs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

         

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] command = input.Split(new string[] {", "}, StringSplitOptions.None);

                string currentParitcipant = command[0];
                string currentSong = command[1];
                string currentAward = command[2];


                if (allParicipants.Contains(currentParitcipant) && allSongs.Contains(currentSong))
                {
                    if (!allParticipants_Awards.ContainsKey(currentParitcipant))
                    {
                        allParticipants_Awards.Add(currentParitcipant, new List<string>());
                    }

                    allParticipants_Awards[currentParitcipant].Add(currentAward);
                }
            }

            allParticipants_Awards = allParticipants_Awards.OrderByDescending(v => v.Value.Distinct().Count())
                .ThenBy(k => k.Key).ToDictionary(k => k.Key, v => v.Value);

            if (allParticipants_Awards.Values.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (KeyValuePair<string, List<string>> participant in allParticipants_Awards)
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Distinct().Count()} awards");
                    foreach (string award in participant.Value.Distinct().OrderBy(x=>x))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }

        }
    }
}
