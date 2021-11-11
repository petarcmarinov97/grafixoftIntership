using System;

namespace AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double result = 0;

            if (type == "square")
            {
              double length = double.Parse(Console.ReadLine());
                result=length * length;
             }
            else if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                result = a *b;
            }
            else if (type == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                result = Math.PI*radius*radius; 
            }
            else if(type == "triangle")
            {
                double length = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());
                result = length *(hight/2);
            }
            Console.WriteLine($"{result:F3}");
        }
    }
}
