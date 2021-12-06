using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            double[][] matrix = GetPopulatedMatrix(numberOfRows);
            double[][] analyzedMatrix = GetAnalyzedMatrix(matrix, numberOfRows);
            // double [][] analyzedMatrix = GetAnalyzedMatrix(GetPopulatedMatrix(numberOfRows), numberOfRows);

            string command = Console.ReadLine();

            while (true)
            {
                string[] commands = command.Split(" ", System.StringSplitOptions.RemoveEmptyEntries).ToArray();

                int row;
                int column;
                double value;

                if (commands[0].ToLower() == "add")
                {
                    row = int.Parse(commands[1]);
                    column = int.Parse(commands[2]);
                    value = double.Parse(commands[3]);

                    if (AreCoordinatesValid(analyzedMatrix, row, column))
                    {
                        analyzedMatrix[row][column] += value;
                    }
                }
                else if (commands[0].ToLower() == "subtract")
                {
                    row = int.Parse(commands[1]);
                    column = int.Parse(commands[2]);
                    value = double.Parse(commands[3]);

                    if (AreCoordinatesValid(analyzedMatrix, row, column))
                    {
                        analyzedMatrix[row][column] -= value;
                    }
                }
                else if (commands[0].ToLower() == "end")
                {
                    PrintFinalMatrix(analyzedMatrix, numberOfRows);
                    break;
                }

                command = Console.ReadLine();
            }
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

        static double[][] GetAnalyzedMatrix(double[][] matrix, int numberOfRows)
        {
            for (int i = 0; i < numberOfRows - 1; i++)
            {
                if (matrix[i].Length == matrix[i + 1].Length)
                {
                    matrix[i] = matrix[i].Select(x => x * 2).ToArray();
                    matrix[i + 1] = matrix[i + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[i] = matrix[i].Select(x => x / 2).ToArray();
                    matrix[i + 1] = matrix[i + 1].Select(x => x / 2).ToArray();
                }
            }

            return matrix;
        }

        private static bool AreCoordinatesValid(double[][] matrix, int row, int column)
        {
            return ((row >= 0 && row < matrix.Length) && (column >= 0 && column < matrix[row].Length));

        }

        static void PrintFinalMatrix(double[][] analyzedMatrix, int numberOfRows)
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.WriteLine(String.Join(" ", analyzedMatrix[i]));
            }
        }
    }
}
