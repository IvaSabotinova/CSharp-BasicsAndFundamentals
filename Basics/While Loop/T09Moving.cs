using System;

namespace T09Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lengthFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            const int boxVolume = 1;
            int roomFreeSpace = widthFreeSpace * lengthFreeSpace * heightFreeSpace;


            while (command != "Done")
            {

                
                int numberOfBoxes = int.Parse(command);
                roomFreeSpace -= boxVolume * numberOfBoxes;

                if (roomFreeSpace <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(roomFreeSpace)} Cubic meters more."); break;
                }
                command = Console.ReadLine();


            }

            if (command == "Done" && roomFreeSpace > 0)

            {
                Console.WriteLine($"{roomFreeSpace} Cubic meters left.");
            }



        }
    }
}
