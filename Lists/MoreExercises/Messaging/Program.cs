using System;
using System.Linq;
using System.Collections.Generic;


namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            List<char> charText = Console.ReadLine().ToList();

            List<char> listElements = new List<char>();
            List<int> sumList = new List<int>();

            int currSum =0;

            for(int i =0; i<list.Count; i++)
            {
                listElements=list[i].ToList();

                for(int j =0; j<listElements.Count; j++)
                {
                    currSum+=int.Parse(listElements[j].ToString());
                }
                sumList.Add(currSum);
                currSum = 0;

                if(sumList[i] <= charText.Count)
                {
                    Console.Write(charText[sumList[i]]);
                    charText.RemoveAt(sumList[i]-1);
                }
                else
                {
                    int index = sumList[i] % charText.Count;
                    Console.Write(charText[index]);
                    charText.RemoveAt(index);
                }
            }

            Console.WriteLine();
        }
    }
}
