using System;
using System.IO;

namespace ModuleControl1
{
    class MessagePublisher
    {
        public event Action<string> MessageSent;

        public void Send(string message)
        {
            MessageSent?.Invoke(message);
        }
    }

    class FileLogger
    {
        private string logFile;

        public FileLogger(string filePath, MessagePublisher publisher)
        {
            logFile = filePath;
            publisher.MessageSent += LogMessage;
        }

        private void LogMessage(string message)
        {
            using var writer = new StreamWriter(logFile, true);
            writer.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
        }
    }

    internal class Task2
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string folder = @"C:\Users\Olivinskiy\source\repos\2semestrprogramming\ModuleControl1\ModuleControl1\";
            string logFile = Path.Combine(folder, "logPD2X.txt");

            var publisher = new MessagePublisher();
            var logger = new FileLogger(logFile, publisher);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Введіть текст: ");
                string message = Console.ReadLine();
                publisher.Send(message);
            }

            Console.WriteLine($"Лог збережено у {logFile}");
        }
    }
}