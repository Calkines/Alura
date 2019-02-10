using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Loja.Infra {
    public class NHibernateHelper {

        public static Configuration GetConfiguracao() {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            return cfg;
        }

        public static void SetSchema() {
            Configuration cfg = GetConfiguracao();
            new SchemaExport(cfg).Create(true, true);
        }
    }    
}
