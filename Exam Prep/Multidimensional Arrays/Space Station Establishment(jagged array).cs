using System;

namespace SpaceStationEstablishment
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());


            int stephenRow = 0;
            int stephenCol = 0;

            char[][] matrix = new char[size][];

            for (int row = 0; row < size; row++)
            {
                matrix[row] = new char[size];
                char[] data = Console.ReadLine().ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    char current = data[col];

                    if (current == 'S')
                    {
                        stephenRow = row;
                        stephenCol = col;
                    }
                    matrix[row][col] = current;
                }
            }

            int stars = 0;
            while (true)
            {
                matrix[stephenRow][stephenCol] = '-';
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

                if (IsOutside(size, stephenRow, stephenCol))
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    break;
                }

                char symbol = matrix[stephenRow][stephenCol];

                if (symbol == 'O')
                {
                    matrix[stephenRow][stephenCol] = '-';

                    for (int r = 0; r < size; r++)
                    {
                        bool found = false;
                        for (int c = 0; c < size; c++)
                        {
                            char currentElement = matrix[r][c];
                            if (currentElement == 'O')
                            {
                                stephenRow = r;
                                stephenCol = c;

                                matrix[stephenRow][stephenCol] = 'S';
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
            
                matrix[stephenRow][stephenCol] = 'S';

                if (stars >= 50)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    break;
                }
            }

            Console.WriteLine($"Star power collected: {stars}");


            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row][col]);
                }
                Console.WriteLine();
            }


        }

        private static bool IsOutside(int size, int stephenRow, int stephenCol)
        {
            return stephenRow >= size
                || stephenRow < 0
                || stephenCol >= size
                || stephenCol < 0;
        }
    }
}
