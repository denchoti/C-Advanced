using System;
using System.Linq;

namespace _02._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            char[,] matrix = new char[rows, cols];
            ReadMatrix(matrix);

            int count = 0;
            for (int row = 0; row < rows - 1; row++) //without the top right and bottom right elemnt
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char current = matrix[row, col];

                    if (current == matrix[row, col + 1] 
                        && current == matrix[row + 1, col] 
                        && current == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
      

    }
}
