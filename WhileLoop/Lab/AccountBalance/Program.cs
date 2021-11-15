using System;

namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string income = "";
            double sum = 0.0;
            income = Console.ReadLine();

            while (income != "NoMoreMoney")
            {
                double amount = Double.Parse(income);
                
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += amount;

                Console.WriteLine($"Increase: {amount:F2}");
                income = Console.ReadLine();

            }
            Console.WriteLine($"Total: {sum:F2}");
        }
    }
}
