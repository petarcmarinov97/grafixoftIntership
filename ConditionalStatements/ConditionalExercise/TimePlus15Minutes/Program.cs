using System;

namespace TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = 15 + minutes;

            if (minutes >= 60)
            {
                minutes = minutes % 60;
                hours += 1;
            }

            if (hours >= 24)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:D2}", hours, minutes);

        }
    }
}
