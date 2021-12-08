using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParty
{
    internal class Program
    {
        public static HashSet<string> regularGuests = new HashSet<string>();
        public static HashSet<string> VIPGuests = new HashSet<string>();
        public static string currentGuest;
        public static string arrivingGuest = string.Empty;
        static void Main(string[] args)
        {
            while ((currentGuest = Console.ReadLine()) != "END")
            {
                RecognisedTheGuest();

                if (currentGuest == "PARTY")
                {
                    MeetTheGuests();
                    break;
                }
            }

            PrintMissingGuests();
        }

        public static void RecognisedTheGuest()
        {
            if (!Char.IsDigit(currentGuest[0]) && currentGuest != "PARTY")
            {
                regularGuests.Add(currentGuest);
            }
            else if (Char.IsDigit(currentGuest[0]) && currentGuest != "PARTY")
            {
                VIPGuests.Add(currentGuest);
            }
        }

        public static void MeetTheGuests()
        {
            while ((arrivingGuest = Console.ReadLine()) != "END")
            {
                CheckForSequences();
            }
        }
        public static void CheckForSequences()
        {
            if (regularGuests.Contains(arrivingGuest))
            {
                regularGuests.Remove(arrivingGuest);
            }
            if (VIPGuests.Contains(arrivingGuest))
            {
                VIPGuests.Remove(arrivingGuest);
            }
        }

        public static void PrintMissingGuests()
        {
            Console.WriteLine($"{regularGuests.Count + VIPGuests.Count}");
            foreach (var vipGuest in VIPGuests)
            {
                Console.WriteLine(vipGuest);
            }
            foreach(var regularGuest in regularGuests)
            {
                Console.WriteLine(regularGuest);
            }
        }
    }
}
