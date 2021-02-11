using System;

namespace HelensAbduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];
            int parisRow = 0;
            int parisCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {            
                string currentRow = Console.ReadLine();
                matrix[row] = new char[currentRow.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = currentRow[col];
                    if (matrix[row][col] == 'P')
                    {
                        parisRow = row;
                        parisCol = col;
                    }
                }
            }

            matrix[parisRow][parisCol] = '-';
            string[] command = Console.ReadLine().Split();
            while (true)
            {
                string direction = command[0];
                int enemyRow = int.Parse(command[1]);
                int enemyCol = int.Parse(command[2]);

                matrix[enemyRow][enemyCol] = 'S';

                switch (direction)
                {
                    case "up":
                        if (parisRow - 1 >= 0)
                        {
                            parisRow--;
                        }
                        energy--;
                        break;

                    case "down":
                        if (parisRow + 1 < size)
                        {
                            parisRow++;
                        }
                        energy--;
                        break;

                    case "left":
                        if (parisCol - 1 >= 0)
                        {
                            parisCol--;
                        }
                        energy--;
                        break;

                    case "right":
                        if (parisCol + 1 < size)
                        {
                            parisCol++;
                        }
                        energy--;
                        break;
                }

                if (energy <= 0)
                {
                    matrix[parisRow][parisCol] = 'X';
                    Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                    break;
                }

                if (matrix[parisRow][parisCol] == 'H')
                {
                    matrix[parisRow][parisCol] = '-';
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
                    break;
                }

                if (matrix[parisRow][parisCol] == 'S')
                {
                    if (energy - 2 > 0)
                    {
                        energy -= 2;
                        matrix[parisRow][parisCol] = '-';
                    }
                    else
                    {
                        matrix[parisRow][parisCol] = 'X';
                        Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                        break;
                    }
                }

                command = Console.ReadLine().Split();
            }


            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }

                Console.WriteLine();
            }
        }
    }
}
