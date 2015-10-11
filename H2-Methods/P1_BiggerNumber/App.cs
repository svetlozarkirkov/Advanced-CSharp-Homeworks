namespace P1_BiggerNumber
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.Write("Enter first integer: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            int second = int.Parse(Console.ReadLine());
            int max = GetMax(first, second);
            Console.WriteLine("Bigger: {0}", max);
        }

        private static int GetMax(int first, int second)
        {
            if (first < second)
            {
                return second;
            }

            return first;
        }
    }
}