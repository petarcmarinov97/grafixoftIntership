using System;

namespace Knights
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] matrix = new char[n][];

            for (int i = 0; i < matrix.Length; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                matrix[i] = new char[n];
                matrix[i] = row;
            }


            int currentKnightsInDanger = 0;
            int maxKnightsInDanger = -1;
            int mostDangerousRow = 0;
            int mostDangerousColumn = 0;
            int countRemoves = 0;

            while (true)
            {
                if (n < 3)
                {
                    Console.WriteLine("0");
                    return;
                }

                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < matrix[rowIndex].Length; columnIndex++)
                    {
                        if (matrix[rowIndex][columnIndex].Equals('K'))
                        {
                           currentKnightsInDanger = GetKnightsInDanger(rowIndex, columnIndex, matrix, currentKnightsInDanger);
                        }

                        if (currentKnightsInDanger > maxKnightsInDanger)
                        {
                            maxKnightsInDanger = currentKnightsInDanger; //setting the newMostDangerousKnight who needs to be removed;
                            mostDangerousRow = rowIndex; //setting the cordinates - row
                            mostDangerousColumn = columnIndex; //setting the cordinates - column
                        }

                        currentKnightsInDanger = 0; //Setting to 0 before the next loop 
                    }
                }

                if (maxKnightsInDanger != 0)
                {
                    matrix[mostDangerousRow][mostDangerousColumn] = 'O'; //removing the most dangerous knight
                    countRemoves++; // Increasing the count of removed knights
                    maxKnightsInDanger = 0;
                }
                else
                {
                    Console.WriteLine(countRemoves);
                    return;
                }
            }
        }
       
        public static int GetKnightsInDanger(int rowIndex, int columnIndex, char [][]matrix, int currentKnightsInDanger)
        {
            //vertical-top left
            if (ReturnIsCellInMatrix(rowIndex - 2, columnIndex - 1, matrix))
            {
                if (matrix[rowIndex - 2][columnIndex - 1].Equals('K'))
                {
                    currentKnightsInDanger++;
                }
            }

            //top-vertical right
            if (ReturnIsCellInMatrix(rowIndex - 2, columnIndex + 1, matrix))
            {
                if (matrix[rowIndex - 2][columnIndex + 1].Equals('K'))
                {
                    currentKnightsInDanger++;
                }
            }

            // bot-vertical and left
            if (ReturnIsCellInMatrix(rowIndex + 2, columnIndex - 1, matrix))
            {
                if (matrix[rowIndex + 2][columnIndex - 1].Equals('K'))
                {
                    currentKnightsInDanger++;
                }
            }

            // bot-vertical and right
            if (ReturnIsCellInMatrix(rowIndex + 2, columnIndex + 1, matrix))
            {
                if (matrix[rowIndex + 2][columnIndex + 1].Equals('K'))
                {
                    currentKnightsInDanger++;
                }
            }

            // horizontal left and up
            if (ReturnIsCellInMatrix(rowIndex - 1, columnIndex - 2, matrix))
            {
                if (matrix[rowIndex - 1][columnIndex - 2].Equals('K'))
                {
                    currentKnightsInDanger++;
                }
            }

            // horizontal right and up
            if (ReturnIsCellInMatrix(rowIndex - 1, columnIndex + 2, matrix))
            {
                if (matrix[rowIndex - 1][columnIndex + 2].Equals('K'))
                {
                    currentKnightsInDanger++;
                }
            }

            // horizontal left and down
            if (ReturnIsCellInMatrix(rowIndex + 1, columnIndex - 2, matrix))
            {
                if (matrix[rowIndex + 1][columnIndex - 2].Equals('K'))
                {
                    currentKnightsInDanger++;
                }
            }

            // horizontal right and down
            if (ReturnIsCellInMatrix(rowIndex + 1, columnIndex + 2, matrix))
            {
                if (matrix[rowIndex + 1][columnIndex + 2].Equals('K'))
                {
                    currentKnightsInDanger++;
                }
            }

            return currentKnightsInDanger;
        }
        public static bool ReturnIsCellInMatrix(int row, int col, char[][] matrix)
        {
            return (0 <= row && row < matrix.Length && 0 <= col && col < matrix[row].Length);
        }
    }
}
