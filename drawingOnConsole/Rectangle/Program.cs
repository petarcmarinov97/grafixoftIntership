using System;
using System.Text;

namespace drawingOnConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder("$");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sb);
                sb.Append(" $");
            }
        }
    }
}
