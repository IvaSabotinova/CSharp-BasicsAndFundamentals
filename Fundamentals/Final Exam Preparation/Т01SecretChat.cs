using System;
using System.Text;

namespace Т01SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string input = String.Empty;

            StringBuilder result = new StringBuilder(encryptedMessage);

            while ((input = Console.ReadLine()) != "Reveal")
            {
                
                string[] commands = input.Split(":|:");
                

                if (commands[0] == "InsertSpace")
                {
                    result.Insert(int.Parse(commands[1]), " ");
                    Console.WriteLine(result);
                }
                else if (commands[0] == "Reverse")
                {

                    string temp = result.ToString();
                    if (temp.Contains(commands[1]))
                    {
                        
                        string substring = commands[1];
                        int index = temp.IndexOf(substring);
                        string temp1 = temp.Remove(index, substring.Length);

                        StringBuilder reversedMsg = new StringBuilder();
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversedMsg.Append(substring[i]);
                        }

                        result = new StringBuilder(temp1);
                        result.Append(reversedMsg);
                        Console.WriteLine(result);

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (commands[0] == "ChangeAll")
                {
                    string textToReplace = commands[1];
                    string replacement = commands[2];
                    result.Replace(textToReplace, replacement);
                    Console.WriteLine(result);
                }

            }

            Console.WriteLine($"You have a new text message: {result}");
        }
    }
}
