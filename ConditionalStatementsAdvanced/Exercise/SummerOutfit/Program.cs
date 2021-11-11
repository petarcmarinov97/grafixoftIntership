using System;

namespace SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string shoes = string.Empty;
            string outfit = string.Empty;

            if (timeOfDay == "Morning")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (temperature > 18 && temperature <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperature >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            if (timeOfDay == "Afternoon")
            {
                if (temperature >= 10 && temperature <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (temperature > 18 && temperature <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (temperature >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            if (timeOfDay == "Evening")
            {
                if (temperature >= 10)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
        }
    }
}
