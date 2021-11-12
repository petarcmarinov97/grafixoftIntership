using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double nights = days - 1;
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double price;
            double priceAfterDiscount;
            double currentPrice = 0.0;
            double finalPrice;
            double percent = 0;
            double possitive = 0.25;
            double negative = 0.1;

            if (roomType == "room for one person")
            {
                price = 18.00;
                currentPrice = nights * price;
            }
            else if (roomType == "apartment")
            {
                price = 25.00;
                percent = 0.3;
                currentPrice = nights * price;

                if (days >= 10 && days <= 15)
                {
                    percent = 0.35;
                }
                else if (days > 15)
                {
                    percent = 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                price = 35.00;
                percent = 0.1;
                currentPrice = nights * price;

                if (days >= 10 && days <= 15)
                {
                    percent = 0.15;
                }
                else if (days > 15)
                {
                    percent = 0.20;
                }
            }
            priceAfterDiscount = currentPrice - currentPrice * percent;

            finalPrice = rating == "positive" 
                ? priceAfterDiscount + priceAfterDiscount * possitive 
                : priceAfterDiscount - priceAfterDiscount * negative;

            Console.WriteLine("{0:F2}", finalPrice);
        }
    }
}