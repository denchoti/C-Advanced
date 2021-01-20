using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            char[,] matrix = new char[n, m];

            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                    if (matrix[row,col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            char[] commands = Console.ReadLine().ToCharArray();
            bool isWon = false;
            bool isDead = false;

            foreach (char letter in commands)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                if (letter == 'U')
                {
                    newPlayerRow--;
                }
                else if (letter == 'D')
                {
                    newPlayerRow++;
                }
                else if(letter == 'L')
                {
                    newPlayerCol--;
                }
                else if (letter == 'R')
                {
                    newPlayerCol++;
                }
                
              
                if (!IsValidCell(newPlayerRow, newPlayerCol, n, m))
                {
                    isWon = true;
                    matrix[playerRow, playerCol] = '.';

                    List<int[]> bunniesCoordinates = GetBunniesCoordiates(matrix);
                    SpreadBunnies(bunniesCoordinates, matrix);
                }
                else if (matrix[newPlayerRow, newPlayerCol] == '.')
                {
                    matrix[playerRow, playerCol] = '.';
                    matrix[newPlayerRow, newPlayerCol] = 'P';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;

                    List<int[]> bunniesCoordinates = GetBunniesCoordiates(matrix);
                    SpreadBunnies(bunniesCoordinates, matrix);

                    if (matrix[playerRow,playerCol] == 'B')
                    {
                        isDead = true;
                    }

                   
                }
                else if (matrix[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    matrix[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;

                    List<int[]> bunniesCoordinates = GetBunniesCoordiates(matrix);
                    SpreadBunnies(bunniesCoordinates, matrix);
                }

                

                if (isWon || isDead)
                {
                    break;
                }
            }


            PrintMatrix(matrix);
            if (isWon)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else if (isDead)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }

        private static void SpreadBunnies(List<int[]> bunniesCoordinates, char[,] matrix)
        {
            
            foreach (int[] coordinates in bunniesCoordinates)
            {
                int row = coordinates[0];
                int col = coordinates[1];

                SpreadBunny(row - 1, col, matrix);
                SpreadBunny(row + 1, col, matrix);
                SpreadBunny(row, col - 1, matrix);
                SpreadBunny(row, col + 1, matrix);
                
            }
        }

        private static void SpreadBunny(int row, int col, char[,] matrix)
        {
            int rowsLength = matrix.GetLength(0);
            int colsLength = matrix.GetLength(1);
            if (IsValidCell(row, col, rowsLength, colsLength))
            {
                matrix[row, col] = 'B';
            }
        }

        private static List<int[]> GetBunniesCoordiates(char[,] matrix)
        {
            List<int[]> bunniesCoordinates = new List<int[]>();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunniesCoordinates.Add(new int[] { row, col });
                    }
                }
            }
            return bunniesCoordinates;
        }

        private static bool IsValidCell(int row, int col, int n, int m)
        {
            return row >= 0 && row < n && col >= 0 && col < m;
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
