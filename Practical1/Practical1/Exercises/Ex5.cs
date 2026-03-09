using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1.Exercises
{
    internal class Logger
    {
        public Action<string> LogHandler { get; set; }

        public void Log(string message)
        {
            LogHandler?.Invoke(message);
        }
    }

    internal class Ex5
    {
        public void Example()
        {
            Logger logger = new Logger();

            logger.LogHandler = message => Console.WriteLine($"Log: {message}");
            logger.Log("test1");

            logger.LogHandler = message => Console.WriteLine(message.ToUpper());
            logger.Log("test2");
        }
    }
}
