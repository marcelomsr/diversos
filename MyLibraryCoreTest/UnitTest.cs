using MyLibraryCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace MyLibraryCoreTest
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void FibonnaciIsEmpty()
		{
			Assert.IsEmpty(SimpleFunctions.Fibonacci(0));			

		}

		[Test]
		public void FibonnaciIsNotEmpty()
		{
			Assert.IsNotEmpty(SimpleFunctions.Fibonacci(1));
		}

		[Test]
		public void FibonacciIsCorrect()
		{
			Assert.AreEqual(1, SimpleFunctions.Fibonacci(1).Length);
			Assert.AreEqual(5, SimpleFunctions.Fibonacci(5).Length);

			Assert.AreEqual(new long[] { }, SimpleFunctions.Fibonacci(0));
			Assert.AreEqual(new long[] { 0 }, SimpleFunctions.Fibonacci(1));
			Assert.AreEqual(new long[] { 0, 1 }, SimpleFunctions.Fibonacci(2));
			Assert.AreEqual(new long[] { 0, 1, 1 }, SimpleFunctions.Fibonacci(3));
			Assert.AreEqual(new long[] { 0, 1, 1, 2, 3 }, SimpleFunctions.Fibonacci(5));
			Assert.AreEqual(new long[] { 0, 1, 1, 2, 3, 5, 8 }, SimpleFunctions.Fibonacci(7));
		}

		[Test]
		public void LotofacilIsCorrect()
		{
			Assert.AreEqual(15, SimpleFunctions.Lotofacil().Count);
			Assert.AreEqual(16, SimpleFunctions.Lotofacil(16).Count);

			// Using an anonymous delegate
			Assert.Throws<ArgumentOutOfRangeException>(
			delegate { SimpleFunctions.Lotofacil(19); });

			// Using a Lambda expression
			Assert.Throws<ArgumentOutOfRangeException>(
			  () => { SimpleFunctions.Lotofacil(14); });

			var sortedNumbers = SimpleFunctions.Lotofacil();
			var hashSet = new HashSet<int>(sortedNumbers);
			Assert.AreEqual(sortedNumbers.Count, hashSet.Count);

		}
	}
}