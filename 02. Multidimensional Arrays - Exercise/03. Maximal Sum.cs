
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximalSum

{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];
            ReadMatrix(matrix);

            int maxSum = int.MinValue;
            int maxRows = 0;
            int maxCols = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {

                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                               + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                               + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRows = row;
                        maxCols = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = maxRows; i < maxRows + 3; i++)
            {
                for (int j = maxCols; j < maxCols + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();

            }

        }
        static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

    }

}

