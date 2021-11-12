using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int evaluators = int.Parse(Console.ReadLine());
            Boolean isNominated = false;

            for (int i = 0; i<evaluators; i++)
            {
                string evaluatorName = Console.ReadLine();
                double evaluatorPoints = double.Parse(Console.ReadLine());
                double calculatedPoints = evaluatorName.Length * evaluatorPoints / 2;
                academyPoints += calculatedPoints;

                if (academyPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {academyPoints:F1}!");
                    isNominated = true;
                    break;
                }
            }

            if(!isNominated)
            {
                Console.WriteLine($"Sorry, {name} you need {Math.Abs(academyPoints - 1250.5):F1} more!");
            }
        }
    }
}
