using System;

namespace GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int mutesCount = int.Parse(Console.ReadLine());
            double suitPrice = double.Parse(Console.ReadLine());

            double decorPrice = 0.10 * movieBudget;
            double totalSuitPrice = suitPrice * mutesCount;

            if (mutesCount > 150)
            {
                totalSuitPrice -= 0.10 * totalSuitPrice;
            }

            double totalMoney = totalSuitPrice + decorPrice;
            double moneyLeft = movieBudget - totalMoney;

            if (totalMoney > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(moneyLeft):F2} leva more.");
            }
            else if (totalMoney <= movieBudget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
        }
    }
}
