using System;
using System.Linq;
using System.Collections.Generic;

namespace PokemonDontGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int numberToRemove = 0;

                if (index < 0)
                {
                    numberToRemove = list[0];
                    sum += numberToRemove;
                    list[0] = list[list.Count - 1];
                }
                else if (index >= list.Count)
                {
                    numberToRemove = list[list.Count - 1];
                    sum += numberToRemove;
                    list[list.Count - 1] = list[0];
                }
                else
                {
                    numberToRemove = list[index];
                    sum += numberToRemove;
                    list.RemoveAt(index);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] <= numberToRemove)
                    {
                        list[i] += numberToRemove;
                    }
                    else if (list[i] >= numberToRemove)
                    {
                        list[i] -= numberToRemove;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
