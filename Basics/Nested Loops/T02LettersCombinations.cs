using System;

namespace T02LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLetter = Console.ReadLine();
            string secondLetter = Console.ReadLine();
            string thirdLetter = Console.ReadLine();

            int count = 0;

            for (int i = char.Parse(firstLetter); i <= char.Parse(secondLetter); i++)
            {
                for (int j = char.Parse(firstLetter); j <= char.Parse(secondLetter); j++)
                {
                    for (int k = char.Parse(firstLetter); k <= char.Parse(secondLetter); k++)
                    {

                        if (i != char.Parse(thirdLetter) && j != char.Parse(thirdLetter) && k != char.Parse(thirdLetter))
                        {

                            
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                            count++;
                            
                        
                        }
                    }
                }


            }
            Console.Write(count);
        }
    }
}
