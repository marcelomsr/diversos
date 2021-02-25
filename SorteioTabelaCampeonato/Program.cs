using MyLibrary;
using System;
using System.Collections.Generic;
using System.IO;

namespace SorteioTabelaCampeonato
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> competidores = new List<string>();
            competidores.Add("Marcelo");
            competidores.Add("Pedro Ramos");
            competidores.Add("Augusto");
            competidores.Add("Renan");
            competidores.Add("Estevão");

            competidores.Shuffle();

            int qtd_competidores = competidores.Count;

            List<string> competidores_1 = new List<string>();
            List<string> competidores_2 = new List<string>();

            definir_lista_competidores(ref competidores, ref competidores_1, ref competidores_2);

            List<string> partidas_torneio = new List<string>();

            // A quantidade de rodadas do torneio é igual a quantidade de competidores no caso de quantidade de competidores ímpar
            // No caso de quantidade de competidores par, a quantidade de rodadas é a quantidade de competidores menos 1.
            int qtd_rodadas = qtd_competidores - (competidores.Contains("Folga") ? 0 : 1);

            for (int rodada = 0; rodada < qtd_rodadas; rodada++)
            {
                // A quantidade de partidas da rodada é igual a quantidade de competidores "real" dividido por 2.
                int qtd_partidas_rodada = qtd_competidores / 2;
                string[] partidas_rodada = new string[qtd_partidas_rodada];

                for (int partida = 0, competidor = 0; partida < qtd_partidas_rodada; partida++, competidor++)
                {
                    // Se for uma partida válida, insere na rodada, senão, reduz o número da partida para não ignorar o último confronto da rodada.
                    if (competidores_2[competidor] != "Folga" && competidores_1[competidor] != "Folga")
                    {
                        partidas_rodada[partida] = String.Format("Rodada {0}: {1} vs {2}", rodada + 1, competidores_1[competidor], competidores_2[competidor]);
                    }
                    else
                    {
                        partida--;
                    }
                }

                // Pega os competidores que trocarão de lista.
                string competidor_lista1_para_lista2 = competidores_1[competidores_1.Count - 1];
                string competidor_lista2_para_lista1 = competidores_2[0];

                // Remove os competidores da lista.
                competidores_1.Remove(competidor_lista1_para_lista2);
                competidores_2.Remove(competidor_lista2_para_lista1);

                // Insere o competidor logo após o primeiro da lista.
                competidores_1.Insert(1, competidor_lista2_para_lista1);

                // Insere o competidor no final da lista.
                competidores_2.Add(competidor_lista1_para_lista2);

                partidas_torneio.AddRange(partidas_rodada);
            }

            gravar_sorteio_arquivo(partidas_torneio);

            Console.ReadLine();
        }

        private static void gravar_sorteio_arquivo(List<string> partidas_torneio)
        {
            string pathFile = @"C:\torneio.txt";

            SimpleFunctions.FileWriter(pathFile, false, null);

            foreach (string partida in partidas_torneio)
            {
                SimpleFunctions.FileWriter(pathFile, true, partida);
                Console.WriteLine(partida);
            }
        }

        private static void definir_lista_competidores(ref List<string> competidores, ref List<string> comp_1, ref List<string> comp_2)
        {
            // Se a quantidade de competidores for ímpar, insere a folga para fazer a rodada completa.
            if (competidores.Count % 2 == 1)
                competidores.Add("Folga");

            int metade = competidores.Count / 2;

            for (int i = 0; i < competidores.Count; i++)
            {
                if (i + 1 <= metade)
                    comp_1.Add(competidores[i]);
                else
                    comp_2.Add(competidores[i]);
            }
        }
    }
}
