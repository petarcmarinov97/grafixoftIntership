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

            int constrainOne = firstList.Count > secondList.Count ? firstList[firstList.Count - 1] : secondList[0];
            int constrainTwo = firstList.Count > secondList.Count ? firstList[firstList.Count - 2] : secondList[1];

            int minNum = Math.Min(constrainOne, constrainTwo);
            int maxNum = Math.Max(constrainOne, constrainTwo);

            for(int i = 0; i<Math.Min(firstList.Count, secondList.Count); i++)
            {
                concatList.Add(firstList[i]);
                concatList.Add(secondList[secondList.Count-1-i]);
            }

            var OrderedList = concatList.Where(x => x > minNum && x < maxNum).ToList().OrderBy(x => x).ToList();                  
            Console.WriteLine(string.Join(" ", OrderedList));
        }
    }
}
