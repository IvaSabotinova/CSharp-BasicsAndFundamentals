using System;

namespace T08PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsNumber = int.Parse(Console.ReadLine());
            int otherAnimals = int.Parse(Console.ReadLine());

            const double dogFoodPrice = 2.50;
            const double otherAnimalsFoodPrice = 4.00;
            double totalPrice = dogsNumber * dogFoodPrice + otherAnimals * otherAnimalsFoodPrice;
            Console.WriteLine($"{totalPrice} lv.");
        }
    }
}
