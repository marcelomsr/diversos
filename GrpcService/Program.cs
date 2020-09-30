using System;

using NLog;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;

namespace GrpcService
{
	public class Program
	{
		private static async Task Main(string[] args)
		{
			ConfigLog();

			var isService = !(Debugger.IsAttached || args.Contains("--console"));

			var builder = CreateHostBuilder(args);

			if (isService)
			{
				await builder.RunAsServiceAsync();
			}
			else
			{
				await builder.RunConsoleAsync();
			}
		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.UseWindowsService() // Habilita rodar como windows service
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});

		private static void ConfigLog()
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
		}
	}
}
