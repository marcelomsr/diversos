using System;
using System.Collections.Generic;

namespace EscalaBuscarPao
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;

            do
            {
                List<string> nomes_sorteados = new List<string>();
                List<string> nomes_a_sortear = new List<string>();

                nomes_a_sortear.Add("Silmar");
                nomes_a_sortear.Add("Cirillo");
                nomes_a_sortear.Add("Érika");
                nomes_a_sortear.Add("Renan");
                nomes_a_sortear.Add("Marcelo");
                nomes_a_sortear.Add("Dayane");
                nomes_a_sortear.Add("Pedro Ramos");
                nomes_a_sortear.Add("Danillo");
                nomes_a_sortear.Add("Pedro Paulo");
                nomes_a_sortear.Add("Estevão");
                nomes_a_sortear.Add("Davi");
                nomes_a_sortear.Add("André");
                nomes_a_sortear.Add("Valdemir");

                Random random = new Random();

                while (nomes_sorteados.Count < nomes_a_sortear.Count)
                {
                    int numero_sorteado = random.Next(0, nomes_a_sortear.Count);

                    if (!nomes_sorteados.Contains(nomes_a_sortear[numero_sorteado]))
                        nomes_sorteados.Add(nomes_a_sortear[numero_sorteado]);
                }

                for (int i = 0; i < nomes_sorteados.Count; i++)
                    Console.WriteLine(nomes_sorteados[i]);

                Console.WriteLine("\nPressione \"ENTER\" para sortear novamente ou qualquer outra tecla para sair.\n");

                key = Console.ReadKey();
            }
            while (key.Key == ConsoleKey.Enter);
        }
    }
}
