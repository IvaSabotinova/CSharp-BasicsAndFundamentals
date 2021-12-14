using System;

namespace T01PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int basinVolume = int.Parse(Console.ReadLine());
            int p1LitresPerHour = int.Parse(Console.ReadLine());
            int p2LitresPerHour = int.Parse(Console.ReadLine());
            double hoursWorkerIsAbsent = double.Parse(Console.ReadLine());

            double p1BasinFill = p1LitresPerHour * hoursWorkerIsAbsent;
            double p2BasinFill = p2LitresPerHour * hoursWorkerIsAbsent;
            double p1P2BasinFill = p1BasinFill + p2BasinFill;
            
            
            if (p1P2BasinFill <= basinVolume)
            {
                double p1BasinFillPercent = p1BasinFill / p1P2BasinFill * 100;
                double p2BasinFillPercent = p2BasinFill / p1P2BasinFill * 100;
                double basinVolumeFilledPercent = p1P2BasinFill / basinVolume * 100;
                Console.WriteLine($"The pool is {basinVolumeFilledPercent:f2}% full. Pipe 1: {p1BasinFillPercent:f2}%. Pipe 2: {p2BasinFillPercent:f2}%.");
            }
            
            else
            {
                double basinOverflowLitres = p1P2BasinFill - basinVolume;
                Console.WriteLine($"For {hoursWorkerIsAbsent:f2} hours the pool overflows with {basinOverflowLitres:f2} liters.");
                
            }
        }
    }
}
