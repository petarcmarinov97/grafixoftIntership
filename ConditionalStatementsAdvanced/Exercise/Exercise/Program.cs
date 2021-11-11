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

            else if (type == "Normal")
            {
                price = 7.50;
            }

            else if (type == "Discount")
            {
                price = 5.00;
            }

            Console.WriteLine("{0:F2} leva", price * r * c);
        }
    }
}
