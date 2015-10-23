namespace P5_SlicingFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    internal sealed class App
    {
        internal static void Main()
        {
            Slice("small.mp4", "C:\\OUTPUT", 3);
        }

        // You need to create the destination directory if it does not exist already
        private static void Slice(string sourceFile, string destinationDirectory, int parts)
        {
            
        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            
        }
    }
}