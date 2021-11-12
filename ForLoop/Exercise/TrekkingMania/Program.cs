using System;

namespace TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            double sumOfGroups = 0;
            double musalaClimbers = 0.0;
            double monblanClimbers = 0.0;
            double kilimandjaroClimbers = 0.0;
            double kSecondClimbers = 0.0;
            double everestClimbers = 0.0;

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
                else if(climbers > 40)
                {
                    everestClimbers += climbers;
                }
                sumOfGroups += climbers;
            }
                Console.WriteLine($"{(musalaClimbers / sumOfGroups * 100):F2}%");
                Console.WriteLine($"{(monblanClimbers / sumOfGroups * 100):F2}%");
                Console.WriteLine($"{(kilimandjaroClimbers / sumOfGroups * 100):F2}%");
                Console.WriteLine($"{(kSecondClimbers / sumOfGroups * 100):F2}%");
                Console.WriteLine($"{(everestClimbers / sumOfGroups * 100):F2}%");
        }
    }
}
