using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string consoleWord = Console.ReadLine();
            //int repeat = int.Parse(Console.ReadLine());

            //string result = RepeatString(consoleWord, repeat);
            //Console.WriteLine(result);

            //int n = int.Parse(Console.ReadLine());

            //for (int i = n - 1; i > 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            List<int> numbers = new List<int>();
            numbers.Add(21);
            numbers.Add(21);
            numbers.Add(21);
            numbers.Add(21);
            numbers.Add(21);
            for (int i = 0; i < 100; i++)
            {
                numbers.Add(21);
                
            }

            Console.WriteLine(String.Join(" ", numbers));
            



        }

        //    int dimension = int.Parse(Console.ReadLine());
        //    for (int i = 1; i <= dimension; i++)
        //    {
        //        PrintNumbers(i);
        //    }

        //    for (int i = dimension - 1; i > 0; i--)
        //    {
        //        PrintNumbers(i);
        //    }


        //    static void PrintNumbers(int limit)
        //    {
        //        for (int i = 1; i <= limit; i++)
        //        {
        //            Console.Write($"{i} ");

        //        }

        //        Console.WriteLine();
        //    }

        //StringBuilder sb = new StringBuilder("ABC", 50);
        //sb.Append(new char[] {'D', 'E', 'F'});
        //sb.AppendFormat("GHI{0}{1}", 'J', 'K');
        //    Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());

        ////// Append three characters (D, E, and F) to the end of the StringBuilder.
        ////sb.Append(new char[] { 'D', 'E', 'F' });

        ////// Append a format string to the end of the StringBuilder.
        ////sb.AppendFormat("GHI{0}{1}", 'J', 'k');

        ////// Display the number of characters in the StringBuilder and its string.
        ////Console.WriteLine("{0} chars: {1}", sb.Length, sb.ToString());


        //private static string RepeatString(string word, int count)
        //{
        //    StringBuilder result = new StringBuilder();
        //    for (int i = 0; i < count; i++)
        //    {
        //        result.Append(word + " ");
        //    }

        //    return result.ToString();

        //}

       

    }
}

