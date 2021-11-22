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

            GaussTrick(numbers);

            static void GaussTrick(List<int> numbers)
            {
                List<int> numbers2 = new List<int>();
                int middlenumber;
                if (numbers.Count % 2 == 0)
                {
                    for (int i = 0; i < numbers.Count / 2 + 1; i++)
                    {
                        numbers2.Add(numbers[0] + numbers[numbers.Count - 1]);
                        numbers.RemoveAt(i);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }
                else
                {
                    middlenumber = numbers[numbers.Count / 2];

                    for (int i = 0; i < numbers.Count / 2; i++)
                    {
                        numbers2.Add(numbers[0] + numbers[numbers.Count - 1]);
                        numbers.RemoveAt(i);
                        numbers.RemoveAt(numbers.Count - 1);
                        i = -1;
                    }
                    numbers2.Add(middlenumber);
                }

                Console.WriteLine(String.Join(' ', numbers2));
            }
        }
    }
}
