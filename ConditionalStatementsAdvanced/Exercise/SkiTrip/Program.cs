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
            double price = 0.0;
            double totalPrice = 0.0;
            double totalPriceSecond = 0.0;
            double finalPrice = 0.0;
            double percent = 0.0;
            double possitive = 0.25;
            double negative = 0.1;

            if (roomType == "room for one person")
            {
                price = 18.00;
                totalPriceSecond = nights * price;

                totalPrice = rating == "positive" ? totalPriceSecond + totalPriceSecond * possitive : totalPrice = totalPriceSecond - totalPriceSecond * negative;
                Console.WriteLine("{0:F2}", totalPrice);

            }
            else if (roomType == "apartment")
            {
                price = 25.00;
                percent = 0.3;
                totalPriceSecond = nights * price;

                if (days >= 10 && days <= 15)
                {
                    percent = 0.35;
                }
                else if (days > 15)
                {
                    percent = 0.5;
                }
                totalPrice = totalPriceSecond - totalPriceSecond * percent;

                finalPrice = rating == "positive" ? totalPrice + totalPrice * possitive : totalPrice - totalPrice * negative;
                Console.WriteLine("{0:F2}", finalPrice);
            }

            else if (roomType == "president apartment")
            {
                price = 35.00;
                percent = 0.1;
                totalPriceSecond = nights * price;

                if (days >= 10 && days <= 15)
                {
                    percent = 0.15;
                }
                else if (days > 15)
                {
                    percent = 0.20;
                }
                totalPrice = totalPriceSecond - totalPriceSecond * percent;

                finalPrice = rating == "positive" ? totalPrice + totalPrice * possitive : totalPrice - totalPrice * negative;
                Console.WriteLine("{0:F2}", finalPrice);
            }
        }
    }
}