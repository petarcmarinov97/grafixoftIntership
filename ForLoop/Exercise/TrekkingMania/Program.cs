using System;

namespace TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            int sumOfGroups = 0;
            int musalaClimbers = 0;
            int monblanClimbers = 0;
            int kilimandjaroClimbers = 0;
            int kSecondClimbers = 0;
            int everestClimbers = 0;

            for (int i = 0; i < groupCount; i++)
            {
                int climbers = int.Parse(Console.ReadLine());

                if (climbers <= 5)
                {
                    musalaClimbers += climbers;
                }
                else if (climbers > 5 && climbers <= 12)
                {
                    monblanClimbers += climbers;
                }
                else if (climbers > 12 && climbers <= 25)
                {
                    kilimandjaroClimbers += climbers;
                }
                else if (climbers > 25 && climbers <= 40)
                {
                    kSecondClimbers += climbers;
                }
                else if (climbers > 40)
                {
                    everestClimbers += climbers;
                }
                sumOfGroups += climbers;
            }

            Console.WriteLine($"{(1.00*musalaClimbers / sumOfGroups * 100):F2}%");
            Console.WriteLine($"{(1.00 * monblanClimbers / sumOfGroups * 100):F2}%");
            Console.WriteLine($"{(1.00 * kilimandjaroClimbers / sumOfGroups * 100):F2}%");
            Console.WriteLine($"{(1.00 * kSecondClimbers / sumOfGroups * 100):F2}%");
            Console.WriteLine($"{(1.00 * everestClimbers / sumOfGroups * 100):F2}%");
        }
    }
}
