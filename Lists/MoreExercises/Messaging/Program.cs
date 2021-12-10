using System;
using System.Linq;
using System.Collections.Generic;


namespace Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            string text = Console.ReadLine();


            List<char> listElements = new List<char>();
            List<int> sumList = new List<int>();

            int currSum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                listElements = list[i].ToList();

                for (int j = 0; j < listElements.Count; j++)
                {
                    currSum += int.Parse(listElements[j].ToString());
                }
                sumList.Add(currSum);
                currSum = 0;

                if (sumList[i] <= text.Length)
                {
                    Console.Write(text[sumList[i]]);
                    text = text.Remove(sumList[i] - 1,1);
                }
                else
                {
                    int index = sumList[i] % text.Length;
                    Console.Write(text[index]);
                    text = text.Remove(index,1);
                }
            }

            Console.WriteLine();
        }
    }
}
