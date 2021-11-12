﻿using System;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += number;
                }
                else if (i % 2 == 1)
                {
                    oddSum += number;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else if (evenSum != oddSum)
            {
                int finsum = Math.Abs(oddSum - evenSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {finsum}");
            }
        }
    }
}