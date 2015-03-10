using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SistemaCondominioNHDAO
{
        public class FluentSessionFactory
        {
            # region Servidor LocalHost

            private static string ConnectionString  = @"Data Source=SERVIDOR-01\SQLEXPRESS;Initial Catalog=BD_Condominio;User ID=sa;Password=123;";

            #endregion

            #region Servidor Online

           // private static string ConnectionString = @"Data Source=mssql.compilandofacil.kinghost.net;Initial Catalog=compilandofacil;User ID=compilandofacil;Password=1a2b3c;";

            #endregion

            private static ISessionFactory session;

            public static ISessionFactory CriarSession()
            {
                if (session != null)
                    return session;

                IPersistenceConfigurer configDB = MsSqlConfiguration.MsSql2008.ConnectionString(ConnectionString);
                var configMap = Fluently.Configure().Database(configDB).Mappings
                                                  (m => m.FluentMappings.AddFromAssemblyOf<Mapping.tabClienteMap>());
                session = configMap.BuildSessionFactory();
                return session;
            }

            public static ISession AbrirSession()
            {
                return CriarSession().OpenSession();
            }
        
    }
}
