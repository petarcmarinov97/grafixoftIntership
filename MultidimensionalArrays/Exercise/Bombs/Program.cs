using System;
using System.Linq;
using System.Collections.Generic;


namespace Bombs
{
    public class Program
    {
        static int[][] matrix;
        static void Main(string[] args)
        {
            int rowsNumber = int.Parse(Console.ReadLine());
            matrix = new int[rowsNumber][];
            ReadMatrix();

            string[] coordinates = Console.ReadLine()
                .Split();

            foreach (var bomb in coordinates)
            {
                int[] bombCordinates = bomb.Split(',').Select(int.Parse).ToArray();
                int rowBomb = bombCordinates[0];
                int colBomb = bombCordinates[1];

                BombCells(rowBomb, colBomb); //Passing the row and col possition of the Bomb
            }

            PrintCellInfo();
            PrintMatrix();
        }

        static void ReadMatrix() //Reading Rows of numbers and Generating a Matrix NxN
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                int[] row = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                matrix[i] = row;
            }
        }
        private static void BombCells(int rowBomb, int colBomb) //Takes the cells that must absorb the damage
        {
            int damage = matrix[rowBomb][colBomb];

            if (damage > 0)
            {
                BombCell(rowBomb - 1, colBomb - 1, damage); //topleft
                BombCell(rowBomb - 1, colBomb, damage); //top
                BombCell(rowBomb - 1, colBomb + 1, damage); //topright
                BombCell(rowBomb, colBomb - 1, damage); //left
                BombCell(rowBomb, colBomb + 1, damage); //right
                BombCell(rowBomb + 1, colBomb - 1, damage); //bottomleft 
                BombCell(rowBomb + 1, colBomb, damage); //bottom
                BombCell(rowBomb + 1, colBomb + 1, damage); //bottomright

                matrix[rowBomb][colBomb] = 0; //After we applied a damage on the cells we need to set the bomb cell = 0
            }
        }

        public static void BombCell(int rowBomb, int colBomb, int damage) //Checks for valid cell and deal a damage on it
        {
            if (rowBomb >= 0 && rowBomb < matrix.Length &&
                colBomb >= 0 && colBomb < matrix.Length &&
                matrix[rowBomb][colBomb] > 0)
            {
                matrix[rowBomb][colBomb] -= damage;
            }
        }
        static void PrintCellInfo() //Printing the count of the alive cells and their sum
        {
            int aliveCellsCount = 0;
            int aliveCellsSum = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] aliveCells = matrix[row].Where(x => x > 0).ToArray();

                aliveCellsSum += aliveCells.Sum();
                aliveCellsCount += aliveCells.Length;
            }

            Console.WriteLine($"Alive cells: {aliveCellsCount}");
            Console.WriteLine($"Sum: {aliveCellsSum}");
        }
        static void PrintMatrix() //Printing the final Matrix after the explosions
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }
    }
}