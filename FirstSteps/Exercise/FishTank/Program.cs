using System;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rangeInCm = int.Parse(Console.ReadLine());
            int widthInCm = int.Parse(Console.ReadLine());
            int hightInCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double tankVolume = rangeInCm * widthInCm * hightInCm;

            double litresVolume = tankVolume / 1000;
            double takenSpace = percent / 100;
            double neededLitres = litresVolume * (1 - takenSpace);

            Console.WriteLine(neededLitres);
        }
    }
}
