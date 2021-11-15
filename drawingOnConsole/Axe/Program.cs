using System;

namespace Axe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = n % 2 == 1 ? (n * 2) - 1 : n * 2;
            int handleRow = n + 1;

            int dashes = n * 3;
            string dash = new string('-', dashes);
            string firstHalf = dash + "**";
            string secondHalf = new string('-', n * 5 - dashes - 2);
            string firstLine = firstHalf + secondHalf;
            Console.WriteLine(firstLine);

        }
    }
}
