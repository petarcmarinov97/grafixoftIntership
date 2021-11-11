using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string typeOfVacantion = "";
            double sum = 0;


            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    sum = budget / 100 * 30;
                    typeOfVacantion = "Camp";
                }
                if (season == "winter")
                {
                    sum = budget / 100 * 70;
                    typeOfVacantion = "Hotel";
                }
            }
            if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    sum = budget / 100 * 40;
                }
                if (season == "summer")
                {
                    typeOfVacantion = "Camp";
                }
                if (season == "winter")
                {
                    sum = budget / 100 * 80;
                    typeOfVacantion = "Hotel";
                }
            }
            if (budget > 1000)
            {
                destination = "Europe";
                if (season == "summer" || season == "winter")
                {
                    sum = budget / 100 * 90;
                    typeOfVacantion = "Hotel";
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfVacantion} - {sum:F2}");
        }
    }
}
