using System;
using SF.Mod10.MiniCalculator.Interfaces;

namespace SF.Mod10.MiniCalculator
{
    /// <summary>
    /// The logger.
    /// </summary>
    public class Logger : ILogger
    {
        /// <summary>
        /// Events the.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="severity">The severity.</param>
        void ILogger.Event(string message, int severity)
        {
            switch (severity)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nINFO: " + message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case -1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR: " + message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
        }
    }
}
