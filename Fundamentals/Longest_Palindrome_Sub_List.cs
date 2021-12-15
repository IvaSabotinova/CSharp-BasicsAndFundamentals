using System;

namespace Longest_Palindrome_Sub_ListVer2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GetMaxPalindromeStringLength(input));

        }

        static int GetMaxPalindromeStringLength(string input)
        {
            int maxPalindromeStringLength = 1;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = input.Length - 1; j > i; j--)
                {

                    if (input[i] == input[j])
                    {
                        bool isPalindrome = true;
                        int indexFromEnd = j - 1;
                        for (int k = i + 1; k <= indexFromEnd; k++)
                        {

                            if (input[k] != input[indexFromEnd])
                            {
                                isPalindrome = false;
                                break;
                            }

                            indexFromEnd--;
                        }

                        if (isPalindrome)
                        {
                            if (j - i + 1 > maxPalindromeStringLength)
                            {
                                maxPalindromeStringLength = j - i + 1;
                            }
                        }
                    }
                    
                }

            }


            return maxPalindromeStringLength;
            
        }

    }
}
