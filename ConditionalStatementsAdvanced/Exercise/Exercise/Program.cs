using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 0.0;

            if (type == "Premiere")
            {
                price = 12.00;
            }
            else
            {
                price = type == "Normal" ? 7.50 : 5.00;
            }

            Console.WriteLine("{0:F2} leva", price * r * c);
        }
    }
}
