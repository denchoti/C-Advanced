using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];


            for (int i = 0; i < rows; i++)
            {
                double[] currentRow = Console.ReadLine().Split().Select(double.Parse).ToArray();
                matrix[i] = currentRow;
            }

            for (int i = 0; i < rows - 1; i++)
            {
                if (matrix[i].Count() == matrix[i + 1].Count())
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

            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = input[0];

                if (command == "End")
                {
                    break;
                }
                int row = int.Parse(input[1]);
                int column = int.Parse(input[2]);
                double value = double.Parse(input[3]);

                if (!ValidateCoordinates(matrix, row, column))
                {
                    continue;
                }

                if (command == "Add")
                {
                    matrix[row][column] += value;
                }
                else if (command == "Subtract")
                {
                    matrix[row][column] -= value;
                }

            }

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        static bool ValidateCoordinates(double[][] matrix, int row, int column)
        {
            if (row >= 0 && row < matrix.Length)
            {
                if (column >= 0 && column < matrix[row].Length)
                {
                    return true;
                }
            }

            return false;
        }


    }
}
