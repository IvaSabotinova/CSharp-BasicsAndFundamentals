using System;

namespace T04CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int startOfInterval = int.Parse(Console.ReadLine());
            int endOfInterval = int.Parse(Console.ReadLine());

            for (int i = startOfInterval; i <= endOfInterval; i++)
            {
                for (int j = startOfInterval; j <= endOfInterval; j++)
                {
                    for (int k = startOfInterval; k <= endOfInterval; k++)
                    {
                        for (int l = startOfInterval; l <= endOfInterval; l++)
                        {
                            if (((i % 2 == 0 && l % 2 != 0) || (i % 2 != 0 && l % 2 == 0)) && i > l && (j + k) % 2 == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            
                            }
                        }
                    }
                }
            }

        }
    }
}
