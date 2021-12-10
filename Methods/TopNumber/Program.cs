using System;

namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintTopNumber(input);
        }

        static void PrintTopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (HasOddDigits(i) && IsDivisibleByEight(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool HasOddDigits(int number)
        {
            int newNumber = number;

            while (newNumber > 0)
            {
                if ((newNumber % 10) % 2 == 1)
                {
                    return true;
                }

                newNumber /= 10;
            }
            return false;

        }
        static bool IsDivisibleByEight(int number)
        {
            int sum = 0;
            int newNumber = number;
            while (newNumber > 0)
            {
                sum += newNumber % 10;
                newNumber /= 10;
            }
            return sum % 8 == 0;
        }
    }
}

