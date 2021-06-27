using HtmlAgilityPack;
using MyLibraryCore;
using System;
using System.Collections.Generic;

using System.Text;

namespace DadosB3
{
    class Program
    {
        //verificar se já obteve o valor no dia, para que não verifique de novo no caso de dar um erro em algum ticker e ter que recomeçar
        //melhorando a performance... e ter a opção de forçar buscar novamente, para caso mesmo já tendo obtido, eu querer testar
        public static List<Ativo> ativos = new List<Ativo>();

        static void Main(string[] args)
        {

#if(DEBUG)
            //args = new string[] { "MXRF11" };
            //args = new string[] { "CPLE6" };
#endif

            foreach (var ticker in args)
            {
                if (ticker == "ACAO" || ticker == "FII")
                    continue;

                Ativo ativo;

                if (args[0] == "ACAO")
                {
                    ativo = new Acao(ticker);
                    Console.WriteLine($"{ativo.dividendYield}%");
                }
                else
                {
                    ativo = new Fii(ticker);
                    Console.WriteLine($"{((Fii)ativo).valorPatrimonial}");
                }

                // Até melhorar o que tenho hoje
                //Console.WriteLine($"{acao.ticker.PadRight(6)} {acao.valorAtual.ToString().PadLeft(8)} {acao.dividendYield.ToString().PadLeft(8)}%");                
            }

            Console.Read();
        }
    }
}
