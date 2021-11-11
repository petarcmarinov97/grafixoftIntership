using System;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string flower = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double price = 0;

            switch (flower)
            {
                case "Roses":
                    {
                        price = quantity * 5;
                        if (quantity > 80)
                        {
                            double discount = (price / 100) * 10;
                            price = price - discount;
                        }
                        break;
                    }
                case "Dahlias":
                    {
                        price = quantity * 3.8;
                        if (quantity > 90)
                        {
                            double discount = (price / 100) * 15;
                            price = price - discount;
                        }
                        break;
                    }
                case "Tulips":
                    {
                        price = quantity * 2.8;
                        if (quantity > 80)
                        {
                            double discount = (price / 100) * 15;
                            price = price - discount;
                        }
                        break;
                    }
                case "Narcissus":
                    {
                        price = quantity * 3;
                        if (quantity < 120)
                        {
                            double discount = (price / 100) * 15;
                            price = price + discount;
                        }
                        break;
                    }
                case "Gladiolus":
                    {
                        price = quantity * 2.5;
                        if (quantity < 80)
                        {
                            double discount = (price / 100) * 20;
                            price = price + discount;
                        }
                        break;
                    }
            }

            if (budget >= price)
            {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", quantity, flower, budget - price);
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0:F2} leva more.", price - budget);
            }
        }
    }
}