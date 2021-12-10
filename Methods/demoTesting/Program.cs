using System;

namespace demoTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //If the method is static
            int twoValues = AddTwoValues(13, 17);
            Console.WriteLine(twoValues + "\n");

            //One way
            int threeValues = AddThreeValues(5, 15, 10);
            Console.WriteLine(threeValues + "\n");

            //Another way
            Console.WriteLine(AddThreeValues(5, 15, 10) + "\n");

            //If the method is instance
            Program fourValues = new Program();
            //One way
            int result = fourValues.AddFourValues(7, 3, 15, 5);
            Console.WriteLine(result + "\n");

            //Another way
            Console.WriteLine(fourValues.AddFourValues(7, 3, 15, 5));


            //Method with ref
            string name = "Petar";

            Console.WriteLine(ShowName(ref name) + "\n");
            Console.WriteLine(name);




            // Declaring variable
            // without assigning value
            int g;

            // Pass variable G to the method
            // using out keyword
            Sum(out g);

            // Display the value G
            Console.WriteLine("The sum of" +
                    " the value is: {0}", g);
        }


        // Method in which out parameter is passed
        // and this method returns the value of
        // the passed parameter
        public static void Sum(out int G)
        {
            G = 80;
            G += G;
        }

        private static string ShowName(ref string name)
        {
            name = "Ivan";
            return "Your name is: " + name;
        }
        private static int AddTwoValues(int x, int y)
        {
            return x + y;
        }

        public static int AddThreeValues(int x, int y, int z)
        {
            return x + y + z;
        }

        public int AddFourValues(int x, int y, int z, int k)
        {
            return x + y + z + k;
        }
    }
}

//create the method
//invoke the method
//namespace -> class -> members -> method -> statements
