using System;

namespace T05ChallengeTheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int menNumber = int.Parse(Console.ReadLine());
            int womenNumber = int.Parse(Console.ReadLine());
            int tableMaxNumber = int.Parse(Console.ReadLine());

            int countOfTables = 0;

            for (int i = 1; i <= menNumber; i++)
            {
                for (int j = 1; j <= womenNumber; j++)
                {
                    
                    
                    Console.Write($"({i} <-> {j}) ");
                    countOfTables++;
                    if (countOfTables == tableMaxNumber)
                    {
                        return;
                    }

                    
                }
            }
            
        }
    }
}
