using System;

namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositValue = double.Parse(Console.ReadLine());
            int monthsDeposit = int.Parse(Console.ReadLine());
            double yearPercent = double.Parse(Console.ReadLine());

            double accumulatedValue = depositValue * (yearPercent/100);
            double forOneMonth = accumulatedValue / 12;
            double finalResult = depositValue + (monthsDeposit * forOneMonth);

            Console.WriteLine(finalResult);

        }
    }
}
