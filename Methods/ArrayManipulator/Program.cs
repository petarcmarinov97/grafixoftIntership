using System;
using System.Linq;
using System.Collections.Generic;

namespace ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split(' ');
                if (commands[0] == "exchange")
                {
                    int splitIndex = int.Parse(commands[1]);
                    if (splitIndex < arr.Length && splitIndex >= 0)
                    {
                        arr = ExchangeArray(arr, splitIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commands[0] == "max")
                {
                    PrintTheMaxOddOrEvenNumber(arr, commands[1]);
                }
                else if (commands[0] == "min")
                {
                    PrintTheMinOddOrEvenNumber(arr, commands[1]);
                }
                else if (commands[0] == "first")
                {
                    PrintTheFirstOddOrEvenNumbersInArray(arr, int.Parse(commands[1]), commands[2]);
                }
                else if (commands[0] == "last")
                {
                    PrintTheLastNOddOrEvenNumbersInArray(arr, int.Parse(commands[1]), commands[2]);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        static int[] ExchangeArray(int[] arr, int splitIndex)
        {
            int[] newarr = new int[arr.Length];
            int n = splitIndex + 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (n >= arr.Length)
                {
                    n = 0;
                }
                newarr[i] = arr[n];
                n++;
            }
            return newarr;
        }

        static void PrintTheMaxOddOrEvenNumber(int[] numbers, string evenOdd)
        {
            int moddifier = evenOdd == "odd" ? 1 : 0;

            if (numbers.Any(x => x % 2 == moddifier))
            {
                var maxOdd = numbers.Where(x => x % 2 == moddifier).Max();
                var indexMax = numbers.ToList().LastIndexOf(maxOdd);

                Console.WriteLine(indexMax);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void PrintTheMinOddOrEvenNumber(int[] numbers, string evenOdd)
        {
            int moddifier = evenOdd == "odd" ? 1 : 0;

            if (numbers.Any(x => x % 2 == moddifier))
            {
                int minOdd = numbers.Where(x => x % 2 == moddifier).Min();
                int indexMin = numbers.ToList().LastIndexOf(minOdd);

                Console.WriteLine(indexMin);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        static void PrintTheFirstOddOrEvenNumbersInArray(int[] numbers, int count, string evenOdd)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> sequence = new List<int>();
            int moddifier = evenOdd == "odd" ? 1 : 0;

            if (numbers.Any(x => x % 2 == moddifier))
            {
                sequence = numbers.Where(x => x % 2 == moddifier).ToList();
            }

            Console.WriteLine($"[{String.Join(", ", sequence.Take(Math.Min(count, sequence.Count)))}]");
        }

        static void PrintTheLastNOddOrEvenNumbersInArray(int[] numbers, int count, string evenOdd)
        {
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> sequence = new List<int>();
            int moddifier = evenOdd == "odd" ? 1 : 0;

            if (numbers.Any(x => x % 2 == moddifier))
            {
                sequence = numbers.Where(x => x % 2 == moddifier).ToList();
            }

            Console.WriteLine($"[{String.Join(", ", sequence.TakeLast(Math.Min(count, sequence.Count)))}]");
        }
    }
}
