using System;

namespace T02SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int ownerRestDays = int.Parse(Console.ReadLine());

            int ownerWorkDays = 365 - ownerRestDays;
            int playTotalTimeInMinutes = ownerRestDays * 127 + ownerWorkDays * 63;

            if (playTotalTimeInMinutes > 30000)
            {
                int minutesAboveNorm = playTotalTimeInMinutes - 30000;
                int hoursAboveNorm = minutesAboveNorm / 60;
                int justMinutesAboveNorm = minutesAboveNorm % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hoursAboveNorm} hours and {justMinutesAboveNorm} minutes more for play");
            }
            else
            { 
            int minutesBelowNorm = 30000 - playTotalTimeInMinutes;
            int hoursBelowNorm = minutesBelowNorm / 60;
                int justMinutesBelowNorm = minutesBelowNorm % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hoursBelowNorm} hours and {justMinutesBelowNorm} minutes less for play");
        }
        }
    }
}
