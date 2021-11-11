using System;

namespace WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            int startOftheDay = 10;
            int endOftheDay = 18;

            if (hour >= startOftheDay && hour <= endOftheDay)
            {
                if (day != "Sunday")
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
