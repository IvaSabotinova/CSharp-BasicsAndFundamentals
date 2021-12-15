using System;

namespace _06._The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double charSum = 0;

            for (int i = 0; i < input.Length; i++)
            {

                char currLetter = input[i];
                charSum += currLetter;
            }
            if (input[0] == 'a' || input[0] == 'e' || input[0] == 'i' || input[0] == 'o' || input[0] == 'u' || input[0] == 'y' ||
               input[0] == 'A' || input[0] == 'E' || input[0] == 'I' || input[0] == 'O' || input[0] == 'U' || input[0] == 'Y')
            {


                charSum *= input.Length;
            }
            else
            {
               charSum = Math.Floor(charSum / input.Length);

            }
            Console.WriteLine(charSum);
        }
    }
}
