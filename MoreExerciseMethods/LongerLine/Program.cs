using System;

namespace LongerLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongestLine(x1,y1,x2,y2,x3,y3,x4,y4);

        }

        static void LongestLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            double firstLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double secondLine = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

            if(firstLine > secondLine)
            {
                ClosestToZero(x1, y1, x2, y2);
            }
            else
            {
                ClosestToZero(x3, y3, x4, y4);
            }
        }

        static void ClosestToZero(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(Math.Abs(x1),2) + Math.Pow(Math.Abs(y1), 2));
            double second = Math.Sqrt(Math.Pow(Math.Abs(x2), 2) + Math.Pow(Math.Abs(y2), 2));

            if (first > second)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }
        
    }
}
