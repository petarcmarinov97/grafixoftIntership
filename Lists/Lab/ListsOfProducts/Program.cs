using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            PrintProducts(finalArr);
        }

        static void PrintProducts(List<string> finalArr)
        {
            List<string> sortedProducts = finalArr;
            sortedProducts.Sort();

            for (int i = 0; i < sortedProducts.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{sortedProducts[i]}");
            }
        }
    }
}
