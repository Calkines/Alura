using Loja.Infra;
using NHibernate.Cfg;
using System;
using System.Reflection;

namespace Loja {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            //var cfg = NHibernateHelper.GetConfiguracao();
            //var session = cfg.BuildSessionFactory();
            //session.OpenSession();
            NHibernateHelper.SetSchema();
            Console.ReadLine();
        }
    }
}
