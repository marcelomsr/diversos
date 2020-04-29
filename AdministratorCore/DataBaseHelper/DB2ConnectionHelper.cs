using IBM.Data.DB2.Core;
using System;

namespace AdministratorCore.DataBaseHelper
{
    public class DB2ConnectionHelper
    {
        private struct DataBase
        {
            public string name;
            public string hostname;
            public int port;
        }

        private DB2Connection _cn;

        public enum TipoQuery
        {
            Scalar,
            Reader,
            NonQuery
        }

        public DB2ConnectionHelper(string alias_db, string user, string password)
        {
            DataBase db = GetDataBase(alias_db);

            _cn = new DB2Connection($"Database={db.name};UserID={user};Password={password};Server={db.hostname}:{db.port}");

            OpenConnection();
        }

        private DataBase GetDataBase(string alias_db)
        {            
            DataBase db = new DataBase();

            switch(alias_db.ToLower())
            {
                case "vld":
                    db.name = "DBVLD1";
                    db.hostname = "leeds.lbvdc.lbv.org.br";
                    db.port = 60001;
                    break;

                case "des":
                    db.name = "DBDES1";
                    db.hostname = "leeds.lbvdc.lbv.org.br";
                    db.port = 60004;
                    break;

                case "prd":
                    db.name = "DBPD01";
                    db.hostname = "madri.lbvdc.lbv.org.br";
                    db.port = 60001;
                    break;

                default:
                    throw new Exception("Database not recognized.");
            }

            return db;
        }

        ~DB2ConnectionHelper()
        {
            CloseConnection();
        }

        private bool OpenConnection()
        {
            if (!_cn.IsOpen)
                _cn.Open();

            return _cn.IsOpen;
        }

        private bool CloseConnection()
        {
            if (_cn.IsOpen)
                _cn.Close();

            return !_cn.IsOpen;
        }

        public bool IsOpen()
        {
            return _cn.IsOpen;
        }

        public void executar_insert(string sql)
        {
            if (!_cn.IsOpen)
                OpenConnection();

            executar(sql, TipoQuery.NonQuery);
        }

        public object executar_select_scalar(string sql)
        {
            if (!_cn.IsOpen)
                OpenConnection();

            return executar(sql, TipoQuery.Scalar);
        }

        public object executar_select(string sql)
        {
            if (!_cn.IsOpen)
                OpenConnection();

            return executar(sql, TipoQuery.Reader);
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
