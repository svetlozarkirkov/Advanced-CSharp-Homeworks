namespace P2_MaximalSum
{
    using System;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter N x M: ");
            int[] inputRowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = inputRowsAndCols[0];
            int cols = inputRowsAndCols[1];
            if (rows < 3 || cols < 3)
            {
                Console.WriteLine("Rows and cols must be at least 3 each!");
                return;
            }

            int[,] matrix = new int[rows, cols];
            
            for (int i = 0; i < rows; i++)
            {
                Console.Write("Enter startRowIndex {0}: ", i);
                var row = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int maximalSum = int.MinValue;
            int[,] maximalSumMatrix = new int[3, 3];
                
            for (int currentRow = 0; currentRow < matrix.GetLength(0) - 2; currentRow++)
            {
                for (int currentCol = 0; currentCol < matrix.GetLength(1) - 2; currentCol++)
                {
                    int[,] currentExtractedMatrix = ExtractMatrix(matrix, currentRow, currentCol);
                    int currentExtractedMatrixSum = CalculateMatrixSum(currentExtractedMatrix);
                        
                    if (currentExtractedMatrixSum > maximalSum)
                    {
                        maximalSum = currentExtractedMatrixSum;
                        maximalSumMatrix = currentExtractedMatrix;
                    }
                }
            }

            Console.WriteLine("Sum = {0}", maximalSum);
            PrintMatrix(maximalSumMatrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col].ToString().PadLeft(5));
                }

                Console.WriteLine("\n");
            }
        }

        private static int CalculateMatrixSum(int[,] matrix)
        {
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            return sum;
        }

        private static int[,] ExtractMatrix(int[,] matrix, int startRowIndex, int startColIndex)
        {
            int[,] extractedMatrix = new int[3, 3];

            for (int nextRowCell = 0; nextRowCell < 3; nextRowCell++)
            {
                for (int nextColCell = 0; nextColCell < 3; nextColCell++)
                {
                    extractedMatrix[nextRowCell, nextColCell] = 
                        matrix[startRowIndex + nextRowCell, startColIndex + nextColCell];
                }
            }
            
            return extractedMatrix;
        }
    }
}