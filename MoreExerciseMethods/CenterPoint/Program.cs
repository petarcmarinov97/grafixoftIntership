using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double distanceFirstPoint = GetClosestDistance(x1, y1);
            double disttanceSecondPoint = GetClosestDistance(x2, y2);

            Console.WriteLine(distanceFirstPoint < disttanceSecondPoint ? $"({x1}, {y1})" : $"({x2}, {y2})");
        }

        static double GetClosestDistance(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}