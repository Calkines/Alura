using ConsoleApp4.Infra;
using System;

namespace ConsoleApp4 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            NhibernateHelper.GeraSchema();
            Console.Read();            
        }
    }
}
