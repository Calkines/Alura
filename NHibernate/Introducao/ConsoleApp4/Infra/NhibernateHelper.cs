using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleApp4.Infra {
    public class NhibernateHelper {
        public static Configuration RecuperaConfiguracao() {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());           
            return cfg;
        }

        public static void GeraSchema() {
            Configuration cfg = RecuperaConfiguracao();            
            new SchemaExport(cfg).Create(true, true);
        }
    }
}
