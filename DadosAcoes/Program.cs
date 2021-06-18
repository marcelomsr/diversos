using HtmlAgilityPack;
using MyLibraryCore;
using System;
using System.Collections.Generic;

namespace DadosAcoes
{
    class Program
    {
        //verificar já já obteve o valor no dia, para que não verifique de novo no caso de dar um erro em algum ticker e ter que recomeçar
        //melhorando a performance... e ter a opção de forçar buscar novamente, para caso mesmo já tendo obtido, eu querer testar
        public static List<Acao> acoes = new List<Acao>();
        public static string url = "https://statusinvest.com.br/acoes/";

        static void Main(string[] args)
        {
            foreach(var ticker in args)
            {
                string html = ObterMainHTML(ticker);
                ObterDadosAcao(html, ticker);
            }

            Console.WriteLine("Hello World!");
        }

        private static string ObterMainHTML(string ticker)
        {
            string html = "";
            SimpleFunctions.GetHtml(url + ticker, ref html);

            int inicio = html.IndexOf("<main");
            html = html.Substring(inicio);

            int fim = html.IndexOf("</main>");
            html = html.Substring(0, fim);

            return html;
        }

        private static void ObterDadosAcao(string html, string ticker)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var acao = new Acao();
            acao.ticker = ticker;

            int nmrNo = 1;
            foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//strong[@class='" + "value" + "']"))
            {
                if (nmrNo == 1)
                    acao.valorAtual = Convert.ToDouble(node.InnerText);

                if (nmrNo == 4 && node.InnerText != "-")
                    acao.dividendYield = Convert.ToDouble(node.InnerText);

                nmrNo++;

                if (nmrNo == 5)
                    break;
            }

            // Até melhorar o que tenho hoje
            //Console.WriteLine($"{acao.ticker.PadRight(6)} {acao.valorAtual.ToString().PadLeft(8)} {acao.dividendYield.ToString().PadLeft(8)}%");
            Console.WriteLine($"{acao.dividendYield}%");

            acoes.Add(acao);
        }
    }    
}
