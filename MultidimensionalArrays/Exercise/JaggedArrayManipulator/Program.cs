using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    public class Program
    {
        public static int row;
        public static int column;
        public static double value;
        public static double[][] matrix;
        public static double[][] analyzedMatrix;
        public static bool isEnd = false;
        public static string[] commands;
        public static int numberOfRows;
        static void Main(string[] args)
        {
            numberOfRows = int.Parse(Console.ReadLine());

            matrix = GetPopulatedMatrix(numberOfRows);
            analyzedMatrix = GetAnalyzedMatrix(matrix, numberOfRows);

            string command = Console.ReadLine();

            do
            {
                commands = command.Split(" ", System.StringSplitOptions.RemoveEmptyEntries).ToArray();

                ManipulationThrewTheCells();

                if (isEnd != true)
                {
                    command = Console.ReadLine();
                }
            }
            while (commands[0].ToLower() != "end");
        }

        static double[][] GetPopulatedMatrix(int numberOfRows)
        {
            double[][] matrix = new double[numberOfRows][];

            for (int i = 0; i < numberOfRows; i++)
            {
                double[] currentRowValue = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                matrix[i] = currentRowValue;
            }

            return matrix;
        }

        public static double[][] GetAnalyzedMatrix(double[][] matrix, int numberOfRows)
        {
            double[][] analyzedMatrix = matrix;
            for (int i = 0; i < numberOfRows - 1; i++)
            {
                if (analyzedMatrix[i].Length == matrix[i + 1].Length)
                {
                    analyzedMatrix[i] = analyzedMatrix[i].Select(x => x * 2).ToArray();
                    analyzedMatrix[i + 1] = analyzedMatrix[i + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    analyzedMatrix[i] = analyzedMatrix[i].Select(x => x / 2).ToArray();
                    analyzedMatrix[i + 1] = analyzedMatrix[i + 1].Select(x => x / 2).ToArray();
                }
            }

            return analyzedMatrix;
        }

        public static bool AreCoordinatesValid(double[][] matrix, int row, int column)
        {
            return ((row >= 0 && row < matrix.Length) && (column >= 0 && column < matrix[row].Length));

        }

        public static void PrintFinalMatrix(double[][] analyzedMatrix, int numberOfRows)
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.WriteLine(String.Join(" ", analyzedMatrix[i]));
            }
        }

        public static void AddValueToTheCurrentCell()
        {
            if (AreCoordinatesValid(analyzedMatrix, row, column))
            {
                analyzedMatrix[row][column] += value;
            }
        }

        public static void SubtractValueFromTheCurrentCell()
        {
            if (AreCoordinatesValid(analyzedMatrix, row, column))
            {
                analyzedMatrix[row][column] -= value;
            }
        }
    
        public static void ManipulationThrewTheCells()
        {
            switch (commands[0].ToLower())
            {
                case "add":
                    row = int.Parse(commands[1]);
                    column = int.Parse(commands[2]);
                    value = double.Parse(commands[3]);
                    AddValueToTheCurrentCell();
                    break;

                case "subtract":
                    row = int.Parse(commands[1]);
                    column = int.Parse(commands[2]);
                    value = double.Parse(commands[3]);
                    SubtractValueFromTheCurrentCell();
                    break;

                default:
                    isEnd = true;
                    PrintFinalMatrix(analyzedMatrix, numberOfRows);
                    break;
            }
        }
    }
}
