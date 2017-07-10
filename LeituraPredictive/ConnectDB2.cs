using System;
//using IBM.Data.DB2;
using System.Data.Odbc;
using System.Data;
using System.Data.SqlClient;

namespace DB2CoreOdbc
{
    public class ConnectDB2
    {
        private string _dsn = "APNPRD";
        private string _usuario_sistema = "ADMUSR";
        private string _senha_sistema = "admlights";

        private static ConnectDB2 _conexao;

        private OdbcConnection _conn;

        public enum TipoQuery
        {
            Scalar,
            Reader,
            NonQuery
        }

        private ConnectDB2()
        {
            _conn = new OdbcConnection();

            _conn.ConnectionString = String.Format("DSN={0};UID={1};PWD={2}", _dsn, _usuario_sistema, _senha_sistema);

            abrir();
        }

        ~ConnectDB2()
        {
            fechar();
        }

        private bool abrir()
        {
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }

            return _conn.State == ConnectionState.Open;
        }

        private bool fechar()
        {
            if (_conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }

            return _conn.State != ConnectionState.Open;
        }

        public static void executar_insert(string sql)
        {
            if (_conexao == null)
            {
                _conexao = new ConnectDB2();
            }

            _conexao.executar(sql, TipoQuery.NonQuery);
        }

        public static object executar_select_scalar(string sql)
        {
            if (_conexao == null)
            {
                _conexao = new ConnectDB2();
            }

            return _conexao.executar(sql, TipoQuery.Scalar);
        }

        public static object executar_select(string sql)
        {
            if (_conexao == null)
            {
                _conexao = new ConnectDB2();
            }

            return _conexao.executar(sql, TipoQuery.Reader);
        }

        public object executar(string sql, TipoQuery tpo_query)
        {
            object objeto = null;

            OdbcCommand cmd = new OdbcCommand(sql, _conn);

            try
            {
                if (tpo_query == TipoQuery.Reader)
                {
                    objeto = cmd.ExecuteReader();
                }
                else if (tpo_query == TipoQuery.NonQuery)
                {
                    cmd.ExecuteNonQuery();
                }
                else if (tpo_query == TipoQuery.Scalar)
                {
                    objeto = cmd.ExecuteScalar();
                }
            }
            catch (OdbcException e)
            {
                throw new Exception(e.Message + "\nSQL: " + sql);
            }

            return objeto;
        }
    }
}

/*
namespace DB2Core
{
    public class ConnectDB2
    {
        private string _alias = "DBPD01";
        private string _hostname = "10.0.32.97";
        private string _porta = "60001";
        private string _usuario_sistema = "ADMUSR";
        private string _senha_sistema = "admlights";

        private static ConnectDB2 _conexao;

        private DB2Connection _cn;

        public enum TipoQuery
        {
            Scalar,
            Reader,
            NonQuery
        }

        private ConnectDB2()
        {
            _cn = new DB2Connection(
                String.Format("Database={0};UserID={1};Password={2};Server={3}:{4}", _alias, _usuario_sistema, _senha_sistema, _hostname, _porta));

            abrir();
        }

        ~ConnectDB2()
        {
            fechar();
        }

        private bool abrir()
        {
            if (!_cn.IsOpen)
            {
                _cn.Open();
            }

            return _cn.IsOpen;
        }

        private bool fechar()
        {
            if (_cn.IsOpen)
            {
                _cn.Close();
            }

            return !_cn.IsOpen;
        }

        public static void executar_insert(string sql)
        {
            if (_conexao == null)
            {
                _conexao = new ConnectDB2();
            }

            _conexao.executar(sql, TipoQuery.NonQuery);
        }

        public static object executar_select_scalar(string sql)
        {
            if (_conexao == null)
            {
                _conexao = new ConnectDB2();
            }

            return _conexao.executar(sql, TipoQuery.Scalar);
        }

        public static object executar_select(string sql)
        {
            if (_conexao == null)
            {
                _conexao = new ConnectDB2();
            }

            return _conexao.executar(sql, TipoQuery.Reader);
        }

        public object executar(string sql, TipoQuery tpo_query)
        {
            object objeto = null;

            DB2Command cmd = new DB2Command(sql, _cn);

            try
            {
                if (tpo_query == TipoQuery.Reader)
                {
                    objeto = cmd.ExecuteReader();
                }
                else if (tpo_query == TipoQuery.NonQuery)
                {
                    cmd.ExecuteNonQuery();
                }
                else if (tpo_query == TipoQuery.Scalar)
                {
                    objeto = cmd.ExecuteScalar();
                }
            }
            catch (DB2Exception e)
            {
                throw new Exception(e.Message + "\nSQL: " + sql);
            }

            return objeto;
        }
    }
}
*/