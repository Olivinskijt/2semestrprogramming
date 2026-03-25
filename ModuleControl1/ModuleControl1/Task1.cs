using System;
using System.IO;

namespace FileIO.WorkingWithTextFiles
{
    internal class FileInfoTextOperations
    {
        delegate string TextOperation(string s);

        static void Main()
        {
            string folder = @"C:\Users\Olivinskiy\source\repos\2semestrprogramming\ModuleControl1\ModuleControl1\";
            string inputName = Path.Combine(folder, "textPD23.txt");
            string outputName = Path.Combine(folder, "resultPD23.txt");

            FileInfo inputFile = new FileInfo(inputName);
            FileInfo outputFile = new FileInfo(outputName);

            using (var writer = new StreamWriter(outputFile.FullName, false))
            {
                writer.Write("");
            }

            ProcessFile(inputFile, outputFile, ToUpperCase);
            ProcessFile(inputFile, outputFile, CountChars);
            ProcessFile(inputFile, outputFile, CountWords);

            Console.WriteLine("Файл збережено:");
            Console.WriteLine(outputFile.FullName);
        }

        static void ProcessFile(FileInfo input, FileInfo output, TextOperation op)
        {
            string[] lines = File.ReadAllLines(input.FullName);

            using (var writer = new StreamWriter(output.FullName, true))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(op(line));
                }
                writer.WriteLine("-----");
            }
        }

        static string ToUpperCase(string s) => s.ToUpper();

        static string CountChars(string s) => s.Length.ToString();

        static string CountWords(string s) => s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length.ToString();
    }
}