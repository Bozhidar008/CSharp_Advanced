using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputPath, string outputPath)
        {

            int lineNum = 1;
            StreamReader reader = new StreamReader(inputPath);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputPath);
                using (writer)
                {
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        
                        
                        writer.WriteLine($"{lineNum}. {line}");
                        
                        lineNum++;
                    }
                }
            }

        }
    }
}
