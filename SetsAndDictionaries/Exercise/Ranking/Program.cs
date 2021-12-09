using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Program
    {
        public static string firstInput;
        public static string secondInput;
        public static string contest;
        public static string password;
        public static string user;
        public static double points;

        public static Dictionary<string, string> contestCollection = new Dictionary<string, string>();
        public static Dictionary<string, Dictionary<string, double>> submissions = new Dictionary<string, Dictionary<string, double>>();
        public static Dictionary<string, double> totalPointsCollection = new Dictionary<string, double>();
        static void Main(string[] args)
        {
            while ((firstInput = Console.ReadLine()) != "end of contests")
            {
                SplitTheArguments();
                AddContestIntoTheCollection();
            }

            while ((secondInput = Console.ReadLine()) != "end of submissions")
            {
                SplitSubbmitionArguments();
                TryToSubmit();
            }

            RankCandidatesInterns();
        }

        static void SplitTheArguments()
        {
            string[] arguments = firstInput.Split(":").ToArray();
            contest = arguments[0];
            password = arguments[1];
        }
        static void SplitSubbmitionArguments()
        {
            string[] argumentsOfSubmission = secondInput.Split("=>");

            contest = argumentsOfSubmission[0];
            password = argumentsOfSubmission[1];
            user = argumentsOfSubmission[2];
            points = double.Parse(argumentsOfSubmission[3]);
        }
        static void AddContestIntoTheCollection()
        {
            contestCollection.Add(contest, password);
        }
        static void TryToSubmit()
        {
            if (contestCollection.ContainsKey(contest) && contestCollection.ContainsValue(password))
            {
                if (!submissions.ContainsKey(user))
                {
                    AddNewUser();
                }
                else
                {
                    CalculatePoints();
                }
            }
        }
        static void AddNewUser()
        {
            submissions.Add(user, new Dictionary<string, double>());
            totalPointsCollection.Add(user, points);
            submissions[user].Add(contest, points);
        }
        static void CalculatePoints()
        {
            if (submissions[user].ContainsKey(contest))
            {
                if (submissions[user][contest] < points)
                {
                    submissions[user][contest] = points;
                }
            }
            else
            {
                submissions[user].Add(contest, points);
                totalPointsCollection[user] += points;
            }
        }
        static void RankCandidatesInterns()
        {
            SumUserPoints();
            PrintTheBestCandidate();
            Console.WriteLine("Ranking:");
            PrintStudentsByDescendingOrder();
        }
        static void SumUserPoints()
        {
            foreach (var kvp in submissions)
            {
                totalPointsCollection[kvp.Key] = kvp.Value.Values.Sum();
            }
        }
        static void PrintTheBestCandidate()
        {
            var bestPoint = totalPointsCollection.Values.Max();

            foreach (var kvp in totalPointsCollection)
            {
                if (kvp.Value == bestPoint)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                }
            }
        }
        static void PrintStudentsByDescendingOrder()
        {
            foreach (var name in submissions.OrderBy(x => x.Key))
            {
                Console.WriteLine(name.Key);
                foreach (var contestAndPoints in name.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestAndPoints.Key} -> {contestAndPoints.Value}");
                }
            }
        }
    }
}