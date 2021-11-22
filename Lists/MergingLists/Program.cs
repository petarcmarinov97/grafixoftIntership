using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> secondArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            MergingLists(firstArr, secondArr);
        }

        static void MergingLists(List<int> firstArr, List<int> secondArr)
        {
            int length = Math.Abs(firstArr.Count+secondArr.Count);
            List<int> finalArr = new List<int>(length);

            if (firstArr.Count <= secondArr.Count)
            {
                for(int i = 0; i < firstArr.Count; i++)
                {
                    finalArr.Add(firstArr[i]);
                    finalArr.Add(secondArr[i]);
                }
                
                for(int j = firstArr.Count; j< secondArr.Count; j++)
                {
                    finalArr.Add(secondArr[j]);
                }
            }
            else
            {
                for (int i = 0; i < secondArr.Count; i++)
                {
                    finalArr.Add(firstArr[i]);
                    finalArr.Add(secondArr[i]);
                }

                for (int j = secondArr.Count; j < firstArr.Count; j++)
                {
                    finalArr.Add(firstArr[j]);
                }
            }

            Console.WriteLine(String.Join(' ', finalArr));
        }
    }
}
