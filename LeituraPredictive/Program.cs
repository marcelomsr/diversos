using DB2CoreOdbc;
using Dialer4COMLib;
//using IBM.Data.DB2;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace LeituraPredictive
{
    struct Instancia
    {
        public string dsc_ip;
        public int nmr_porta_ip;
        public Dialer4COM biblioteca;
    }

    struct ResultadoListarPabx
    {
        public int cdg_interface_cti;
        public int qtd_ligacoes_predictive;
        public DateTime dta_resultado;
    }

    class Program
    {
        const int _QTD_SEG_ATUALIZAR_DADOS = 10;
        const int _QTD_SEG_ATUALIZAR_REDE = 30;
        static string _PATH = Directory.GetCurrentDirectory() + "\\resultado\\";
        static string _FILE_NAME = "resultado_listar_pabx_" + String.Format("{0}-{1}-{2}", DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year) + ".txt";

        static List<Instancia> _instancias;
        static List<Instancia> _instancias_desconectadas = new List<Instancia>();
        static List<ResultadoListarPabx> _resultado_lista_pabx;

        static void Main(string[] args)
        {
            try
            {
                obter_instancias_odbc();

                Console.WriteLine(String.Format("Endereço do arquivo: {0}", _PATH + _FILE_NAME));

                while (true)
                {
                    obter_informacoes();
                    logar_informacoes_arquivo_texto();

                    Thread.Sleep(1000 * _QTD_SEG_ATUALIZAR_DADOS);

                    conectar_instancias_desconectadas();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void logar_informacoes_arquivo_texto()
        {
            bool diretorio_existe = Directory.Exists(_PATH);

            if (!diretorio_existe)
            {
                Directory.CreateDirectory(_PATH);
            }

            StreamWriter wr = new StreamWriter(_PATH + _FILE_NAME, true);

            foreach (ResultadoListarPabx resultado in _resultado_lista_pabx)
            {
                string texto = String.Format("interface={0}; pred={1}; {2}",
                    resultado.cdg_interface_cti, resultado.qtd_ligacoes_predictive, resultado.dta_resultado);

                wr.WriteLine(texto);
            }

            wr.Close();
        }

        static void obter_instancias_odbc()
        {
            string query = "SELECT dsc_ip, nmr_porta_ip FROM cct.cct_instancia WHERE tpo_instancia = 'D' WITH UR";

            OdbcDataReader data_reader = ConnectDB2.executar_select(query) as OdbcDataReader;

            Console.WriteLine(String.Format("Query executada:\n\n{0}\n \n", query));

            _instancias = new List<Instancia>();

            while (data_reader.Read())
            {
                string dsc_ip = data_reader.GetString(0);
                int nmr_porta_ip = data_reader.GetInt16(1);

                Instancia instancia;
                instancia.dsc_ip = dsc_ip;
                instancia.nmr_porta_ip = nmr_porta_ip;

                var tokenSource = new CancellationTokenSource();
                CancellationToken token = tokenSource.Token;
                int timeOut = 1000; // 1000 ms

                bool conectado = false;
                instancia.biblioteca = new Dialer4COM();

                var task = Task.Factory.StartNew(() => 
                {                    
                    conectado = instancia.biblioteca.Conectar(instancia.dsc_ip, instancia.nmr_porta_ip, "marcelosr", "nimdarepus");
                }, token);

                if (!task.Wait(timeOut, token) || !conectado)
                {
                    Console.WriteLine(String.Format("Não foi possível conectar na instância {0}:{1}", instancia.dsc_ip, instancia.nmr_porta_ip));
                    _instancias_desconectadas.Add(instancia);
                    continue;
                }

                _instancias.Add(instancia);
            }
        }

        static void obter_informacoes()
        {
            _resultado_lista_pabx = new List<ResultadoListarPabx>();

            DateTime horario_leitura = DateTime.Now;

            foreach (Instancia instancia in _instancias)
            {
                bool retorno = instancia.biblioteca.Comando_EnviarComandoConsole("listar pabx");
                {
                    if (!retorno)
                    {
                        Console.WriteLine(String.Format("{0} - Não foi possível ''listar pabx'' da instância {1}:{2}", DateTime.Now, instancia.dsc_ip, instancia.nmr_porta_ip));
                        _instancias_desconectadas.Add(instancia);
                        continue;
                    }

                    int[] cdgs_interfaces_cti = new int[instancia.biblioteca.Comando_ObterQtdLinhas()];

                    for (int i = 0; i < instancia.biblioteca.Comando_ObterQtdLinhas(); i++)
                    {
                        ResultadoListarPabx resultado;
                        resultado.cdg_interface_cti = Convert.ToInt32(instancia.biblioteca.Comando_ObterColuna("CdgInterfaceCTI"));
                        resultado.qtd_ligacoes_predictive = Convert.ToInt32(instancia.biblioteca.Comando_ObterColuna("QtdLigDiscandoPred"));
                        resultado.dta_resultado = horario_leitura;

                        _resultado_lista_pabx.Add(resultado);

                        instancia.biblioteca.Comando_lstProximo();
                    }
                }
            }

            foreach (Instancia instancia in _instancias_desconectadas)
            {
                _instancias.Remove(instancia);
            }
        }

        private static void conectar_instancias_desconectadas()
        {
            foreach (Instancia instancia in _instancias_desconectadas)
            {
                var tokenSource = new CancellationTokenSource();
                CancellationToken token = tokenSource.Token;
                int timeOut = 100; // 1000 ms

                bool conectado = false;
                instancia.biblioteca.Desconectar();

                var task = Task.Factory.StartNew(() => 
                {                    
                    conectado = instancia.biblioteca.Conectar(instancia.dsc_ip, instancia.nmr_porta_ip, "marcelosr", "nimdarepus");
                }, token);

                if (!task.Wait(timeOut, token) || !conectado)
                {
                    Console.WriteLine(String.Format("Não foi possível conectar na instância {0}:{1}", instancia.dsc_ip, instancia.nmr_porta_ip));
                    continue;
                }
                else
                {
                    _instancias.Add(instancia);
                }
            }

            foreach (Instancia instancia in _instancias)
            {
                _instancias_desconectadas.Remove(instancia);
            }
        }
    }
}