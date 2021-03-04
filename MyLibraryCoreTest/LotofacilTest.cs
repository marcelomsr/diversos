using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyLibraryCore.Test
{
	public class LotofacilTests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Lotofacil_WithNumbersParameter_OutOfRange()
		{
			// Using an anonymous delegate
			Assert.Throws<ArgumentOutOfRangeException>(
				delegate
				{
					SimpleFunctions.Lotofacil(19);
				});

			// Using a Lambda expression
			Assert.Throws<ArgumentOutOfRangeException>(
			  () =>
			  {
				  SimpleFunctions.Lotofacil(14);
			  });
		}

		[Test]
		public void Lotofacil_IsCorrect()
		{
			Assert.AreEqual(15, SimpleFunctions.Lotofacil().Count);
			Assert.AreEqual(16, SimpleFunctions.Lotofacil(16).Count);

			var sortedNumbers = SimpleFunctions.Lotofacil();
			var hashSet = new HashSet<int>(sortedNumbers);
			Assert.AreEqual(sortedNumbers.Count, hashSet.Count);

		}
	}
}