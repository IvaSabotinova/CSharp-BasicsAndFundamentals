using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int DNALength = int.Parse(Console.ReadLine());

            int maxSequentOnesCount = -1;
            int firstIndexOfMaxSequentOnes = 4;
            int maxElementsSum = -1;
            int bestSample = 0;
            int currentSample = 0;



            int[] bestDNA = new int[DNALength];

            while (true)
            {

                string command = Console.ReadLine();
                if (command == "Clone them!")
                {
                    break;
                }

                int[] currentDNA = command.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int currentDNASequentOnesCount = 0;
                int currentDNAMaxSequentOnesCount = 0;
                int currentDNAEndIndexOfMaxSequentOnes = 0;
                int currentDNAStartIndexOfMaxSequentOnes = 0;
                int currentDNAElementsSum = -1;
                currentSample++;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentDNASequentOnesCount++;
                    }
                    else if (currentDNA[i] == 0)
                    {
                        currentDNASequentOnesCount = 0;
                    }

                    if (currentDNASequentOnesCount > currentDNAMaxSequentOnesCount)
                    {
                        currentDNAMaxSequentOnesCount = currentDNASequentOnesCount;
                        currentDNAEndIndexOfMaxSequentOnes = i;
                        currentDNAStartIndexOfMaxSequentOnes =
                            currentDNAEndIndexOfMaxSequentOnes - currentDNAMaxSequentOnesCount + 1;
                    }

                    currentDNAElementsSum = currentDNA.Sum();

                }
                

                if (currentDNAMaxSequentOnesCount > maxSequentOnesCount)
                {
                    maxSequentOnesCount = currentDNAMaxSequentOnesCount;
                    firstIndexOfMaxSequentOnes = currentDNAStartIndexOfMaxSequentOnes;
                    maxElementsSum = currentDNAElementsSum;
                    bestDNA = currentDNA;
                    bestSample = currentSample;

                }
                else if (currentDNAMaxSequentOnesCount == maxSequentOnesCount)
                {
                    if (currentDNAStartIndexOfMaxSequentOnes < firstIndexOfMaxSequentOnes)
                    {
                        firstIndexOfMaxSequentOnes = currentDNAStartIndexOfMaxSequentOnes;
                        maxElementsSum = currentDNAElementsSum;
                        bestDNA = currentDNA;
                        bestSample = currentSample;

                    }
                    else if (currentDNAStartIndexOfMaxSequentOnes == firstIndexOfMaxSequentOnes)
                    {
                        
                        if (currentDNAElementsSum > maxElementsSum)
                        {
                            maxElementsSum = currentDNAElementsSum;
                            bestDNA = currentDNA;
                            bestSample = currentSample;
                        }
                    }
                }

               
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {maxElementsSum}.");
            Console.WriteLine(String.Join(" ", bestDNA));

        }
    }
}
