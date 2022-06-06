using System;
using System.IO;

namespace OddLines
{
    internal class OddLines
    {


        static void Main()
        {
            string inputFilePath = @"C:\GitHub\Bozhidar branch\01. Odd Lines\bin\Debug\net5.0\input.txt";
            string outputFilePath = @"C:\GitHub\Bozhidar branch\01. Odd Lines\bin\Debug\net5.0\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }


        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            int lineNum = 0;
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (lineNum % 2 != 0)
                        {
                            writer.WriteLine(line);                            
                        }
                        lineNum++;
                    }
                }
            }
        }
    }
}