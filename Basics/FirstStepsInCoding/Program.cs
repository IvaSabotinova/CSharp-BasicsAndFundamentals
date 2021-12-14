using System;

namespace T09YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaSqM = double.Parse(Console.ReadLine());
            const double pricePerSqM = 7.61;
            double finalPrice = areaSqM * pricePerSqM * 0.82;
            double discount = areaSqM * pricePerSqM * 0.18;
            Console.WriteLine($"The final price is: {finalPrice:f2} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
