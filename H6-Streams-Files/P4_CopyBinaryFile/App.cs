namespace P4_CopyBinaryFile
{
    using System.IO;

    internal sealed class App
    {
        internal static void Main()
        {
            // The created file (kitten-copy.jpg) is in bin\Debug
            // The usings are chained for less nesting
            using (var copyStream = new FileStream("kitten-copy.jpg", FileMode.Create, FileAccess.Write))
            using (var readStream = new FileStream("kitten.jpg", FileMode.Open, FileAccess.Read))
            {
                readStream.CopyTo(copyStream);
            }
        }
    }
}