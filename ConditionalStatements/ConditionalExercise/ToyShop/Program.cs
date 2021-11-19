using System;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.6;
            double dollsPrice = 3;
            double bearsPrice = 4.1;
            double minionsPrice = 8.2;
            double trucksPrice = 2;
            double price = (puzzleCount * puzzlePrice) + (dollsCount * dollsPrice) + (bearsCount * bearsPrice) + (minionsCount * minionsPrice) + (trucksCount * trucksPrice);
            double toys = puzzleCount + dollsCount + bearsCount + minionsCount + trucksCount;

            if (toys >= 50)
            {
                price = price - (price * 0.25);
            }

            price = price - (price * 0.1);

            if (price >= tripPrice)
            {
                double enoughMoney = price - tripPrice;
                Console.WriteLine($"Yes! {enoughMoney:F2} lv left.");
            }
            else
            {
                double moneyNeeded = tripPrice - price;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
        }
    }
}
