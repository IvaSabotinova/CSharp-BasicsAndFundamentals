using System;
using System.Collections.Generic;
using System.Linq;

namespace T02Santa_sGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<int> houses = Console.ReadLine().Split().Select(int.Parse).ToList();
            int currentIndexPosition = 0;

            for (int i = 0; i < numberOfCommands; i++)
            {

                
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];
               
               
                if (command == "Forward")
                {
                    int temp = currentIndexPosition + int.Parse(input[1]);
                    if (temp >= 0 && temp < houses.Count)
                    {
                        houses.RemoveAt(temp);
                        currentIndexPosition = temp;
                    }
                   
                }
                else if (command == "Back")
                {
                    int temp1 = currentIndexPosition - int.Parse(input[1]);
                    if (temp1 >= 0 && temp1 < houses.Count)
                    {
                        houses.RemoveAt(temp1);
                        currentIndexPosition = temp1;
                    }
                }
                else if (command == "Gift")
                {
                    int index = int.Parse(input[1]);
                    int houseNumber = int.Parse(input[2]);
                    if (index >= 0 && index < houses.Count)
                    {

                        houses.Insert(index, houseNumber);
                        currentIndexPosition = index;
                        
                    }
                }
                else if (command == "Swap")
                {
                    
                    int firstHouse = int.Parse(input[1]);
                    int secondHouse = int.Parse(input[2]);
                    int indexFirstHouse = houses.IndexOf(firstHouse);
                    int indexSecondHouse = houses.IndexOf(secondHouse);
                    if (indexFirstHouse >= 0 && indexFirstHouse < houses.Count && indexSecondHouse >= 0 &&
                        indexSecondHouse < houses.Count)
                    {
                        int tempFirstHouse = houses[indexFirstHouse];
                        houses[indexFirstHouse] = houses[indexSecondHouse];
                        houses[indexSecondHouse] = tempFirstHouse;
                    }

                }

                
            }
            Console.WriteLine($"Position: {currentIndexPosition}");
            Console.WriteLine(string.Join(", ", houses));
        }
    }
}
