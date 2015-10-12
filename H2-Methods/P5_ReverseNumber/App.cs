namespace P5_ReverseNumber
{
    using System;
    using System.Globalization;
    using System.Linq;

    internal sealed class App
    {
        internal static void Main()
        {
            double reversedOne = GetReversedNumber(123.45);
            double reversedTwo = GetReversedNumber(256);
            double reversedThree = GetReversedNumber(0.12);
            Console.WriteLine(reversedOne);
            Console.WriteLine(reversedTwo);
            Console.WriteLine(reversedThree);
        }

        private static double GetReversedNumber(double number)
        {
            return double.Parse(
                string.Join(
                string.Empty, 
                number.ToString(CultureInfo.CurrentCulture).Reverse().ToArray()));           
        }
    }
}