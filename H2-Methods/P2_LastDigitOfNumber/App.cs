namespace P2_LastDigitOfNumber
{
    using System;

    internal sealed class App
    {
        internal static void Main()
        {
            Console.WriteLine(GetLastDigitAsWord(512));
            Console.WriteLine(GetLastDigitAsWord(1024));
            Console.WriteLine(GetLastDigitAsWord(12309));
        }

        private static string GetLastDigitAsWord(int number)
        {
            switch (number % 10)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 0:
                    return "zero";
                default:
                    throw new ArgumentException("Invalid number.");
            }
        }
    }
}
