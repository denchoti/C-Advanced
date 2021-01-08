using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] numbers = new int[n, n];

            ReadMatrix(numbers);
            int sumPrimary = 0;
            int sumSecondary = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int number = numbers[row, col];
                    if (row == col)
                    {
                        sumPrimary += number;
                    }
                    if (col == n - 1 - row)
                    {
                        sumSecondary += number;
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumPrimary - sumSecondary));
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
    }
}
