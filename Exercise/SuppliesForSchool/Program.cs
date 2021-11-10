using System;

namespace SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pensCount = int.Parse(Console.ReadLine());
            int markersCount = int.Parse(Console.ReadLine());
            int litresForDesk = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double pensPackage = pensCount * 5.80;
            double markersPackage = markersCount * 7.20;
            double deskCleaningPackage = litresForDesk * 1.20;
            double price = pensPackage + markersPackage + deskCleaningPackage;

            double finalPrice = price - (price * percentDiscount / 100);

            Console.WriteLine(finalPrice);
        }
    }
}
