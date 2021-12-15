using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T01TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            List<string> commands = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            StringBuilder decryptedMessage = new StringBuilder();
            decryptedMessage.Append(encryptedMessage);

            while (commands[0] != "Decode")
            {
                
                if (commands[0] == "Move")
                {
                    int numberOfLettersToAppend = int.Parse(commands[1]);
                    string substring = decryptedMessage.ToString();
                    decryptedMessage.Append(substring.Substring(0, numberOfLettersToAppend));
                    decryptedMessage.Remove(0, numberOfLettersToAppend);

                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[1]);
                    string valueToInsert = commands[2];
                    decryptedMessage.Insert(index, valueToInsert);

                }
                else if (commands[0] == "ChangeAll")
                {
                    string oldText = commands[1];
                    string newText = commands[2];
                    decryptedMessage.Replace(oldText, newText);

                }

                
                commands = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            Console.WriteLine($"The decrypted message is: {decryptedMessage}");
        }
    }
}
