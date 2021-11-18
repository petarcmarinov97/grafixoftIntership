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

            int sum = Program.sumFromTheTwo(num1, num2);
            Console.WriteLine(substractTheThird(sum,num3));

        }
        static int sumFromTheTwo(int num1, int num2)
        {
            return num1 + num2;
        }

        static int substractTheThird(int sum, int num3)
        {
            return sum - num3;
        }
    }
}
