using System;

namespace T05BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            int bestGoalResult = 0;
            string bestPlayer = "";

            while (playerName != "END")
            {
                int playerGoalsNumber = int.Parse(Console.ReadLine());

                if (playerGoalsNumber > bestGoalResult)
                {
                    bestGoalResult = playerGoalsNumber;
                    bestPlayer = playerName;

                    if (bestGoalResult >= 10)
                    {
                        Console.WriteLine($"{bestPlayer} is the best player!");
                        Console.WriteLine($"He has scored {bestGoalResult} goals and made a hat-trick !!!"); return;
                    }

                }


                playerName = Console.ReadLine();
            }


            if (bestGoalResult < 3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {bestGoalResult} goals.");
            }

            else if (bestGoalResult >= 3 && bestGoalResult < 10)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {bestGoalResult} goals and made a hat-trick !!!");
            }





        }
    }
}
