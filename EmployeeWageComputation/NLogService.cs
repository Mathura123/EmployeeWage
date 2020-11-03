using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class NLogService
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void LogDebug(string message)
        {
            ConfigNLog(@"F:\MyPrograms\Assignments\A1-EmployeeWage\EmployeeWage\EmployeeWageComputation\LogFile.TXT");
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            ConfigNLog(@"F:\MyPrograms\Assignments\A1-EmployeeWage\EmployeeWage\EmployeeWageComputation\LogFile.TXT");
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            ConfigNLog(@"F:\MyPrograms\Assignments\A1-EmployeeWage\EmployeeWage\EmployeeWageComputation\LogFile.TXT");
            logger.Info(message);
        }
        public void LogWarn(string message)
        {
            ConfigNLog(@"F:\MyPrograms\Assignments\A1-EmployeeWage\EmployeeWage\EmployeeWageComputation\LogFile.TXT");
            logger.Warn(message);
        }
        private static void ConfigNLog(string file)
        {
            var config = new NLog.Config.LoggingConfiguration();

            // Targets where to log to: File and Console
            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = file };

            // Rules for mapping loggers to targets            
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            // Apply config           
            NLog.LogManager.Configuration = config;
        }
    }
}
