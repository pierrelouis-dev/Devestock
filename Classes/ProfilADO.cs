using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devestock.Classes;
using MySql.Data.MySqlClient;

namespace Devestock.Classes
{
    class ProfilADO : BDDClasse
    {
        public static void create(Profil profil)
        {

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO profils(nom, prenom, email, telephone, pseudo, mdp) VALUES(@nom, @prenom, @email, @telephone, @pseudo, @mdp)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nom", profil.Get_nom());
                cmd.Parameters.AddWithValue("@prenom", profil.Get_prenom());
                cmd.Parameters.AddWithValue("@email", profil.Get_email());
                cmd.Parameters.AddWithValue("@telephone", profil.Get_telephone());
                cmd.Parameters.AddWithValue("@pseudo", profil.Get_pseudo());
                cmd.Parameters.AddWithValue("@mdp", profil.Get_mdp());
                cmd.ExecuteNonQuery();
                Console.WriteLine("profil créé");
                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public static List<Profil> all()
        {
            try
            {
                List<Profil> profils = new List<Profil>();
                MySqlDataReader reader;
                open();
                MySqlCommand requete = new MySqlCommand("SELECT * FROM profils");
                requete.Connection = conn;
                reader = requete.ExecuteReader();
                while (reader.Read())
                {
                    Profil p = new Profil((String)reader["nom"], (String)reader["prenom"], (String)reader["email"], (Int32)reader["telephone"], (String)reader["pseudo"], (String)reader["mdp"]);
                    profils.Add(p);
                }
                reader.Close();
                return profils;
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
