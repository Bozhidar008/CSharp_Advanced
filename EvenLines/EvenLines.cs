using System;
using System.IO;
using System.Linq;

namespace EvenLines
{
    public class EvenLines
    {
        static void Main()
        {
            string filePath = @"..\..\..\text.txt";

            ProcessLines(filePath);

        }

        public static string ProcessLines(string filePath)
        {
            int counter = 0;
            string outputPath = @"..\..\..\output.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    string currentLine = reader.ReadLine();

                    while (currentLine != null)
                    {
                        if (counter % 2 == 0)
                        {
                            string replacedLine = ReplaceSymbs(currentLine);
                            string reverseWords = ReverseWords(replacedLine);

                            writer.WriteLine(reverseWords);
                        }
                        currentLine = reader.ReadLine();
                        counter++;
                    }
                }
            }
            return outputPath;
        }

        private static string ReplaceSymbs(string currentLine)
        {
            return currentLine.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
        }

        private static string ReverseWords(string replacedLine)
        {
            return string.Join(" ", replacedLine.Split().Reverse());
        }

        


    }
}
