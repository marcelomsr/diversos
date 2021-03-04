using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MyLibraryCore.Test
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void MeasurePerformance_IsCorrect()
		{
			long elapsedMilliseconds = 0;
			long elapsedTicks = 0;

			SimpleFunctions.MeasurePerformance(
				delegate ()
				{
					Thread.Sleep(1);
				}, ref elapsedMilliseconds, ref elapsedTicks);

			Assert.Positive(elapsedMilliseconds);
			Assert.Positive(elapsedTicks);
		}
	}
}