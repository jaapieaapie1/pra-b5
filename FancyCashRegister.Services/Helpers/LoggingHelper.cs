using FancyCashRegister.Services.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyCashRegister.Services.Helpers
{
    /// <summary>
    /// Logging helper class
    /// </summary>
    class LoggingHelper
    {

        private static LoggingHelper instance = null;

        private ConfigRepository config;
        private string loggingPath;

        public LoggingHelper()
        {
            config = new ConfigRepository();
            loggingPath = config.GetValueAsString("loggingFolder");
        }

        /// <summary>
        /// Static log function for easy access
        /// </summary>
        /// <param name="text">The text to log</param>
        /// <param name="level">The level to log</param>
        /// <param name="error">Optional error</param>
        /// <param name="stack">Optional stack trace</param>
        public static void Log(string text, LogLevel level, string error = null, string stack = null)
        {
            if (instance == null)
                instance = new LoggingHelper();


            instance.ActualLog(text, level, error, stack);
        }
        
        /// <summary>
        /// The private function to log stuff
        /// </summary>
        /// <param name="text">The text to log</param>
        /// <param name="level">The level to log</param>
        /// <param name="error">Optional error</param>
        /// <param name="stack">Optional stack trace</param>
        private void ActualLog(string text, LogLevel level, string error = null, string stack = null)
        {
            DateTimeOffset loglineTimestamp = DateTimeOffset.Now;
            string logFileName = $"log_{loglineTimestamp:yyyyMMdd}.log";

            string userName = ConfigRepository.HuidigeGebruiker?.Gebruikersnaam ?? "Geen gebruikersnaam";

            string logFullPath = Path.Combine(loggingPath, logFileName);

            StreamWriter writer = File.Exists(logFullPath) ? new StreamWriter(logFullPath, true) : new StreamWriter(logFullPath, false);

            writer.WriteLine($"({loglineTimestamp:yyyy-MM-dd T HH-mm-ss}) [{level.Value}] (user: {userName}) {text}"
                 + error != null ? ("\n" + error) : ""
                 + stack != null ? ("\n" + stack) : "");
            writer.Flush();
            writer.Close();
        }
    }

    /// <summary>
    /// log levels
    /// </summary>
    public class LogLevel
    {
        private LogLevel(string value) { Value = value; }

        public string Value { get; private set; }

        public static LogLevel Debug { get { return new LogLevel("Debug"); } }
        public static LogLevel Info { get { return new LogLevel("Info"); } }
        public static LogLevel Warning { get { return new LogLevel("Warning"); } }
        public static LogLevel Error { get { return new LogLevel("Error"); } }
        public static LogLevel Critical { get { return new LogLevel("Critical"); } }
    }
}
