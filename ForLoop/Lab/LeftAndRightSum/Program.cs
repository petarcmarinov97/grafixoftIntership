
using System;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;

            for (int i = 0; i < n; i++)
            {
                int numberOne = int.Parse(Console.ReadLine());
                left += numberOne;
            }

            for (int i = 0; i < n; i++)
            {
                int numberSecond = int.Parse(Console.ReadLine());
                right += numberSecond;
            }

            Console.WriteLine(left == right ? ($"Yes, sum = {left}") : ($"No, diff = {Math.Abs(left - right)}"));
        }
    }
}