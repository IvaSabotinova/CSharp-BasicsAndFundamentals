using System;

namespace T03StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = " ";
            string text = " ";
            int countC = 0;
            int countO = 0;
            int countN = 0;
            bool isMetC = false;
            bool isMetO = false;
            bool isMetN = false;


            while (input != "End")
            {
                char symbol = char.Parse(input);

                if ((symbol >= 65 && symbol <= 90) || (symbol >= 97 && symbol <= 122))
                {
                    if (symbol == 'c')
                    {
                        countC++;
                        if (countC == 1)
                        {
                            isMetC = true;
                        }
                        else if (countC > 1)
                        {
                            word += symbol;
                        }
                    }
                    else if (symbol == 'o')
                    {
                        countO++;
                        if (countO == 1)
                        {
                            isMetO = true;
                        }
                        else if (countO > 1)
                        {

                            word += symbol;
                        }
                    }
                    else if (symbol == 'n')
                    {
                        countN++;
                        if (countN == 1)
                        {
                            isMetN = true;
                        }
                        else if (countN > 1)
                        {
                            word += symbol;
                        }
                    }
                    else
                    {
                        word += symbol;

                    }
                    if (isMetC && isMetO && isMetN)
                    {
                        text += word;
                        
                        isMetC = false;
                        isMetO = false;
                        isMetN = false;
                        countC = 0;
                        countO = 0;
                        countN = 0;
                        word = " ";


                    }

                }


                input = Console.ReadLine();

            }
            Console.WriteLine(text);


        }
    }
}
