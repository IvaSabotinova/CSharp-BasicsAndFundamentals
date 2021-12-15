using System;

namespace T13SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysStay = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string assessment = Console.ReadLine();

            int nights = daysStay - 1;
            double priceRoomPerNightForOnePerson = 18.00;
            double priceRoomPerNightApartment = 25.00;
            double priceRoomPerNightPresidentApartment = 35.00;
            double priceOfStayPriorAssessment = 0;

            if (typeRoom == "room for one person")
            {
                priceOfStayPriorAssessment = priceRoomPerNightForOnePerson * nights;

                if (assessment == "positive")
                {
                    Console.WriteLine($"{priceOfStayPriorAssessment *= 1.25:f2}");
                }
                else if (assessment == "negative")
                {
                    Console.WriteLine($"{priceOfStayPriorAssessment *= 0.90:f2}");
                }

            }
            if (typeRoom == "apartment")
            {
                if (daysStay < 10)
                {
                    priceOfStayPriorAssessment = priceRoomPerNightApartment * nights * 0.70;
                    if (assessment == "positive")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 1.25:f2}");
                    }
                    else if (assessment == "negative")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 0.90:f2}");
                    }
                }
                else if (daysStay >= 10 && daysStay <= 15)
                {
                    priceOfStayPriorAssessment = priceRoomPerNightApartment * nights * 0.65;
                    if (assessment == "positive")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 1.25:f2}");
                    }
                    else if (assessment == "negative")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 0.90:f2}");
                    }
                }
                
                else if (daysStay > 15)
                {
                    priceOfStayPriorAssessment = priceRoomPerNightApartment * nights * 0.50;
                    if (assessment == "positive")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 1.25:f2}");
                    }
                    else if (assessment == "negative")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 0.90:f2}");
                    }
                }
            }

            if (typeRoom == "president apartment")
            {
                if (daysStay < 10)
                {
                    priceOfStayPriorAssessment = priceRoomPerNightPresidentApartment * nights * 0.90;
                    if (assessment == "positive")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 1.25:f2}");
                    }
                    else if (assessment == "negative")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 0.90:f2}");
                    }
                }
                else if (daysStay >= 10 && daysStay <= 15)
                {
                        priceOfStayPriorAssessment = priceRoomPerNightPresidentApartment * nights * 0.85;
                    if (assessment == "positive")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 1.25:f2}");
                    }
                    else if (assessment == "negative")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 0.90:f2}");
                    }
                }
                
                else if (daysStay > 15)
                {
                    priceOfStayPriorAssessment = priceRoomPerNightPresidentApartment * nights * 0.80;
                    if (assessment == "positive")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *= 1.25:f2}");
                    }
                    else if (assessment == "negative")
                    {
                        Console.WriteLine($"{priceOfStayPriorAssessment *=0.90:f2}");
                    }
                }
            }
        }
    }
}
