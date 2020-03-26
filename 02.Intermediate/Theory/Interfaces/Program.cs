using System;
using System.IO;

namespace IntermediateLevel
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            // we do this with using because we use files and the yare not part of the CLR
            // this way the compiler will automatically call the Dispose in case something went wrong
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
    public class DbMigrator
    {
        private readonly ILogger _logger;
        // this is so called dependency injection, when we use another object in the constructor
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);

            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
             the main point here is that now DbMigrator can easily switch between ConsoleLogger and FileLogger, it makes it easly scalable and maintainable 
            */
            // if we want console
            var dbMigratorC = new DbMigrator(new ConsoleLogger());
            dbMigratorC.Migrate();
            // if we want file
            var dbMigratorF = new DbMigrator(new FileLogger("C:\\Users\\Jameson\\log.txt"));
            dbMigratorF.Migrate();
        }
    }
}
