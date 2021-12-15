using System;

namespace T06HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialHeight = int.Parse(Console.ReadLine());

            int tihomirHeight = int.Parse(Console.ReadLine());

            int levelHeight = initialHeight - 30;
            int countFails = 0;
            int countAllJumps = 1;
            

            while (initialHeight >= levelHeight)

            {

                if (levelHeight >= tihomirHeight)
                {
                    countFails++;
                    if (countFails == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {levelHeight}cm after {countAllJumps} jumps."); return;
                    }

                }
                else
                {
                    if (levelHeight == initialHeight)
                    {
                        break;
                    }
                    
                    levelHeight += 5;                    
                    countFails = 0;
                }


                tihomirHeight = int.Parse(Console.ReadLine());
                countAllJumps++;
                


            }
              Console.WriteLine($"Tihomir succeeded, he jumped over {initialHeight}cm after {countAllJumps} jumps.");
            }        
    }
}
