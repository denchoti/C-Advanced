using System;
using System.Linq;

namespace TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];


            int firstPlayerRow = -1;
            int firstPlayerCol = -1;
            int secondPlayerRow = -1;
            int secondPlayerCol = -1;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'f')
                    {
                        firstPlayerRow = row;
                        firstPlayerCol = col;
                    }
                    if (matrix[row, col] == 's')
                    {
                        secondPlayerRow = row;
                        secondPlayerCol = col;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();
                string firstCommand = command[0];
                string secondCommand = command[1];

                switch (firstCommand)
                {
                    case "left":
                        if (firstPlayerCol - 1 < 0)
                        {
                            firstPlayerCol = size - 1;
                        }
                        else
                        {
                            firstPlayerCol--;
                        }
                        break;
                    case "right":
                        if (firstPlayerCol + 1 < 0)
                        {
                            firstPlayerCol = 0;
                        }
                        else
                        {
                            firstPlayerCol++;
                        }
                        break;
                    case "up":
                        if (firstPlayerRow - 1 < 0)
                        {
                            firstPlayerRow = size - 1;
                        }
                        else
                        {
                            firstPlayerRow--;
                        }
                        break;
                    case "down":
                        if (firstPlayerRow + 1 >= size)
                        {
                            firstPlayerRow = 0;
                        }
                        else
                        {
                            firstPlayerRow++;
                        }
                        break;
                }

                if (matrix[firstPlayerRow, firstPlayerCol] == 's')
                {
                    matrix[firstPlayerRow, firstPlayerCol] = 'x';
                    break;
                }

                matrix[firstPlayerRow, firstPlayerCol] = 'f';


                switch (secondCommand)
                {
                    case "left":
                        if (secondPlayerCol - 1 < 0)
                        {
                            secondPlayerCol = size - 1;
                        }
                        else
                        {
                            secondPlayerCol--;
                        }
                        break;
                    case "right":
                        if (secondPlayerCol + 1 < 0)
                        {
                            secondPlayerCol = 0;
                        }
                        else
                        {
                            secondPlayerCol++;
                        }
                        break;
                    case "up":
                        if (secondPlayerRow - 1 < 0)
                        {
                            secondPlayerRow = size - 1;
                        }
                        else
                        {
                            secondPlayerRow--;
                        }
                        break;
                    case "down":
                        if (secondPlayerRow + 1 >= size)
                        {
                            secondPlayerRow = 0;
                        }
                        else
                        {
                            secondPlayerRow++;
                        }
                        break;
                }

                if (matrix[secondPlayerRow, secondPlayerCol] == 'f')
                {
                    matrix[secondPlayerRow, secondPlayerCol] = 'x';
                    break;
                }

                matrix[secondPlayerRow, secondPlayerCol] = 's';
            }

            PrintMatrix(matrix);
        }


        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
