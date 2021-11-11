using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherCount = int.Parse(Console.ReadLine());

            double sprintShip = 3000;
            double summerAndAutumnShip = 4200;
            double winterShip = 2600;

            double bonus = 0.0;

            switch (season)
            {
                case "Spring":
                    if (fisherCount <= 6)
                    {
                        bonus = sprintShip * 0.9;
                    }
                    else if (fisherCount >= 7 && fisherCount <= 11)
                    {
                        bonus = sprintShip * 0.85;
                    }
                    else if (fisherCount > 11)
                    {
                        bonus = sprintShip * 0.75;
                    }
                    break;
                case "Summer":
                    if (fisherCount <= 6)
                    {
                        bonus = summerAndAutumnShip * 0.9;
                    }
                    else if (fisherCount >= 7 && fisherCount <= 11)
                    {
                        bonus = summerAndAutumnShip * 0.85;
                    }
                    else if (fisherCount > 11)
                    {
                        bonus = summerAndAutumnShip * 0.75;
                    }
                    break;
                case "Autumn":
                    if (fisherCount <= 6)
                    {
                        bonus = summerAndAutumnShip * 0.9;
                    }
                    else if (fisherCount >= 7 && fisherCount <= 11)
                    {
                        bonus = summerAndAutumnShip * 0.85;
                    }
                    else if (fisherCount > 11)
                    {
                        bonus = summerAndAutumnShip * 0.75;
                    }
                    break;
                case "Winter":
                    if (fisherCount <= 6)
                    {
                        bonus = winterShip * 0.9;
                    }
                    else if (fisherCount >= 7 && fisherCount <= 11)
                    {
                        bonus = winterShip * 0.85;
                    }
                    else if (fisherCount > 11)
                    {
                        bonus = winterShip * 0.75;
                    }
                    break;
                default:
                    break;
            }
            double discount = 0;

            if (fisherCount % 2 == 0 && season != "Autumn")
            {
                discount = 0.05;
            }

            double totalPrice = budget - (bonus - bonus * discount);

            if (totalPrice >= 0)
            {
                Console.WriteLine($"Yes! You have {totalPrice:F2} leva left.");
            }
            else
                Console.WriteLine($"Not enough money! You need {(totalPrice * (-1)):F2} leva.");

        }

    }
}