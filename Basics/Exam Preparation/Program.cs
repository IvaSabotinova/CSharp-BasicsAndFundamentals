using System;

namespace T04Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int takenBallsNumber = int.Parse(Console.ReadLine());
            string ballsColor = Console.ReadLine();

            int numberOfRedBalls = 0;
            int numberOfOrangeBalls = 0;
            int numberOfYellowBalls = 0;
            int numberOfWhiteBalls = 0;
            int dividedFromBlackBalls = 0;
            
            int totalScores = 0;
            int otherColorsPicked = 0;
            

            while (takenBallsNumber != 0)
            {
                if (ballsColor == "red")
                {
                    takenBallsNumber--;
                    numberOfRedBalls++;
                    totalScores += 5;
                }
                else if (ballsColor == "orange")
                {
                    takenBallsNumber--;
                    numberOfOrangeBalls++;
                    totalScores += 10;
                }
                else if (ballsColor == "yellow")
                {
                    takenBallsNumber--;
                    numberOfYellowBalls++;
                    totalScores += 15;
                }
                else if (ballsColor == "white")
                {
                    takenBallsNumber--;
                    numberOfWhiteBalls++;
                    totalScores += 20;
                }
                else if (ballsColor == "black")
                {
                    dividedFromBlackBalls++;
                    takenBallsNumber--;
                    totalScores /= 2;
                }
                else
                {
                    otherColorsPicked++;
                    takenBallsNumber--;

                }
                ballsColor = Console.ReadLine();
            }

            Console.WriteLine($"Total points: {totalScores}");
            Console.WriteLine($"Points from red balls: {numberOfRedBalls}");
            Console.WriteLine($"Points from orange balls: {numberOfOrangeBalls}");
            Console.WriteLine($"Points from yellow balls: {numberOfYellowBalls}");
            Console.WriteLine($"Points from white balls: {numberOfWhiteBalls}");
            Console.WriteLine($"Other colors picked: {otherColorsPicked}");
            Console.WriteLine($"Divides from black balls: {dividedFromBlackBalls}");


                
        }
    }
}
