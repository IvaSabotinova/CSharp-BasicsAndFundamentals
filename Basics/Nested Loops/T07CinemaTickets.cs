using System;

namespace T07CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();


            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            int totalBoughtTickets = 0;


            while (film != "Finish")
            {

                int availableSeatsPerFilm = int.Parse(Console.ReadLine());
                int numberOfBoughtTicketsPerFilm = 0;
                while (numberOfBoughtTicketsPerFilm < availableSeatsPerFilm)
                {

                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }

                    numberOfBoughtTicketsPerFilm++;

                    switch (ticketType)
                    {
                        case "standard": standardTickets++; break;
                        case "student": studentTickets++; break;
                        case "kid": kidTickets++; break;
                        default: break;
                    }

                }

                double percentFullHallPerFilm = (double)numberOfBoughtTicketsPerFilm / availableSeatsPerFilm * 100;

                Console.WriteLine($"{film} - {percentFullHallPerFilm:f2}% full.");

                totalBoughtTickets += numberOfBoughtTicketsPerFilm;



                film = Console.ReadLine();
            }


            double percentStandardTickets = 1.0 * standardTickets / totalBoughtTickets * 100;
            double percentStudentTickets = 1.0 * studentTickets / totalBoughtTickets * 100;
            double percentKidTickets = 1.0 * kidTickets / totalBoughtTickets * 100;


            Console.WriteLine($"Total tickets: {totalBoughtTickets}");
            Console.WriteLine($"{percentStudentTickets:f2}% student tickets.");
            Console.WriteLine($"{percentStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentKidTickets:f2}% kids tickets.");

        }
    }
}
