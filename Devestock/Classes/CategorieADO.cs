using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devestock.Classes;

namespace SmartGesture.Classes
{
    class CategorieADO : BDDClasse
    {
        public static void create(Categorie categorie)
        {

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO categories(nom) VALUES(@nom)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nom", categorie.Get_nom());
                cmd.ExecuteNonQuery();
                Console.WriteLine("Categorie créée");
                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public static List<Categorie> all()
        {
            try
            {
                List<Categorie> categories = new List<Categorie>();
                MySqlDataReader reader;
                open();
                MySqlCommand requete = new MySqlCommand("SELECT * FROM categories");
                requete.Connection = conn;
                reader = requete.ExecuteReader();
                while (reader.Read())
                {
                    Categorie c = new Categorie((String)reader["nom"], (String)reader["description"]);
                    categories.Add(c);
                }
                reader.Close();
                return categories;
            }
            catch (Exception ex)
            {
                // Affiche des erreurs
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                close();
            }
        }
    }
}
