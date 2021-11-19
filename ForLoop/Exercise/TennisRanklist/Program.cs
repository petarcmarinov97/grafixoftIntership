using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int pointsAtStart = int.Parse(Console.ReadLine());
            string stage = "";
            int points = 0;
            double average = 0;
            double percent = 0;
            double wonTournaments = 0.0;

            points = pointsAtStart;

            for (int i = 0; i < numberOfTournaments; i++)
            {
                stage = Console.ReadLine();

                if (stage == "F")
                {
                    points += 1200;
                }
                else if (stage == "W")
                {
                    points += 2000;
                    wonTournaments++;
                }
                else if (stage == "SF")
                {
                    points += 720;
                }
            }

            average = (points - pointsAtStart) / numberOfTournaments;
            percent = (wonTournaments / numberOfTournaments) * 100;

            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percent:f2}%");

        }
    }
}