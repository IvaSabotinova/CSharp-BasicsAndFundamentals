using System;

namespace T02MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecordSec = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double georgeTimeSecPerMeter = double.Parse(Console.ReadLine());

            double slopeDelaySec = Math.Floor(distance / 50) * 30;

            double georgeTime = distance * georgeTimeSecPerMeter + slopeDelaySec;

            if (georgeTime < worldRecordSec)
            {
                Console.WriteLine($"Yes! The new record is {georgeTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(georgeTime - worldRecordSec):f2} seconds slower.");
            }

        }
    }
}
