using System;

namespace Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = n;

            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int trirdDigit = number % 10;
            
            for (int i = 1; i <= firstDigit + secondDigit; i++)
            {
                Console.WriteLine();

                for (int j = 1; j <= firstDigit + trirdDigit; j++)
                {
                    if (n % 5 == 0)
                    {
                        n -= firstDigit;
                    }
                    else if (n % 3 == 0)
                    {
                        n -= secondDigit;
                    }
                    else
                    {
                        n += trirdDigit;
                    }

                    Console.Write(n + " ");
                }
            }
        }
    }
}
