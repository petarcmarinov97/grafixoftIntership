﻿using System;
using System.Linq;

namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    Console.Write(input[i] + " ");
                }
            }

            Console.Write(input[input.Length - 1]);
        }
    }
}
