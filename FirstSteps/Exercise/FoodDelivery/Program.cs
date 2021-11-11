using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceDelivery = 2.50;
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegeterianMenus = int.Parse(Console.ReadLine());

            double chickenMenusPrice = chickenMenus * 10.35;
            double fishMenusPrice = fishMenus * 12.40;
            double vegeterianMenusPrice = vegeterianMenus * 8.15;

            double fullSumWithoutDelivery = chickenMenusPrice + fishMenusPrice + vegeterianMenusPrice;
            double dessert = fullSumWithoutDelivery * 0.2;

            double finalPrice = fullSumWithoutDelivery + dessert + priceDelivery;

            Console.WriteLine(finalPrice);

        }
    }
}
