using System;
using System.IO;
using System.IO.Compression;

namespace ZipAndExtract
{
    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\Files\copyMe.png";
            string zipArchiveFile = @"..\..\..\Files\archive.zip";
            string extractedFile = @"..\..\..\Files\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFile, string zipArchiveFile)
        {
            ZipFile.CreateFromDirectory(inputFile, zipArchiveFile);
        }

        public static void ExtractFileFromArchive(string zipArchiveFile, string fileNameOnly, string extractedFile)
        {
            ZipFile.ExtractToDirectory(fileNameOnly, zipArchiveFile,  true);
        }
    }
}
