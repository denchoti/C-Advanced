using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            string[,] matrix = new string[rows, cols];
            ReadMatrix(matrix);

            string command = Console.ReadLine();
            while (command != "END")
            {
                if (!ValidateCommand(command, rows, cols))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string[] commands = command.Split();
                    int row1 = int.Parse(commands[1]);
                    int col1 = int.Parse(commands[2]);
                    int row2 = int.Parse(commands[3]);
                    int col2 = int.Parse(commands[4]);

                    var first = matrix[row1, col1];
                    var second = matrix[row2, col2];


                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            if (row == row1 && col == col1)
                            {
                                matrix[row, col] = second;
                            }
                            else if (row == row2 && col == col2)
                            {
                                matrix[row, col] = first;
                            }
                        }
                        
                    }

                    PrintMatrix(matrix);
                }

                command = Console.ReadLine();
            }
           
        }
        static bool ValidateCommand(string command, int rows, int cols)
        {
            string[] commands = command.Split();
            if (commands.Length == 5 && commands[0] == "swap"
                  && int.Parse(commands[1]) <= rows && int.Parse(commands[2]) <= cols
                  && int.Parse(commands[3]) <= rows && int.Parse(commands[4]) <= cols)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void ReadMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] currentRow = Console.ReadLine().Split().ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }

        static void PrintMatrix(string[,] matrix)
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

