using System;

namespace BonusPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double bonusPoints = 0;
            double finalResult = 0;

            if (number % 2 == 0)
            {
                bonusPoints++;
            }
            else if (number % 5 == 0)
            {
                bonusPoints += 2;
            }

            if (number <= 100)
            {
                bonusPoints += 5;    
                finalResult = number + bonusPoints;
            }else if(number>100 && number <= 1000)
            {
                bonusPoints += number * 0.2;
                finalResult = number + bonusPoints;
            }
            else
            {
                bonusPoints += number * 0.1;
                finalResult = number + bonusPoints;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(finalResult);
        }
    }
}
