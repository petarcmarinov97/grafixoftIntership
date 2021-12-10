using System;
using System.Linq;

namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMin(GetMin(a, b),c));
        }

        static int GetMin(int a, int b)
        {
            return Math.Min(a, b);
        }
    }
}
