﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> specialNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int specialBombNumber = specialNumbers[0];
                int power = specialNumbers[1];

                if (numbers.Contains(specialBombNumber))
                {
                    int index = numbers.IndexOf(specialBombNumber);
                    int detonationStart = index - power;

                    for (int j = detonationStart; j < index; j++)
                    {
                        if (j < numbers.Count && j >= 0)
                        {
                            numbers.Remove(numbers[j]);
                            numbers.Insert(j, 0);
                        }
                    }

                    int detonationEnd = index + power;
                    for (int k = index + 1; k <= detonationEnd; k++)
                    {
                        if (k < numbers.Count && k >= 0)
                        {
                            numbers.Remove(numbers[k]);
                            numbers.Insert(k, 0);
                        }
                    }
                }

                numbers.Remove(specialBombNumber);
            }

            Console.WriteLine(string.Join(" ", numbers.Where(x => x != 0).Sum()));
        }
    }
}
