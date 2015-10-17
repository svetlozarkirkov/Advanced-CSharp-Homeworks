namespace P5_CollectTheCoins
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            int rows = 4;
            char[][] board = new char[rows][];
            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                board[currentRow] = Console.ReadLine().ToCharArray();
            }
            
            PrintBoard(board);
            char[] commands = Console.ReadLine().ToCharArray();
            int coinsCollected = 0;
            int wallsHit = 0;
            int currentX = 0;
            int currentY = 0;
            foreach (char direction in commands)
            {
                MakeAMove(board, direction, ref currentX, ref currentY, ref coinsCollected, ref wallsHit);
            }

            Console.WriteLine("Coins collected: {0}", coinsCollected);
            Console.WriteLine("Walls hit: {0}", wallsHit);
        }

        private static void PrintBoard(char[][] board)
        {
            foreach (char[] row in board)
            {
                Console.WriteLine("[ {0} ]", string.Join(", ", row));
            }
        }

        private static void MakeAMove(
            char[][] board, 
            char direction, 
            ref int currentX, 
            ref int currentY,
            ref int coinsCollected,
            ref int wallsHit)
        {
            int nextX = currentX;
            int nextY = currentY;
            switch (direction)
            {
                case '>':
                    nextY++;
                    break;
                case '<':
                    nextY--;
                    break;
                case '^':
                    nextX--;
                    break;
                case 'V':
                    nextX++;
                    break;
                default:
                    throw new ArgumentException("Invalid direction!");
            }

            try
            {
                var test = board[nextX][nextY];
                if (test.Equals('$'))
                {
                    coinsCollected++;
                }

                currentX = nextX;
                currentY = nextY;
            }
            catch (IndexOutOfRangeException)
            {
                wallsHit++;
            }
        }
    }
}
