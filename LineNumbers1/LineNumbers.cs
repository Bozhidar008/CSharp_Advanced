using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            string outputFilePath = @"..\..\..\output.txt";
            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            
            string[] lines = File.ReadAllLines(inputFilePath);

            int count = 1;

            foreach (var line in lines)
            {
                int lettersCount = line.Count(char.IsLetter);
                int puncsCount = line.Count(char.IsPunctuation);

                File.AppendAllText(outputFilePath, $"Line {count}: {line} ({lettersCount})({puncsCount}){Environment.NewLine}");
                count++;
            }
        }
    }
}
