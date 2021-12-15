using System;

namespace T06BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournamentName = Console.ReadLine();

            int gameCountPerTournament = 0;
            int winGameCount = 0;
            int lostGameCount = 0;
            int gamesTotalCount = 0;

            while (tournamentName != "End of tournaments")
            {
                int matchesNumber = int.Parse(Console.ReadLine());
                gamesTotalCount += matchesNumber;
                gameCountPerTournament = 0;

                for (int i = 1; i <= matchesNumber; i++)
                {

                    int desiTeamScores = int.Parse(Console.ReadLine());
                    int opponentScores = int.Parse(Console.ReadLine());
                    gameCountPerTournament++;

                    if (desiTeamScores > opponentScores)
                    {
                        Console.WriteLine($"Game {gameCountPerTournament} of tournament {tournamentName}: win with {desiTeamScores - opponentScores} points.");
                        winGameCount++;
                    }
                    else
                    {
                        Console.WriteLine($"Game {gameCountPerTournament} of tournament {tournamentName}: lost with {opponentScores - desiTeamScores} points.");
                        lostGameCount++;
                    }
                }

                tournamentName = Console.ReadLine();

            }
            double percentWinGames = 1.0 * winGameCount / gamesTotalCount * 100;
            double percentLostGames = 1.0 * lostGameCount / gamesTotalCount * 100;
          
            Console.WriteLine($"{percentWinGames:f2}% matches win");
            Console.WriteLine($"{percentLostGames:f2}% matches lost");


        }

    }
}
