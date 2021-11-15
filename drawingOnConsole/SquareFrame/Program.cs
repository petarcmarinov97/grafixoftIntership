using System;
using System.Text;
namespace SquareFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder("-");

            if (n > 2)
            {
                for (int i = 1; i < n - 2; i++)
                {
                    sb.Append(" -");
                }
                for (int i = 1; i <= n; i++)
                {
                    if (i == 1 || i == n)
                    {
                        Console.WriteLine("+ {0} +", sb);
                    }
                    else
                    {
                        Console.WriteLine("| {0} |", sb);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("+ +");
                }
            }
        }
    }
}
