using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MyLibraryCore.Test
{
	public class SortearTabelaCampeonatoTests
	{
		List<string> _competidores;

		[SetUp]
		public void Setup()
		{
			_competidores = new List<string>();
		}

		[Test]
		public void SortearTabelaCampeonato_IsValid()
		{
			Assert.Throws<ArgumentException>(
				delegate
				{
					SimpleFunctions.SortearTabelaCampeonato(_competidores);
				});

			Assert.Throws<ArgumentException>(
				delegate
				{
					_competidores.Add("Marcelo");
					SimpleFunctions.SortearTabelaCampeonato(_competidores);
				});

			Assert.Throws<ArgumentException>(
				delegate
				{
					_competidores.Add("Estevão");
					SimpleFunctions.SortearTabelaCampeonato(_competidores);
				});
		}

		[Test]
		public void SortearTabelaCampeonato_IsCorrect()
		{
			_competidores.Add("Marcelo");
			_competidores.Add("Estevão");
			_competidores.Add("Pedro Ramos");

			Assert.AreEqual(3, SimpleFunctions.SortearTabelaCampeonato(_competidores).Count);

			_competidores.Clear();
			_competidores.Add("Marcelo");
			_competidores.Add("Pedro Ramos");
			_competidores.Add("Augusto");
			_competidores.Add("Renan");
			_competidores.Add("Estevão");

			Assert.AreEqual(10, SimpleFunctions.SortearTabelaCampeonato(_competidores).Count);
		}
	}
}