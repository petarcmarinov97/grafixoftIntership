using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0.0;
            double totalPrice = 0.0;
            double totalPrice2 = 0.0;
            double percent = 0.0;

            if (roomType == "room for one person")
            {
                price = 18.00;
                if (rating == "positive")
                {
                    totalPrice = (days - 1) * price + (days - 1) * price * 0.25;
                    Console.WriteLine("{0:F2}", totalPrice);
                }

                else if (rating == "negative")


                {
                    totalPrice = (days - 1) * price - (days - 1) * price * 0.10;
                    Console.WriteLine("{0:F2}", totalPrice);
                }

            }
            else if (roomType == "apartment")
            {
                price = 25.00;
                if (rating == "positive")
                {
                    percent = 0.3;

                    if (days >= 10 && days <= 15)
                    {
                        percent = 0.35;
                    }
                    else if (days > 15)
                    {
                        percent = 0.5;
                    }

                    totalPrice2 = (days - 1) * price;
                    totalPrice = totalPrice2 - totalPrice2 * percent;
                    Console.WriteLine("{0:F2}", (totalPrice + totalPrice * 0.25));
                }
                else if (rating == "negative")
                {
                    percent = 0.3;
                    
                    if (days >= 10 && days <= 15)
                    {
                        percent = 0.35;
                    }
                    else if (days > 15)
                    {
                        percent = 0.5;
                    }

                    totalPrice2 = (days - 1) * price; totalPrice = totalPrice2 - totalPrice2 * percent;
                    Console.WriteLine("{0:F2}", (totalPrice - totalPrice * 0.10));
                }

            }

            else if (roomType == "president apartment")
            {
                price = 35.00;
                if (rating == "positive")
                {
                    if (days < 10)
                    {
                        totalPrice2 = (days - 1) * price; totalPrice = totalPrice2 - totalPrice2 * 0.10;
                        Console.WriteLine("{0:F2}", (totalPrice + totalPrice * 0.25));
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice2 = (days - 1) * price; totalPrice = totalPrice2 - totalPrice2 * 0.15;
                        Console.WriteLine("{0:F2}", (totalPrice + totalPrice * 0.25));
                    }
                    else if (days > 15)
                    {
                        totalPrice2 = (days - 1) * price; totalPrice = totalPrice2 - totalPrice2 * 0.20;
                        Console.WriteLine("{0:F2}", (totalPrice + totalPrice * 0.25));
                    }
                }
                else if (rating == "negative")
                {
                    if (days < 10)
                    {
                        totalPrice2 = (days - 1) * price; totalPrice = totalPrice2 - totalPrice2 * 0.10;
                        Console.WriteLine("{0:F2}", (totalPrice - totalPrice * 0.10));
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice2 = (days - 1) * price; totalPrice = totalPrice2 - totalPrice2 * 0.15;
                        Console.WriteLine("{0:F2}", (totalPrice - totalPrice * 0.10));
                    }
                    else if (days > 15)
                    {
                        totalPrice2 = (days - 1) * price; totalPrice = totalPrice2 - totalPrice2 * 0.20;
                        Console.WriteLine("{0:F2}", (totalPrice - totalPrice * 0.10));
                    }
                }
            }
        }
    }
}