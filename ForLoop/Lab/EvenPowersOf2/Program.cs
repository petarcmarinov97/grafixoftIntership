using System;

namespace EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                double result = Math.Pow(2, i);
                if (i % 2 == 0)
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}
