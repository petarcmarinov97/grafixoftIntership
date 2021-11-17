using System;
using System.Linq;

namespace ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            string string1 = "";
            string string2 = "";

            for (int i = 0; i < n; i++)
            {
                //Reading the line of two values and spliting them by ' '
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i % 2 == 1)
                {
                    string2 += input[0].ToString() + " ";
                    string1 += input[1].ToString() + " ";
                }
                else
                {
                    string2 += input[1].ToString() + " ";
                    string1 += input[0].ToString() + " ";
                }
            }

            Console.WriteLine(string1);
            Console.WriteLine(string2);
        }
    }
}
