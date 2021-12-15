using System;

namespace T05Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyScores = double.Parse(Console.ReadLine());
            int jouryNumber = int.Parse(Console.ReadLine());

            double actorScores = academyScores;

            for (int i = 1; i <= jouryNumber; i++)
            
            {
                string jouryMemberName = Console.ReadLine();
                double jouryMemberScores = double.Parse(Console.ReadLine());

                int jouryMemberNameLenght = jouryMemberName.Length;

                actorScores += jouryMemberNameLenght * jouryMemberScores / 2;
                if (actorScores > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {actorScores:f1}!"); break;
                }

            }
            

            if (actorScores <= 1250.5)
            {
            
            
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - actorScores):f1} more!");
            }

        }
    }
}
