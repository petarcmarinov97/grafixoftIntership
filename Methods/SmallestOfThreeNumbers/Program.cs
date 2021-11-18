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

            Console.WriteLine(Program.smallestNumber(a, b, c));
        }

        static int smallestNumber(int a, int b, int c)
        {
            int [] numbers = new[] {a,b,c};
            int min = numbers.Min();
            return min;
        }
    }
}
