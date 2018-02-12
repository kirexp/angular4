using System.Configuration;
using System.Linq;
using ESA.DAL.Almaty.Conventions;
using ESA.DAL.Almaty.Entities.Requests;
using ESA.DAL.Almaty.Override.Requests;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;

namespace ESA.DAL.Almaty {
    public static class Provider {
        private static ISessionFactory _factory;
        private static readonly object SyncObject = new object();

        public static ISession OpenDbSession() {
            var session = GetSessionFactory().OpenSession();
            return session;
        }

        public static ISession GetCurrentSession() {
            var currentSession = GetSessionFactory().OpenSession();

            //            var currentSession = GetSessionFactory().GetCurrentSession();
            return currentSession;
        }

        private static ISessionFactory GetSessionFactory() {
            if (_factory == null) {
                lock (SyncObject) {
                    if (_factory == null) {
                        var cfg = Fluently.Configure()
                            .Database(
                                MsSqlConfiguration.MsSql2008.ConnectionString("Data Source=.;Initial Catalog=AlmatyDDO_DB; Trusted_Connection=True")) //x => x.FromConnectionStringWithKey("ESADB")).FormatSql().ShowSql())
                            .Mappings(c =>
                                c.AutoMappings.Add(AutoMap.AssemblyOf<Request>()
                                    .Where(x => x.GetInterfaces().Contains(typeof(IEntity)))
                                    .UseOverridesFromAssemblyOf<RequestOverride>()
                                    .Conventions.Add<StringColumnLengthConvention>()
                                    .Conventions.Add<CustomForeignKeyConvention>()
                                    .Conventions.Add<EnumConvention>()))
                            .ExposeConfiguration(x => new SchemaUpdate(x).Execute(false, true))
                            .BuildConfiguration();
                        if (ConfigurationManager.AppSettings["SchemaUpdate"] == "true") {
                            _factory = cfg.BuildSessionFactory();
                        }

                    }
                }
            }
            return _factory;
        }

        public static ISession CurrentSessionContextUnbind() {
            var session = CurrentSessionContext.Unbind(GetSessionFactory());
            return session;
        }

        public static void CurrentSessionContextBind(ISession session) {
            CurrentSessionContext.Bind(session);
        }
    }
}
