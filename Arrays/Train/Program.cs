using System;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            int sum = 0; ;

            for(int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
                Console.Write(input[i] + " ");
                sum += input[i];
            }

            Console.Write("\n");
            Console.WriteLine(sum);
        }
    }
}
