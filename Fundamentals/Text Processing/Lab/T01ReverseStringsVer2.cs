using System;
using System.Collections.Generic;
using System.Linq;



namespace T01ReverseStringsVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                IEnumerable<char> reversedInput = input.ToArray().Reverse();
                
                Console.WriteLine($"{input} = {string.Join("", reversedInput)}");
                input = Console.ReadLine();
            }
        }
    }
}
