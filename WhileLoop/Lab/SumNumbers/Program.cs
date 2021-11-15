using System;

namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumTarget = int.Parse(Console.ReadLine());
            int sum = 0;
            int input = 0;
            while(sumTarget > sum)
            {
                input = int.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}
