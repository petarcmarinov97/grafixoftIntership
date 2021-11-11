using System;

namespace FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());


            if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{quantity * 2.70:F2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{quantity * 1.25:F2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{quantity * 0.90:F2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{quantity * 1.60:F2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{quantity * 3.00:F2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{quantity * 5.60:F2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{quantity * 4.20:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if(day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine($"{quantity * 2.50:F2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{quantity * 1.20:F2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{quantity * 0.85:F2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{quantity * 1.45:F2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{(quantity * 2.70):F2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{quantity * 5.50:F2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{quantity * 3.85:F2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

