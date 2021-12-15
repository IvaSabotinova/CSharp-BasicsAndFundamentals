using System;

namespace T06NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int scores = 0;
            int maxScores = 0;
            string winnerPlayer = " ";


            while (name != "Stop")
            {
                
                for (int i = 0; i < name.Length; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    char currentLetter = name[i];
                    if (currentLetter == number)
                    {
                        scores += 10;
                    }
                    else
                    {
                        scores += 2;
                    }
                }
                if (scores >= maxScores)
                {
                    maxScores = scores;
                    winnerPlayer = name;
                }

                name = Console.ReadLine();
                scores = 0;
                

            }
            Console.WriteLine($"The winner is {winnerPlayer} with {maxScores} points!");
        }
    }
}
