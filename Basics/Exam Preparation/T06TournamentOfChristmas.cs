using System;

namespace T06TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int competitionDays = int.Parse(Console.ReadLine());
                                    
            double totalEarnedMoney = 0;            
            int winDays = 0;
            int looseDays = 0;

            for (int i = 1; i <= competitionDays; i++)
            {
                string sportType = Console.ReadLine();
                double earnedMoneyPerDay = 0;
                int countWin = 0;
                int countLoose = 0;

                while (sportType != "Finish")
                {
                    string winOrLoose = Console.ReadLine();

                    if (winOrLoose == "win")
                    {
                        earnedMoneyPerDay += 20;
                        countWin++;
                    }
                    else if (winOrLoose == "lose")
                    {
                        earnedMoneyPerDay += 0;
                        countLoose++;
                    }
                    sportType = Console.ReadLine();

                }

                    if (countWin > countLoose)
                    {
                        earnedMoneyPerDay *= 1.10;
                        winDays++;
                    }
                    else
                    {
                        looseDays++;
                    }
                    
                
                totalEarnedMoney += earnedMoneyPerDay;

            }

            if (winDays > looseDays)
            {
                Console.WriteLine($"You won the tournament! Total raised money: {totalEarnedMoney * 1.20:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalEarnedMoney:f2}");
            }
        }
    }
}
