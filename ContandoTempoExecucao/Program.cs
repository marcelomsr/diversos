using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ContandoTempoExecucao
{
    public class Program
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
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();

            var lista = obter_lista();

            stopwatch2.Stop();

            Console.WriteLine(String.Format("Runtime: {0} Ticks: {1} (adiciona na lista)", stopwatch2.ElapsedMilliseconds, stopwatch2.ElapsedTicks));
            
            /******************************************/
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            var lista_yield = obter_lista_yield();            

            stopwatch.Stop();

            Console.WriteLine(String.Format("Runtime: {0} Ticks: {1} (yield)", stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks));

            /******************************************/

            return lista_yield;
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

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            lista.ForEach((Pessoa pessoa) => { nome = pessoa.Nome; });

            stopWatch.Stop();

            Console.WriteLine(String.Format("Runtime: {0} Ticks: {1} (da variável)", stopWatch.ElapsedMilliseconds, stopWatch.ElapsedTicks));

            /**************************************/

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();

            foreach (Pessoa pessoa in lista)
                nome = pessoa.Nome;

            stopWatch2.Stop();

            Console.WriteLine(String.Format("Runtime: {0} Ticks: {1} (tradicional)", stopWatch2.ElapsedMilliseconds, stopWatch2.ElapsedTicks));

            /**************************************/

            Stopwatch stopWatch3 = new Stopwatch();
            stopWatch3.Start();

            Parallel.ForEach(lista, (pessoa) =>
                {
                    nome = pessoa.Nome;
                });

            stopWatch3.Stop();

            Console.WriteLine(String.Format("Runtime: {0} Ticks: {1} (parallel)", stopWatch3.ElapsedMilliseconds, stopWatch3.ElapsedTicks));
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
