using System;

namespace Sunglasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int middlePoint = n % 2 == 1 ? n / 2 + 1 : n / 2;

            string star = "*";
            string stars = new String('*', n * 2);
            string vertLines = new String('|', n);
            string otherLines = new String('/', (n * 2) - 2);
            string freeSpaces = new String(' ', n);

            string topAndBottom = stars + freeSpaces + stars;
            string otherLinesWithStars = star + otherLines + star;
            string middleLine = otherLinesWithStars + vertLines + otherLinesWithStars;

            Console.WriteLine(topAndBottom);
            for (int i = 2; i <= n - 1; i++)
            {
                if (i == middlePoint)
                {
                    Console.WriteLine(middleLine);
                }
                else
                {
                    Console.WriteLine(otherLinesWithStars + freeSpaces + otherLinesWithStars);
                }
            }
            Console.WriteLine(topAndBottom);
        }
    }
}
