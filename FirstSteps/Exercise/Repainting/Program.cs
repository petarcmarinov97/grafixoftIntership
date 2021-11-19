using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hoursWorks = int.Parse(Console.ReadLine());

            double priceNylon = (nylon + 2) * 1.50;
            double pricePaint = (paint + (paint * 0.1)) * 14.50;
            double priceThinner = thinner * 5.00;
            double fullSum = priceNylon + pricePaint + priceThinner + 0.40;
            double sumForWorkers = (fullSum * 0.3) * hoursWorks;
            double finalSum = sumForWorkers + fullSum;
            Console.WriteLine(finalSum);




        }
    }
}
