using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            ReadMatrix(matrix);
            
            string[] coordinates = Console.ReadLine().Split();
            DetonateBombs(matrix, coordinates);
            int alive = 0;
            int sum = 0;

            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    alive++;
                    sum += item;
                }
            }
            Console.WriteLine($"Alive cells: {alive}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(matrix);


        }
        static void DetonateBombs(int[,] matrix, string[] coordinates)
        {
            foreach (string pair in coordinates)
            {
                int[] bomb = pair.Split(",").Select(int.Parse).ToArray();
                int currentRow = bomb[0];
                int currentCol = bomb[1];
                int value = matrix[currentRow, currentCol];

                for (int row = currentRow - 1 ; row <= currentRow + 1; row++)
                {
                    for (int col = currentCol - 1; col <= currentCol + 1; col++)
                    {
                        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                        {
                            if (matrix[row,col] <= 0 || value < 0)
                            {
                                continue;
                            }
                            matrix[row, col] -= value;

                        }
                    }
                }
            }
        }

        static int[,] ReadMatrix(int[,] matrix)
        {

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
