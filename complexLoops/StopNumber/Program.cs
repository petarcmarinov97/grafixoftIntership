using System;
using System.Text;

namespace StopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();

            for (int i = m; i >= n; i--)
            {
                if(i % 2 == 0 && i % 3 == 0)
                {
                    if(i == s)
                    {
                        break;
                    }
                    result.Append(i);
                    result.Append(" ");
                }
            }
            Console.WriteLine(result);
        }
    }
}

