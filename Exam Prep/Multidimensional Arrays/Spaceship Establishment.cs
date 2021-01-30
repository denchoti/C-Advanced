using System;

namespace SpaceshipEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            int stephenRow = 0;
            int stephenCol = 0;

            for (int row = 0; row < size; row++)
            {
                char[] data = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    char current = data[col];

                    if (current == 'S')
                    {
                        stephenRow = row;
                        stephenCol = col;
                    }
                    matrix[row,col] = current;
                }
            }

            int stars = 0;
            while (true)
            {
                matrix[stephenRow,stephenCol] = '-';
                string command = Console.ReadLine();

                switch (command)
                {
                    case "right":
                        stephenCol++;
                        break;

                    case "left":
                        stephenCol--;
                        break;

                    case "up":
                        stephenRow--;
                        break;

                    case "down":
                        stephenRow++;
                        break;
                }

                if (!IsValidCell(stephenRow, stephenCol,size))
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    break;
                }

                char symbol = matrix[stephenRow,stephenCol];

                if (symbol == 'O')
                {
                    matrix[stephenRow,stephenCol] = '-';

                    for (int r = 0; r < size; r++)
                    {
                        bool found = false;
                        for (int c = 0; c < size; c++)
                        {
                            char currentElement = matrix[r,c];
                            if (currentElement == 'O')
                            {
                                stephenRow = r;
                                stephenCol = c;

                                matrix[stephenRow,stephenCol] = 'S';
                                found = true;
                                break;
                            }
                        }
                        if (found)
                        {
                            break;
                        }
                    }

                }
                else if (char.IsDigit(symbol))
                {
                    stars += symbol - '0';
                }

                matrix[stephenRow,stephenCol] = 'S';

                if (stars >= 50)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    break;
                }
            }

            Console.WriteLine($"Star power collected: {stars}");
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

        private static bool IsValidCell(int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n;
        }
    }
}
