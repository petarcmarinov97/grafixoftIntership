using System;

namespace LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            double episode = int.Parse(Console.ReadLine());
            double breakTime = int.Parse(Console.ReadLine());

            double lunch = breakTime / 8;
            double rest = breakTime / 4;

            double time = breakTime - lunch - rest;

            if (time >= episode)
            {
                Console.WriteLine($"You have enough time to watch {title} and left with {Math.Ceiling(time - episode)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {title}, you need {Math.Ceiling(episode - time)} more minutes.");
            }

        }
    }
}
