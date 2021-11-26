using System;

namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            firstNumber = GetFactorial(firstNumber);
            secondNumber = GetFactorial(secondNumber);
            double result = firstNumber / secondNumber;

            Console.WriteLine($"{result:f2}");
        }

        static double GetFactorial(double number)
        {
            double result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
