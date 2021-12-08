using System;
using System.Linq;
using System.Collections.Generic;

namespace AvarageStudentGrades
{
    internal class Program
    {
        public static Dictionary<string, List<decimal>> studentRecords = new Dictionary<string, List<decimal>>();
        public static int studentsCount;
        public static string[] data;
        public static string name;
        public static decimal grade;
        static void Main(string[] args)
        {
            studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                ReadData();
                SplitData();
                SearchForSequences();
            }

            PrintFinalData();
        }

        public static void PrintFinalData()
        {
            foreach (var kvp in studentRecords)
            {
                Console.Write($"{kvp.Key} -> ");
                Console.Write(string.Join(" ", kvp.Value.Select(x => x)));
                Console.WriteLine($" (avg: {(kvp.Value.Sum() / kvp.Value.Count()):F2})");
            }
        }
        public static void ReadData()
        {
            data = Console.ReadLine().Split().ToArray();
        }
        public static void SplitData()
        {
            name = data[0];
            grade = decimal.Parse(data[1]);
        }
        public static void SearchForSequences()
        {
            if (!studentRecords.ContainsKey(name))
            {
                studentRecords.Add(name, new List<decimal>());
            }
            studentRecords[name].Add(grade);
        }
    }
}
