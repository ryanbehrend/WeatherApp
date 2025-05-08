using System;
using System.Diagnostics;
using System.IO;

namespace FinalProject.Services
{
    public static class Logger
    {
        private static readonly object _lock = new object();
        private const string LogFile = "weather.log";

        public static void Log(string message)
        {
            var _log = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {message}";
            Debug.WriteLine($"{_log} {message}");
        }
    }
}
