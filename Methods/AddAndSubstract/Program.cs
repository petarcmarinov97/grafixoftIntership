using System;

namespace AddAndSubstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = Program.GetSum(num1, num2);
            Console.WriteLine(SubstractTheThird(sum, num3));

        }
        static int GetSum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int SubstractTheThird(int sum, int num3)
        {
            return sum - num3;
        }
    }
}
