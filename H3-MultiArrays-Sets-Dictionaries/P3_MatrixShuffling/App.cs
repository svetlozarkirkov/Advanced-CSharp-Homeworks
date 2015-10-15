namespace P3_MatrixShuffling
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            string[,] matrix = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            string currentCommand = Console.ReadLine();
            while (!currentCommand.Equals("END"))
            {
                var splitCommand = currentCommand.Split(' ');
                if (!IsValidCommand(matrix, splitCommand))
                {
                    currentCommand = Console.ReadLine();
                    continue;
                }

                int x1 = int.Parse(splitCommand[1]);
                int y1 = int.Parse(splitCommand[2]);
                int x2 = int.Parse(splitCommand[3]);
                int y2 = int.Parse(splitCommand[4]);

                PerformSwap(matrix, x1, y1, x2, y2);
                PrintMatrix(matrix);

                currentCommand = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            Console.WriteLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}   ", matrix[row, col]);
                }

                Console.WriteLine();
            }
            
            Console.WriteLine();
        }

        private static bool IsValidCommand(string[,] matrix, string[] splitCommand)
        {
            if (!splitCommand[0].Equals("swap") 
                || splitCommand.Length != 5
                || int.Parse(splitCommand[1]) >= matrix.GetLength(0)
                || int.Parse(splitCommand[1]) < 0
                || int.Parse(splitCommand[2]) >= matrix.GetLength(1)
                || int.Parse(splitCommand[2]) < 0
                || int.Parse(splitCommand[3]) >= matrix.GetLength(0)
                || int.Parse(splitCommand[3]) < 0
                || int.Parse(splitCommand[4]) >= matrix.GetLength(1)
                || int.Parse(splitCommand[4]) < 0)
            {
                Console.WriteLine("\nInvalid input!\n");
                return false;
            }

            return true;
        }

        private static void PerformSwap(string[,] matrix, int x1, int y1, int x2, int y2)
        {
            string current = matrix[x1, y1];
            matrix[x1, y1] = matrix[x2, y2];
            matrix[x2, y2] = current;
        }
    }
}