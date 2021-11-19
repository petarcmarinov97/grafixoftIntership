using System;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());
            double basketShoes = yearTax - (yearTax * 0.4);
            double basketSuit = basketShoes - (basketShoes * 0.2);
            double basketBall = basketSuit * 0.25;
            double basketAcc = basketBall * 0.20;

            double finalPrice = basketSuit + basketShoes + basketAcc + yearTax + basketBall;
            Console.WriteLine(finalPrice);

        }
    }
}
