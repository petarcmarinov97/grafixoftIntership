using System;

namespace VacationBook_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            int pagesForHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int timeToReadTheBook = pagesCount / pagesForHour;
            int neededHoursPerDay = timeToReadTheBook / days;

            Console.WriteLine(neededHoursPerDay);

        }
    }
}
