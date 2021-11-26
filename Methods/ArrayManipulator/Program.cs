using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split(' ');
                if (commands[0] == "exchange")
                {
                    int splitIndex = int.Parse(commands[1]);
                    if (splitIndex < arr.Length && splitIndex >= 0)
                    {
                        ExchangeArray(arr, splitIndex);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commands[0] == "max" || commands[0] == "min")
                {
                    Console.WriteLine(GetEvenOddMaxMin(arr, commands[0], commands[1]));
                }
                else if (commands[0] == "first" || commands[0] == "last")
                {
                    int count = int.Parse(commands[1]);

                    if (count <= arr.Length)
                    {
                        Console.WriteLine("[" + GetFirstLast(GetEvenOddArray(arr, commands[2]), commands[0], count) + "]");
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", arr) + "]");
        }

        static void ExchangeArray(int[] arr, int splitIndex)
        {
            int[] exchangedArr = new int[arr.Length];
            int indexExchArr = 0;

            for (int i = splitIndex + 1; i < arr.Length; i++)
            {
                exchangedArr[indexExchArr] = arr[i];
                indexExchArr++;
            }

            for (int i = 0; i <= splitIndex; i++)
            {
                exchangedArr[indexExchArr] = arr[i];
                indexExchArr++;
            }

            Array.Copy(exchangedArr, arr, arr.Length);
        }

        static string GetEvenOddMaxMin(int[] arr, string maxMin, string evenOdd)
        {
            int index = -1;
            int max = int.MinValue;
            int min = int.MaxValue;
            int resultFromModDiv = 0;
            string result = string.Empty;

            if (evenOdd == "odd")
            {
                resultFromModDiv = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == resultFromModDiv && maxMin == "min" && arr[i] <= min)
                {
                    index = i;
                    min = arr[i];
                }
                else if (arr[i] % 2 == resultFromModDiv && maxMin == "max" && arr[i] >= max)
                {
                    index = i;
                    max = arr[i];
                }
            }

            if (index >= 0)
            {
                result = index.ToString();
            }
            else
            {
                result = "No matches";
            }

            return result;
        }

        static int[] GetEvenOddArray(int[] arr, string evenOdd)
        {
            int[] evenOrOdd = new int[arr.Length];
            int index = 0;
            int resultFromModDiv = 0;

            if (evenOdd == "odd")
            {
                resultFromModDiv = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == resultFromModDiv)
                {
                    evenOrOdd[index] = arr[i];
                    index++;
                }
            }

            arr = new int[index];
            Array.Copy(evenOrOdd, arr, index);
            return arr;
        }

        static string GetFirstLast(int[] arr, string firstLast, int count)
        {
            int[] newArr = new int[arr.Length];
            int index = 0;

            if (firstLast == "first")
            {
                for (int i = 0; i < count && i < arr.Length; i++)
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }
            else if (firstLast == "last")
            {
                if (count > arr.Length)
                {
                    count = arr.Length;
                }
                for (int i = arr.Length - count; i < arr.Length; i++)
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }

            arr = new int[index];
            Array.Copy(newArr, arr, index);
            return string.Join(", ", arr);
        }
    }
}