using MyLibraryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContandoTempoExecucaoCore
{
	class Program
	{
		private static int QTD_LOOP = 10000000;
		static void Main(string[] args)
		{
			ConsoleKeyInfo key;

			do
			{
				Console.Clear();

				// Compara o tempo de retorno de uma lista, usando retorno com a criação de uma lista e de um yield.
				Console.WriteLine("---------------------------");
				Console.WriteLine("Comparando retorno de lista");
				Console.WriteLine("---------------------------");
				IEnumerable<Pessoa> lista = comparar_lista_yield();

				Console.WriteLine();

				// Compara um foreach comum, com um foreach diretamente da variável.
				Console.WriteLine("-------------------------------");
				Console.WriteLine("Comparando leitura de uma lista");
				Console.WriteLine("-------------------------------");
				comparar_foreach_comum_foreach_variavel(lista.ToList());

				Console.WriteLine();
				key = Console.ReadKey();
			}
			while (key.Key == ConsoleKey.Enter);
		}

		private static IEnumerable<Pessoa> comparar_lista_yield()
		{
			long elapsedMilliseconds = 0;
			long elapsedTicks = 0;

			SimpleFunctions.MeasurePerformance(
				delegate ()
				{
					var lista = obter_lista();
				}, ref elapsedMilliseconds, ref elapsedTicks);

			Console.WriteLine($"Runtime: {elapsedMilliseconds} Ticks: {elapsedTicks} (adiciona na lista)");

			/******************************************/

			SimpleFunctions.MeasurePerformance(
				delegate ()
				{
					var lista_yield = obter_lista_yield();
				}, ref elapsedMilliseconds, ref elapsedTicks);

			Console.WriteLine($"Runtime: {elapsedMilliseconds} Ticks: {elapsedTicks} (yield)");

			/******************************************/

			return obter_lista_yield();
		}

		private static IEnumerable<Pessoa> obter_lista_yield()
		{
			for (long i = 0; i < QTD_LOOP; i++)
			{
				Pessoa pessoa = new Pessoa();
				pessoa.Id = i;
				pessoa.Nome = "Marcelo";
				pessoa.Sexo = (i % 2 == 0) ? 'M' : 'F';
				pessoa.DDD = 11;
				pessoa.Sobrenome = "Ribeiro";
				pessoa.RG = "47.577.443-7";
				pessoa.CPF = "356.565.588-78";
				pessoa.Telefone = "(11) 97040-8829";
				pessoa.Idade = 29;

				yield return pessoa;
			}
		}

		private static IEnumerable<Pessoa> obter_lista()
		{
			var list = new List<Pessoa>();

			for (long i = 0; i < QTD_LOOP; i++)
			{
				Pessoa pessoa = new Pessoa();
				pessoa.Id = i;
				pessoa.Nome = "Marcelo";
				pessoa.Sexo = (i % 2 == 0) ? 'M' : 'F';
				pessoa.DDD = 11;
				pessoa.Sobrenome = "Ribeiro";
				pessoa.RG = "47.577.443-7";
				pessoa.CPF = "356.565.588-78";
				pessoa.Telefone = "(11) 97040-8829";
				pessoa.Idade = 29;

				list.Add(pessoa);
			}

			return list;
		}

		private static void comparar_foreach_comum_foreach_variavel(List<Pessoa> lista)
		{
			string nome = string.Empty;

			/**************************************/

			long elapsedMilliseconds = 0;
			long elapsedTicks = 0;

			SimpleFunctions.MeasurePerformance(
				delegate ()
				{
					lista.ForEach((Pessoa pessoa) => { nome = pessoa.Nome; });
				}, ref elapsedMilliseconds, ref elapsedTicks);

			Console.WriteLine($"Runtime: {elapsedMilliseconds} Ticks: {elapsedTicks} (lista.ForEach)");

			/**************************************/

			SimpleFunctions.MeasurePerformance(
				delegate ()
				{
					foreach (Pessoa pessoa in lista)
						nome = pessoa.Nome;
				}, ref elapsedMilliseconds, ref elapsedTicks);

			Console.WriteLine($"Runtime: {elapsedMilliseconds} Ticks: {elapsedTicks} (foreach)");

			/**************************************/

			SimpleFunctions.MeasurePerformance(
				delegate ()
				{
					Parallel.ForEach(lista, (pessoa) =>
					{
						nome = pessoa.Nome;
					});
				}, ref elapsedMilliseconds, ref elapsedTicks);

			Console.WriteLine($"Runtime: {elapsedMilliseconds} Ticks: {elapsedTicks} (Parallel.ForEach)");
		}
	}

	public class Pessoa
	{
		public long Id;
		public string Nome;
		public string Sobrenome;
		public char Sexo;
		public string RG;
		public String CPF;
		public int DDD;
		public String Telefone;
		public int Idade;
	}
}
