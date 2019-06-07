using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using System;
using System.Data;
using System.Reflection;

namespace Infra.NH
{
    public static class NHibernateHelper
    {
        public static ISessionFactory CreateSessionFactory()
        {
            var mapper = new ModelMapper();
            var configuration = new Configuration();
            mapper.AddMappings(Assembly.GetExecutingAssembly().GetExportedTypes());

            configuration.DataBaseIntegration(c =>
            {
                c.ConnectionProvider<DriverConnectionProvider>();
                //c.Driver<OdbcDriver>();
                c.Driver<DB2CoreDriver>();
                c.Dialect<DB2Dialect>();
                c.ConnectionString = GetConnectionString();
                c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                c.IsolationLevel = IsolationLevel.ReadCommitted;
            });

            configuration.AddMapping(GetMappings(mapper));
            var sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory;
        }

        private static HbmMapping GetMappings(ModelMapper mapper)
        {

            HbmMapping hbmMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
            return hbmMapping;

        }

        private static string GetConnectionString()
        {
            var _alias = "DBVLD1";
            var _hostname = "10.0.68.41";
            var _porta = "60001";
            var _usuario_sistema = "SRVWCFALTRIUM";
            var _senha_sistema = "K!@qtr3fQ4CMxE";

            string connectionString = String.Format("Database={0};UserID={1};Password={2};Server={3}:{4}", _alias, _usuario_sistema, _senha_sistema, _hostname, _porta);

            return connectionString;
        }
    }
}
