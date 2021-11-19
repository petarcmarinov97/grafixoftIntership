using System;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double rangeM = double.Parse(Console.ReadLine());
            double timeSec = double.Parse(Console.ReadLine());

            double rangeToSwim = rangeM * timeSec;

            double fullSecs = Math.Floor(rangeM / 15) * 12.5;
            double fullTime = rangeToSwim + fullSecs;

            if (record > fullTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {fullTime:F2} seconds.");
            }
            else
            {
                double notEnough = fullTime - record;
                Console.WriteLine($"No, he failed! He was {notEnough:F2} seconds slower.");
            }
            }
    }
}
