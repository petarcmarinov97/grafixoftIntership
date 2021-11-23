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
            List<int> qualityEachDrum = Console.ReadLine().Split().Select(int.Parse).ToList();
            string hitPower = Console.ReadLine();
            List<int> qualityCloned = qualityEachDrum.ToList();

            while (hitPower != "Hit it again, Gabsy!")
            {
                for(int i =0; i<qualityEachDrum.Count; i++)
                {
                    qualityEachDrum[i]-=int.Parse(hitPower);

                    if(qualityEachDrum[i] <= 0)
                    {
                        if(savings - (qualityCloned[i] * 3) >= 0)
                        {
                            savings -= qualityCloned[i]*3;
                            qualityEachDrum[i]=qualityCloned[i];
                        }
                        else
                        {
                            qualityCloned.RemoveAt(i);
                            qualityEachDrum.RemoveAt(i);
                            i--;
                        }
                    }
                }

                hitPower = Console.ReadLine();
            }

            Console.Write($"{string.Join(" ", qualityEachDrum)}\nGabsy has {savings:F2}lv.");
        }
    }
}