using System;

namespace T04Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool NumOfCharacters = false;
            bool lettersAndDigits = true;
            bool least2Digits = false;

            int countOfDigits = 0;
            int countNonLetterAndDigits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                
                char currSymbol = password[i];

                if (i >= 5 && i <= 9)
                {
                    NumOfCharacters = true;

                }
                else if (i < 5 || i > 9)
                {
                    NumOfCharacters = false;
                }
                
                if (currSymbol < 48 || (currSymbol > 57 && currSymbol < 65) || 
                    (currSymbol > 90 && currSymbol < 97) || currSymbol > 122)
                {
                    countNonLetterAndDigits++;
                    if (countNonLetterAndDigits > 0)
                    {
                        lettersAndDigits = false;
                    }
                }
                if (currSymbol >= 48 && currSymbol <= 57)
                {
                    countOfDigits++;
                    if (countOfDigits >= 2)
                    {

                        least2Digits = true;

                    }
                    else
                    {
                        least2Digits = false;
                    }


                }


            }
            if (NumOfCharacters && lettersAndDigits && least2Digits)
            {
                Console.WriteLine("Password is valid");
            }
            if (!NumOfCharacters)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");

            }
            if (!lettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");

            }
            if (!least2Digits)
                {
                Console.WriteLine("Password must have at least 2 digits");
            }



        }
    }
}
