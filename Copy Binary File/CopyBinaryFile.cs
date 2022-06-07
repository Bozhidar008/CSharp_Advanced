namespace CopyBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using var reader = new FileStream(inputFilePath, FileMode.OpenOrCreate);
            using var writer = new FileStream(outputFilePath, FileMode.OpenOrCreate);

            byte[] buffer = new byte[4096];

            while (true)
            {
                var bytesToRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesToRead < buffer.Length)
                {
                    buffer = buffer
                        .Take(bytesToRead)
                        .ToArray();
                    writer.Write(buffer, 0, buffer.Length);
                    break;
                }

                writer.Write(buffer, 0, buffer.Length);
            }
        }
    }
}
