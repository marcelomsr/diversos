using System.Diagnostics;
using System.ServiceProcess;

namespace WindowsService
{
	public partial class Service1 : ServiceBase
	{
		Process _process;

		public Service1()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			//sc create AltriumService binPath=C:\Users\marcelosr\Desktop\Repo\Diversos\GrpcService\bin\Debug\net5.0\GrpcService.exe

			_process.StartInfo = new ProcessStartInfo(
				@"C:\Users\marcelosr\Desktop\Repo\Diversos\GrpcService\bin\Debug\netcoreapp3.1\GrpcService.exe",
				"--console");

			_process = Process.Start(_process.StartInfo);
		}

		protected override void OnStop()
		{
			_process.Kill();
		}
	}
}
