using System;
using System.Collections.Generic;
using System.Linq;

namespace BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int playerRow = 0;
            int playerCol = 0;
            Stack<char> word = new Stack<char>(input);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }

            string direction = Console.ReadLine();
            while (direction != "end")
            {
                matrix[playerRow, playerCol] = '-';
                switch (direction)
                {
                    case "up":
                        if (playerRow - 1 >= 0)
                        {
                            playerRow--;
                            char symbol = matrix[playerRow, playerCol];
                            if (Char.IsLetter(symbol))
                            {
                                word.Push(symbol);
                            }
                            //matrix[playerRow, playerCol] = 'P';
                            //matrix[playerRow + 1, playerCol] = '-';
                        }
                        else
                        {
                            if (word.Count > 0)
                            {
                                word.Pop();
                            }
                        }
                        break;
                    case "down":
                        if (playerRow + 1 <= size)
                        {
                            playerRow++;

                            char symbol = matrix[playerRow, playerCol];
                            if (Char.IsLetter(symbol))
                            {
                                word.Push(symbol);
                            }
                            //matrix[playerRow, playerCol] = 'P';
                            //matrix[playerRow - 1, playerCol] = '-';

                        }
                        else
                        {
                            if (word.Count > 0)
                            {
                                word.Pop();
                            }
                        }
                        break;
                    case "left":
                        if (playerCol - 1 >= 0)
                        {
                            playerCol--;
                            char symbol = matrix[playerRow, playerCol];
                            if (Char.IsLetter(symbol))
                            {
                                word.Push(symbol);
                            }
                            //matrix[playerRow, playerCol] = 'P';
                            //matrix[playerRow, playerCol + 1] = '-';
                        }
                        else
                        {
                            if (word.Count > 0)
                            {
                                word.Pop();
                            }
                        }
                        break;
                    case "right":
                        if (playerCol + 1 <= size)
                        {
                            playerCol++;

                            char symbol = matrix[playerRow, playerCol];
                            if (Char.IsLetter(symbol))
                            {
                                word.Push(symbol);
                            }
                            //matrix[playerRow, playerCol] = 'P';
                            //matrix[playerRow, playerCol - 1] = '-';
                        }
                        else
                        {
                            if (word.Count > 0)
                            {
                                word.Pop();
                            }
                        }
                        break;
                }
                matrix[playerRow, playerCol] = 'P';
                direction = Console.ReadLine();
            }

            Console.WriteLine(string.Join("", word.Reverse()));
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
