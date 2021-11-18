using System;

namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            TopNumber(input);
        }

        static void TopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (HasOddDigits(i) && isDivisible(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool HasOddDigits(int number)
        {
            while (number > 0)
            {
                if ((number % 10) % 2 == 1)
                {
                    return true;

                }
                number /= 10;
            }
            return false;

        }
        static bool isDivisible(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

