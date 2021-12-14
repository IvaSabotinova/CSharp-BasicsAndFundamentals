﻿using System;

namespace T07WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double speedSecondsPerOneMeter = double.Parse(Console.ReadLine());

            double secondsWholedistance = distance * speedSecondsPerOneMeter;
            double delayNumberOfTimes = Math.Floor(distance / 15);
            double wholeDelay = delayNumberOfTimes * 12.5;
            double finalTimeInSeconds = secondsWholedistance + wholeDelay;

            if (finalTimeInSeconds < worldRecord)
            {

                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTimeInSeconds:f2} seconds.");
            }
            else
            {
                double delayWorldRecord = finalTimeInSeconds - worldRecord;
                Console.WriteLine($"No, he failed! He was {delayWorldRecord:f2} seconds slower.");
            }
                        
    }   

    }
}
