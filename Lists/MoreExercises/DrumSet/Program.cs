using System;
using System.Linq;
using System.Collections.Generic;

namespace DrumSet_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drumQualities = Console.ReadLine().Split().Select(int.Parse).ToList();
            string hitPower = Console.ReadLine();
            List<int> qualityCloned = drumQualities.ToList();

            while (hitPower != "Hit it again, Gabsy!")
            {
                for (int i = 0; i < drumQualities.Count; i++)
                {
                    drumQualities[i] -= int.Parse(hitPower);

                    if (drumQualities[i] <= 0)
                    {
                        if (savings - (qualityCloned[i] * 3) >= 0)
                        {
                            savings -= qualityCloned[i] * 3;
                            drumQualities[i] = qualityCloned[i];
                        }
                        else
                        {
                            qualityCloned.RemoveAt(i);
                            drumQualities.RemoveAt(i);
                            i--;
                        }
                    }
                }

                hitPower = Console.ReadLine();
            }

            Console.Write($"{string.Join(" ", drumQualities)}\nGabsy has {savings:F2}lv.");
        }
    }
}