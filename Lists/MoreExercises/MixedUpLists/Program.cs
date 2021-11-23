using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> concatList = new List<int>();

            int lengthConcatList = Math.Min(firstList.Count, secondList.Count) * 2;

            int constrainOne = 0;
            int constrainTwo = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int k = secondList.Count - 1; k >= 0; k--)
                {
                    concatList.Add(firstList[i]);
                    concatList.Add(secondList[k]);
                    i = i + 1;

                    if (concatList.Count == lengthConcatList)
                    {
                        break;
                    }
                }
                if (concatList.Count == lengthConcatList)
                {
                    break;
                }
            }

            if (firstList.Count > secondList.Count)
            {
                constrainOne = firstList[firstList.Count - 1];
                constrainTwo = firstList[firstList.Count - 2];
            }

            else if (secondList.Count > firstList.Count)
            {
                constrainOne = secondList[0];
                constrainTwo = secondList[1];
            }

            int minNum = Math.Min(constrainOne, constrainTwo);
            int maxNum = Math.Max(constrainOne, constrainTwo);

            var listResult = concatList.Where(x => x > minNum && x < maxNum).ToList();
            var OrderedList = listResult.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", OrderedList));
        }
    }
}
