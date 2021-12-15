using System;

namespace _05._Excursion_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaExcursions = int.Parse(Console.ReadLine());
            int mountainExcursions = int.Parse(Console.ReadLine());

            string command = Console.ReadLine(); // sea or mountain
           

            double profit = 0;
            

            while (command != "Stop")
            {
                  
                if (command == "sea")
                {

                    seaExcursions--;
                    if (seaExcursions >= 0)
                    {
                        profit += 680;
                        
                    }
                    else if (seaExcursions < 0)
                    {
                        
                        profit += 0;
                       
                    }
                    
                }
                else if (command == "mountain")
                {
                    mountainExcursions--;
                    if (mountainExcursions >= 0)
                    {
                        profit += 499;
                       
                    }

                    else if (mountainExcursions < 0)
                    {
                        
                        profit += 0; 
                    }
                    

                }
                if (seaExcursions <= 0 && mountainExcursions <= 0)
                {
                    Console.WriteLine("Good job! Everything is sold."); break;


                }
                


                command = Console.ReadLine();
            }


            Console.WriteLine($"Profit: {profit} leva.");

        }
    }
}
