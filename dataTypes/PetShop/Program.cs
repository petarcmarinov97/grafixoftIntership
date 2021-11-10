using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int dogFoodCount = int.Parse(Console.ReadLine());
           int catFoodCount = int.Parse(Console.ReadLine());

            double finalPriceDog = dogFoodCount * 2.50;
            int finalPriceCat = catFoodCount * 4;
            Console.WriteLine(finalPriceCat + finalPriceDog + " lv.");
        }
    }
}
