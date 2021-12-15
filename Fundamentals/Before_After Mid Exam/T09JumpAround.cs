using System;

using System.Linq;


namespace T09JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int currentIndexPosition = 0;
            int jump = initialArray[0];
            int collectedValue = jump;


            while (true)
            {
                if (currentIndexPosition + jump < initialArray.Length)
                {

                    currentIndexPosition += jump;
                    jump = initialArray[currentIndexPosition];
                    collectedValue += jump;

                }

                else if (currentIndexPosition - jump >= 0)
                {

                    currentIndexPosition -= jump;
                    jump = initialArray[currentIndexPosition];
                    collectedValue += jump;
                    
                }
                else
                {
                    break;
                }
               
            }

            Console.WriteLine(collectedValue);
            
            
                        
                  

        }

    }
}
