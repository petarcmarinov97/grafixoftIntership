using System;

namespace House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dashCount;
            int starsCount = 1;
            int lastLineTimes = n / 2;
            string starForLastLine = new string('*', n - 2);
            string lastLine = "|" + starForLastLine + "|";

            if (n % 2 == 0)
            {
                starsCount++;
            }

            for (int i = 0; i < (n + 1) / 2; i++)
            {
                dashCount = (n - starsCount) / 2;
                Console.WriteLine(new string('-', dashCount) + new string('*', starsCount) + new string('-', dashCount));
                starsCount+=2;
            }

            for (int i = 0; i < lastLineTimes; i++)
            {
                Console.WriteLine(lastLine);
            }
        }
    }
}
