using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                matrix[row] = new int[rowData.Length];

                for (int col = 0; col < rowData.Length; col++)
                {
                    matrix[row][col] = rowData[col];
                }
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(" ");
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);
                bool isInvalid = false;

                if (matrix.Length <= row || row < 0 )
                {
                    isInvalid = true;
                }
                else if (matrix[row].Length <= col || col < 0)
                {
                    isInvalid = true;
                }
                if (isInvalid)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (tokens[0] == "Add")
                    {
                        matrix[row][col] += value;
                    }
                    if (tokens[0] == "Subtract")
                    {
                        matrix[row][col] -= value;
                    }
                }
                
                input = Console.ReadLine();
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(String.Join(" ",item));
            }
        }
    }
}
