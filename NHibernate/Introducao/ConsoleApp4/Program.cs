using ConsoleApp4.Infra;
using MySql.Data.MySqlClient;
using System;

namespace ConsoleApp4 {
    class Program {
        static void Main(string[] args) {

            ////Video
            //Console.WriteLine("Hello World!");
            //NhibernateHelper.GeraSchema();



            //Configurando e entendendo o NHibernate
            MySqlConnection mySqlConnection = new MySqlConnection("Server=206.189.72.23;Database=InvestimentoDb;Uid=adm;Pwd=Adm090909;");
            mySqlConnection.Open();
            Console.WriteLine(mySqlConnection.State);

            //Criar comando para ler base
            MySqlCommand command = new MySqlCommand("", mySqlConnection);
            command.CommandText = "select * from `Usuario`";
            command.CommandType = System.Data.CommandType.Text;
            try {
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        Console.WriteLine(reader["Nome"].ToString());
                    }
                    Console.WriteLine("Fim da leitura.");
                }
            }
            catch (Exception) {

                throw;
            }
            finally {
                mySqlConnection.Close();
            }

            Console.Read();
        }
    }
}
