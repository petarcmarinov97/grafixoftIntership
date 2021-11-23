using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TakeSkipRope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();
            List<string> nonNumbers = new List<string>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            StringBuilder result = new StringBuilder();

            numbers = input.Where(x => char.IsDigit(x))
                .Select(x => x.ToString())
                .Select(int.Parse)
                .ToList();

            nonNumbers = input.Where(x => !char.IsDigit(x))
                .Select(x => x.ToString())
                .ToList();

            takeList = numbers
                .Where((x, index) => index % 2 == 0)
                .ToList();

            skipList = numbers
                .Where((x, index) => index % 2 != 0)
                .ToList();

          
            int indexForSkip = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(nonNumbers);
                temp = temp.Skip(indexForSkip).Take(takeList[i]).ToList();
                result.Append(string.Join("", temp));
                indexForSkip += takeList[i] + skipList[i];
            }
            Console.WriteLine(result.ToString());
        }
    }
}
