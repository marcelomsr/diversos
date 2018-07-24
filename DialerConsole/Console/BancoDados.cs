using System;
using System.Data.Odbc;

namespace Console
{
    class BancoDados
    {
        private static BancoDados _banco_dados;
        private static object _lock = new object();

        private OdbcConnection _connection;

        public static BancoDados Instance
        {
            get
            {
                if (_banco_dados == null)
                {
                    lock (_lock)
                    {
                        if (_banco_dados == null)
                            _banco_dados = new BancoDados();
                    }
                }

                return _banco_dados;
            }
        }

        ~BancoDados()
        {
        }

        public bool conectado { get; private set; }

        public void conectar(string banco, string hostname, int porta, string usuario, string senha)
        {
            try
            {
                this._connection = new OdbcConnection(
                    String.Format("driver={{IBM DB2 ODBC DRIVER}};Database={0};hostname={3};port={4};protocol=TCPIP;uid={1};pwd={2}", banco, usuario, senha, hostname, porta));

                this._connection.Open();

                this.conectado = true;
            }
            catch (OdbcException)
            {
                this.conectado = false;
            }
        }

        public OdbcDataReader executar_select(string sql, params object[] parametros)
        {
            try
            {
                OdbcCommand cmd = criar_comando();
                cmd.CommandText = String.Format(sql, parametros);

                return cmd.ExecuteReader();
            }
            catch (OdbcException e)
            {
                throw new Exception(e.Message + "\nSQL: " + sql);
            }
        }

        private OdbcCommand criar_comando()
        {
            OdbcCommand cmd = _connection.CreateCommand();
            cmd.CommandTimeout = 0;

            return cmd;
        }
    }
}
