using System;

namespace Axe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int handleRow = n + 1;
            int lastLineStars = n % 2 == 0 ? (n * 2) - 1 : (n * 2) - 2;
            int lastLineEndDashes = n % 2 == 0 ? n / 2 : n / 2 + 1;
            int dashes = n * 3;

            string dash = new string('-', dashes);
            string firstHalf = dash + "*";
            string secondHalf = "*" + new string('-', n * 5 - dashes - 2);
            string firstLine = firstHalf + secondHalf;

            //First Line
            Console.WriteLine(firstLine);

            //Middle Lines Before the Handle
            for (int i = 1; i < handleRow - 1; i++)
            {
                Console.WriteLine(firstHalf + new string('-', i) + "*" + new string('-', n * 5 - (dashes) - 2 - i));
            }

            //Handle Lines
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine(new string('*', dashes + 1) + new string('-', handleRow - 2) + "*" + new string('-', handleRow - 2));
            }
            q
            //After Handle Lines and Before the Last Line
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine(new string('-', dashes - i) + "*" + new string('-', handleRow - 2 + (i * 2)) + "*" + new string('-', handleRow - 2 - i));
            }

            //Last Line
            Console.WriteLine(new string('-', (n * 5) - lastLineStars - lastLineEndDashes) + new string('*', lastLineStars) + new string('-', lastLineEndDashes));

        }
    }
}