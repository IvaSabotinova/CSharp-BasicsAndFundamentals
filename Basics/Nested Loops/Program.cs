using System;

namespace T06EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCooks = int.Parse(Console.ReadLine());
            int maxScoresPerCook = 0;
            string winner = " ";

            for (int i = 1; i <= numberOfCooks; i++)
            {
                string cookName = Console.ReadLine();
                string score = Console.ReadLine();

                int scoresPerCook = 0;
                      
                while (score != "Stop")
                {
                    int visitorScores = int.Parse(score);

                    scoresPerCook += visitorScores;

                    score = Console.ReadLine();
                }

                Console.WriteLine($"{cookName} has {scoresPerCook} points.");

                if (maxScoresPerCook < scoresPerCook)
                {
                    maxScoresPerCook = scoresPerCook;
                    winner = cookName;
                    Console.WriteLine($"{winner} is the new number 1!");
                }

            }

            Console.WriteLine($"{winner} won competition with {maxScoresPerCook} points!");
        }
    }
}
