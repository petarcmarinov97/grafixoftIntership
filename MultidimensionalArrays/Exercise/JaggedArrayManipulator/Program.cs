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
        public static string[] commands;
        public static int numberOfRows;

        static void Main(string[] args)
        {
            numberOfRows = int.Parse(Console.ReadLine());

            matrix = GetPopulatedMatrix(numberOfRows);
            analyzedMatrix = GetAnalyzedMatrix(matrix, numberOfRows);

            do
            {
                commands = Console.ReadLine().Split(" ", System.StringSplitOptions.RemoveEmptyEntries).ToArray();

                ManipulationThrewTheCells();
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
    
        public static void DestructInput()
        {
            row = int.Parse(commands[1]);
            column = int.Parse(commands[2]);
            value = double.Parse(commands[3]);
        }
        public static void ManipulationThrewTheCells()
        {
            switch (commands[0].ToLower())
            {
                case "add":
                    DestructInput();
                    AddValueToTheCurrentCell();
                    break;

                case "subtract":
                    DestructInput();
                    SubtractValueFromTheCurrentCell();
                    break;

                case "end":
                    PrintFinalMatrix(analyzedMatrix, numberOfRows);
                    break;

                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }
}
