using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    public class Program
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
    }
}
