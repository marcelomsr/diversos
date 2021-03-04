using NUnit.Framework;
using System.Threading;

namespace MyLibraryCore.Test
{
	public class TimeoutTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void TimeOut_Expired()
		{
			Assert.IsTrue(SimpleFunctions.TimeOut(
				delegate ()
				{
					Thread.Sleep(500);
				}, 500));
		}

		[Test]
		public void TimeOut_NotExpired()
		{
			Assert.IsFalse(SimpleFunctions.TimeOut(
				delegate ()
				{
					Thread.Sleep(450);
				}, 500));
		}
	}
}