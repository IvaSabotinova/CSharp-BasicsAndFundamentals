using System;

namespace T11CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingMachine = double.Parse(Console.ReadLine());
            double pricePerToy = double.Parse(Console.ReadLine());

            double sumEachEvenAge = 10;
            double sumEvenAge = 0;
            double moneyFromToys = 0;
            double totalMoneyCollected = 0;



            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    sumEvenAge += sumEachEvenAge;
                    sumEachEvenAge += 10;
                    sumEvenAge -= 1;
                }
                else
                {
                    moneyFromToys += pricePerToy;

                }
            }

                totalMoneyCollected = sumEvenAge + moneyFromToys;


                if (totalMoneyCollected >= priceWashingMachine)
                {
                    Console.WriteLine($"Yes! {(totalMoneyCollected - priceWashingMachine):f2}");
                }
                else
                {
                    Console.WriteLine($"No! {(priceWashingMachine - totalMoneyCollected):f2}");
                }
            

        }
    }
}
