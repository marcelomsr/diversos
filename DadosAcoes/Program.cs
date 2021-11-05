using HtmlAgilityPack;
using MyLibraryCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            ObterDadosAtivos(args);
            ExibirInformacoesAtivos();
        }

        private static void ObterDadosAtivos(string[] tickers)
        {
            Parallel.ForEach(tickers, (ticker) =>
            {
                if (ticker != "ACAO" && ticker != "FII")
                {
                    Console.WriteLine($"Obtendo informações do ativo '{ticker}'");

                    if (tickers[0] == "ACAO")
                    {
                        ativos.Add(new Acao(ticker));
                    }
                    else
                    {
                        ativos.Add(new Fii(ticker));
                    }
                }
            });

            //ativos = ativos.OrderBy(ativo => ativo.ticker).ToList();

            ativos.Sort(delegate (Ativo x, Ativo y)
            {
                return string.Compare(x.ticker, y.ticker, StringComparison.Ordinal);
            });
        }

        private static void ExibirInformacoesAtivos()
        {
            try
            {
                do
                {
                    var opcaoEscolhida = ObterOpcaoEscolhida();

                    StringBuilder saidaConsole = new StringBuilder();

                    switch (int.Parse(opcaoEscolhida))
                    {
                        case 1:
                            foreach (var ativo in ativos)
                                saidaConsole.AppendLine($"{ativo.dividendYield}%");
                            break;

                        case 2:
                            foreach (var ativo in ativos)
                                saidaConsole.AppendLine($"{((Fii)ativo).valorPatrimonial}");
                            break;

                        case 3:
                            foreach (var ativo in ativos)
                                saidaConsole.AppendLine($"{ativo.proventos[0].valorPago}");
                            break;

                        case 4:
                            foreach (var ativo in ativos)
                                saidaConsole.AppendLine($"{ativo.proventos[0].dataCom.ToString("MMMM")}");
                            break;

                        case 5:
                            foreach (var ativo in ativos)
                                saidaConsole.AppendLine($"{ativo.proventos[0].dataPagamento.ToString("MMMM")}");
                            break;

                        case 6:
                            foreach (var ativo in ativos)
                                saidaConsole.AppendLine($"{ativo.proventos[0].dataCom.ToString("dd/MM/yyyy")}");
                            return;

                        case 7:
                            foreach (var ativo in ativos)
                                saidaConsole.AppendLine($"{ativo.proventos[0].dataPagamento.ToString("dd/MM/yyyy")}");
                            return;

                        case 9:
                            Environment.Exit(0);
                            return;

                        default:
                            saidaConsole.AppendLine("Opção inválida!");
                            break;
                    }

                    Console.Write(saidaConsole);
                    SimpleFunctions.SetToClipboard(saidaConsole.ToString());
                } while (true);

                // Até melhorar o que tenho hoje
                //Console.WriteLine($"{acao.ticker.PadRight(6)} {acao.valorAtual.ToString().PadLeft(8)} {acao.dividendYield.ToString().PadLeft(8)}%");    
            }
            catch (FormatException)
            {
                Console.WriteLine("Opção inválida!");
            }
            catch (Exception)
            {
                Console.WriteLine("Opção inválida para Ações!");
            }
            finally
            {
                ExibirInformacoesAtivos();
            }
        }

        private static string ObterOpcaoEscolhida()
        {
            Console.WriteLine("");
            Console.WriteLine("Escolha uma opção para exibir:");
            Console.WriteLine("1 - Dividend Yield");
            Console.WriteLine("2 - Valor Patrimonial (FII)");
            Console.WriteLine("3 - Último Valor Pago");
            Console.WriteLine("4 - Último Mês Data Com");
            Console.WriteLine("5 - Último Mês Data Pagamento");
            Console.WriteLine("6 - Última Data Com");
            Console.WriteLine("7 - Última Data Pagamento");
            Console.WriteLine("9 - Sair");
            Console.WriteLine("");

            Console.Write("Digite a opção desejada: ");

            string opcaoEscolhida = Console.ReadLine();
            Console.Clear();

            return opcaoEscolhida;

        }
    }
}
