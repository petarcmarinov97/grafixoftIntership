using System;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            decimal nights = decimal.Parse(Console.ReadLine());

            decimal studioMO = 50m;
            decimal ApartmentMO = 65m;
            decimal studioJniS = 75.20m;
            decimal ApartmentJniS = 68.70m;
            decimal studioJA = 76m;
            decimal ApartmentJa = 77m;
            decimal priceStudio = 0m;
            decimal priceApartment = 0m;

            if (month == "May" || month == "October")
            {
                if (nights <= 7)
                {
                    priceStudio = studioMO;
                    priceApartment = ApartmentMO;
                }
                else if (nights > 7 && nights <= 14)
                {
                    priceStudio = studioMO * 0.95m;
                    priceApartment = ApartmentMO;
                }
                else if (nights > 14)
                {
                    priceStudio = studioMO * 0.70m;
                    priceApartment = ApartmentMO * 0.9m;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights >= 15)
                {
                    priceStudio = studioJniS * 0.80m;
                    priceApartment = ApartmentJniS * 0.9m;
                }
                else if (nights < 15)
                {
                    priceStudio = studioJniS;
                    priceApartment = ApartmentJniS;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights >= 15)
                {
                    priceStudio = studioJA;
                    priceApartment = ApartmentJa * 0.90m;
                }
                else if (nights < 15)
                {
                    priceStudio = studioJA;
                    priceApartment = ApartmentJa;
                }
            }


            Console.WriteLine($"Apartment: {(priceApartment * nights):F2} lv.");
            Console.WriteLine($"Studio: {(priceStudio * nights):F2} lv.");
        }
    }
}