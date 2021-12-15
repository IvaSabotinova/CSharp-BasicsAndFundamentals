using System;

namespace T06WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastMainSector = Console.ReadLine();
            int rowsNumberInMainSectorA = int.Parse(Console.ReadLine());
            int seatsNumberOddRows = int.Parse(Console.ReadLine());

            int countSeatsOddRows = 0;
            int countSeatsEvenRows = 0;

            for (int i = 65; i <= char.Parse(lastMainSector); i++)
            {

                for (int j = 1; j <= rowsNumberInMainSectorA; j++)
                {
                    if (j % 2 != 0)
                    {


                        for (int k = 97; k < 97 + seatsNumberOddRows; k++)
                        {
                            countSeatsOddRows++;
                            Console.WriteLine($"{(char)i}{j}{(char)k}");
                        }

                    }
                    else
                    {
                        for (int l = 97; l < 97 + seatsNumberOddRows + 2; l++)
                        {
                            countSeatsEvenRows++;
                            Console.WriteLine($"{(char)i}{j}{(char)l}");
                        }


                    }
                }

                rowsNumberInMainSectorA++;
            }

            Console.WriteLine($"{countSeatsOddRows + countSeatsEvenRows}");

        }
    }
}
