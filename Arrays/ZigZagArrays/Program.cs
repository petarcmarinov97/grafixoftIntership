using System;
using System.Linq;
using System.Text;

namespace ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            StringBuilder string1 = new StringBuilder("");
            StringBuilder string2 = new StringBuilder("");

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i % 2 == 1)
                {
                    string2.Append(input[0].ToString() + " ");
                    string1.Append(input[1].ToString() + " ");
                }
                else
                {
                    string2.Append(input[1].ToString() + " ");
                    string1.Append(input[0].ToString() + " ");
                }
            }

            Console.Write(string1 + "\n" + string2);
        }
    }
}
