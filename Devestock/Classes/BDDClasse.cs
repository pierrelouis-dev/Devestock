using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devestock.Classes;
namespace Devestock.Classes
{
    public class BDDClasse
    {
        public static MySqlConnection conn;

        public static void open()
        {
            string cs = @"server=localhost;userid=root;password=;database=devestock";
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("connexion ouverte");
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void close()
        {
            if (conn != null)
            {
                conn.Close();
                Console.WriteLine("Connexion fermée");
            }
        }
    }
}
