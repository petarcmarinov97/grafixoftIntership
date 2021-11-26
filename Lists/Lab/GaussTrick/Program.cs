using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            ApplyGaussTrick(numbers);
        }

        static void ApplyGaussTrick(List<int> numbers)
        {
            List<int> numbers2 = new List<int>();

            while (numbers.Count > 0)
            {
                if (numbers.Count != 1)
                {
                    numbers2.Add(numbers[0] + numbers[numbers.Count - 1]);
                    numbers.RemoveAt(0);
                    numbers.RemoveAt(numbers.Count - 1);
                }
                else
                {
                    numbers2.Add(numbers[0]);
                    numbers.RemoveAt(0);
                }
            }

            Console.WriteLine(String.Join(' ', numbers2));
        }
    }
}
