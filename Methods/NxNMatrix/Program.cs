using System;
using System.Linq;

namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            matrix(n);

        }

        static void matrix(int number)
        {
            string numberString = number.ToString();
              for (int row = 0; row < number; row++)
                {
                    for (int col = 0; col < number; col++)
                    {
                        Console.Write(number + " ");
                    }
                    Console.WriteLine();
                }
        }
    }
}
