﻿using NUnit.Framework;

namespace MyLibraryCore.Test
{
	class FibonacciTests
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
			Assert.AreEqual(new long[] { }, SimpleFunctions.Fibonacci(0));
			Assert.AreEqual(new long[] { 0 }, SimpleFunctions.Fibonacci(1));
			Assert.AreEqual(new long[] { 0, 1 }, SimpleFunctions.Fibonacci(2));
			Assert.AreEqual(new long[] { 0, 1, 1 }, SimpleFunctions.Fibonacci(3));
			Assert.AreEqual(new long[] { 0, 1, 1, 2, 3 }, SimpleFunctions.Fibonacci(5));
			Assert.AreEqual(new long[] { 0, 1, 1, 2, 3, 5, 8 }, SimpleFunctions.Fibonacci(7));
		}
	}
}
