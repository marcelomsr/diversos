using MyLibraryCore;
using NUnit.Framework;

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
			Assert.AreEqual(5, SimpleFunctions.Fibonacci(5).Length);
			Assert.AreEqual(new long[] { 0, 1, 1, 2, 3 }, SimpleFunctions.Fibonacci(5));
			Assert.AreEqual(new long[] { 0, 1, 1, 2, 3, 5, 8 }, SimpleFunctions.Fibonacci(7));
		}
	}
}