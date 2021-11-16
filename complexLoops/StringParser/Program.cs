using System;
using System.Data;

namespace StringParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var result = new DataTable().Compute(input, null);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        }
    }
}