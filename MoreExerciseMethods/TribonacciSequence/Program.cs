using System;

namespace TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTribonaci(number);
        }

        static void PrintTribonaci(int number)
        {
            int n1 = 1;
            int n2 = 1;
            int n3 = 2;
            int nextTerm;

            for(int i=1;i<=number; i++)
            {
                Console.Write(n1 + " ");
                nextTerm = n1 + n2 + n3;
                n1 = n2;
                n2 = n3;
                n3 = nextTerm;
            }
        }
    }
}
