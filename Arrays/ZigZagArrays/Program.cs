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

            for (int i = 0; i < n; i++)
            {
                //Reading the line of two values and spliting them by ' '
                int [] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


                if (i % 2 == 1)
                {
                    arr2[i] = input[0];
                    arr1[i] = input[1];
                }
                else
                {
                    arr2[i] = input[1];
                    arr1[i] = input[0];
                }
               
            }

            //Printing the arrays
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
}
