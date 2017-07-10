using System;
using System.Collections.Generic;

namespace Lotofacil
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;

            do
            {
                List<int> numeros_sorteados = new List<int>();

                Random random = new Random();

                while (numeros_sorteados.Count < 15)
                {
                    int numero_sorteado = random.Next(1, 25);

                    if (!numeros_sorteados.Contains(numero_sorteado))
                        numeros_sorteados.Add(numero_sorteado);
                }

                numeros_sorteados.Sort();

                for (int i = 0; i < numeros_sorteados.Count; i++)
                    Console.WriteLine(numeros_sorteados[i]);

                Console.WriteLine("\nPressione \"ENTER\" para sortear novamente ou qualquer outra tecla para sair.\n");

                key = Console.ReadKey();
            }
            while (key.Key == ConsoleKey.Enter);
        }
    }
}
