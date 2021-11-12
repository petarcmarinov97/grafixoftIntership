using System;

namespace SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string shoes = "Shirt";
            string outfit = "Moccasins";

            if (temperature >= 10 && temperature <= 18)
            {
                outfit = "Shirt";
                shoes = "Moccasins";

                if(timeOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }

            }
            else if (temperature > 18 && temperature <= 24)
            {
                outfit = "Shirt";
                shoes = "Moccasins";

                if(timeOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if(temperature > 24)
            {
                if(timeOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if(timeOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if(timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
        }
    }
}
