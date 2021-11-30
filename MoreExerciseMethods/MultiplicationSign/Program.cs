using System;

namespace MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            PrintSign(num1, num2, num3);
        }

        static void PrintSign(double n1, double n2, double n3)
        {
            if (n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("zero");
            }
            else if ((n1 > 0 && n2 > 0 && n3 > 0) || (n1 < 0 && n2 < 0 && n3 > 0) || (n1 < 0 && n2 > 0 && n3 < 0) || (n1 > 0 && n2 < 0 && n3 < 0))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
