using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> finalArr = new List<string>();

            for (int i = 0; i < number; i++)
            {
                finalArr.Add(Console.ReadLine());
            }

            SortedProducts(finalArr);
        }

        static void SortedProducts(List<string> finalArr)
        {
            finalArr.Sort();

            for (int i = 0; i < finalArr.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{finalArr[i]}");
            }
        }
    }
}
