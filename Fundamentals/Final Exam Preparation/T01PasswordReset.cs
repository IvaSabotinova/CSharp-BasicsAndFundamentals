using System;
using System.Text;

namespace T01PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Done")
            {
                string[] subcommands = command.Split();
                string cmd = subcommands[0];

                if (cmd == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            
                            sb.Append(password[i]);
                        }

                    }

                    password = sb.ToString();
                    Console.WriteLine(password);
                    
                }
                else if (cmd == "Cut")
                {
                    int index = int.Parse(subcommands[1]);
                    int length = int.Parse(subcommands[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else
                {
                    string substringToRemove = subcommands[1];
                    string substitute = subcommands[2];
                    if (password.Contains(substringToRemove))
                    {
                        password = password.Replace(substringToRemove, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }
                }

            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
