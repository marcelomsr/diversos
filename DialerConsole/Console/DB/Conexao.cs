using System;
using System.Data.Odbc;

namespace Console.DB
{
    internal class Conexao : IDisposable
    {
        private OdbcConnection _connection;

        internal Conexao(string credencial)
        {
            try
            {
                _connection = new OdbcConnection(credencial);
                _connection.Open();

                conectado = true;
            }
            catch (OdbcException e)
            {
                conectado = false;

                throw e;
            }
        }

        public bool conectado { get; private set; }

        public OdbcDataReader executar_select(string sql, params object[] parametros)
        {
            OdbcCommand cmd = _connection.CreateCommand();
            cmd.CommandTimeout = 0;
            cmd.CommandText = String.Format(sql, parametros);

            return cmd.ExecuteReader();
        }

        public void Dispose()
        {
            _connection.Close();
            _connection.Dispose();
        }
    }
}
