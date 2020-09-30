using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace WindowsService
{
	static class Program
	{
		private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			var config = new NLog.Config.LoggingConfiguration();

			string filename = DateTime.Now.ToString().Replace("/", "-").Replace(":", "-");

			// Targets where to log to: File and Console
			var logfile = new NLog.Targets.FileTarget("logfile") { FileName = filename + ".txt" };
			var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

			// Rules for mapping loggers to targets            
			config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
			config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

			// Apply config           
			NLog.LogManager.Configuration = config;

			Logger.Info("Iniciou");

			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[]
			{
				new Service1()
			};
			ServiceBase.Run(ServicesToRun);
		}
	}
}
