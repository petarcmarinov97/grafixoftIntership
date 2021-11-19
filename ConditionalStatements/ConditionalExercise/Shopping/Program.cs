
using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double totalVideocardPrice = videoCards * 250;

            double processorsPrice = totalVideocardPrice * 0.35;
            double totalProcessorsPrice = processors * processorsPrice;

            double ramPrice = totalVideocardPrice * 0.10;
            double totalRamPrice = ram * ramPrice;

            double result = totalVideocardPrice + totalProcessorsPrice + totalRamPrice;

            if (videoCards > processors)
            {
                result -= result * 0.15;
            }

            if(budget - result >= 0)
            {
                Console.WriteLine($"You have {(budget - result):F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(result-budget):F2} leva more! ");
            }
        }
    }
}
