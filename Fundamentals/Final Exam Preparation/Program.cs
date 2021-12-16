using System;
using System.Linq;
using System.Numerics;

namespace T01SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] departureTime = Console.ReadLine().Split(new char[] {':'}).Select(int.Parse).ToArray();
            int numberOfSteps = int.Parse(Console.ReadLine()) % 86400;
            int secondsForAStep = int.Parse(Console.ReadLine()) % 86400;

            int departureHour = departureTime[0];
            int departureMinutes = departureTime[1];
            int departureSeconds = departureTime[2];

            int totalSecondsForWalking = numberOfSteps * secondsForAStep;
            int finalSeconds = 0;
            int finalMinutes = 0;
            int finalHour = 0;

            int departureHourInSeconds = departureHour * 3600;
            int departureMinutesInSeconds = departureMinutes * 60;

            int totalSeconds = departureHourInSeconds + departureMinutesInSeconds + departureSeconds +
                               totalSecondsForWalking;

            finalSeconds = totalSeconds % 60;
            

            totalSeconds -= finalSeconds;

            while (totalSeconds > 0)
            {
                totalSeconds -= 60;
                finalMinutes +=1;
                if (finalMinutes > 59)
                {
                    finalMinutes = 0;
                    finalHour += 1;
                }


                if (finalHour > 23)
                {
                    finalHour = 0;
                }


            }

            string hour = finalHour.ToString();
            string minutes = finalMinutes.ToString();
            string seconds = finalSeconds.ToString();

            if (finalHour < 10)
            {
                hour = $"0{finalHour}";
            }

            if (finalMinutes < 10)
            {
                minutes = $"0{finalMinutes}";
            }

            if (finalSeconds < 10)
            {
                seconds = $"0{finalSeconds}";
            }

            Console.WriteLine($"Time Arrival: {hour}:{minutes}:{seconds}");
            

        }
    }
}
