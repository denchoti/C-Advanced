using System;
using System.Linq;

namespace PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPresents = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int santaRow = -1;
            int santaCol = -1;
            int countNiceKids = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'S')
                    {
                        santaRow = row;
                        santaCol = col;
                    }

                    if (matrix[row, col] == 'V')
                    {
                        countNiceKids++;
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "Christmas morning")
            {
                matrix[santaCol, santaRow] = '-';
                switch (command)
                {
                    case "up":
                        santaRow--;
                        break;
                    case "down":
                        santaRow++;
                        break;
                    case "left":
                        santaCol--;
                        break;
                    case "right":
                        santaCol++;
                        break;
                }

                if (matrix[santaRow, santaCol] == 'V')
                {
                    countPresents--;
                }
              
                else if (matrix[santaRow, santaCol] == 'C')
                {
                    if (matrix[santaRow, santaCol - 1] != '-') //left
                    {
                        countPresents--;
                        matrix[santaRow, santaCol - 1] = '-';
                    }
                    if (matrix[santaRow, santaCol + 1] != '-') //right
                    {
                        countPresents--;
                        matrix[santaRow, santaCol + 1] = '-';
                    }
                    if (matrix[santaRow - 1, santaCol] != '-') //up
                    {
                        countPresents--;
                        matrix[santaRow - 1, santaCol] = '-';
                    }
                    if (matrix[santaRow + 1, santaCol] != '-') //down
                    {
                        countPresents--;
                        matrix[santaRow + 1, santaCol] = '-';
                    }
                }
                matrix[santaRow, santaCol] = 'S';


                if (countPresents <= 0)
                {
                    Console.WriteLine("Santa ran out of presents.");
                    break;
                }
                command = Console.ReadLine();
            }
             
            

            int niceKidsWithoutPresent = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                    if (matrix[row,col] == 'V')
                    {
                        niceKidsWithoutPresent++;
                    }
                }
                Console.WriteLine();
            }

            if (niceKidsWithoutPresent == 0)
            {
                Console.WriteLine($"Good job, Santa! {countNiceKids} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {niceKidsWithoutPresent} nice kid/s.");
            }
        }

    }
}
