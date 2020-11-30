using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devestock.Classes;
using MySql.Data.MySqlClient;

namespace Devestock.Classes
{
    class CommandeADO : BDDClasse
    {
        public static void create(Commande commande)
        {

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO commande(entreprise, dte_commande, montant_commande) VALUES(@entreprise, @dte_commande, @montant_commande)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@entreprise", commande.Get_entreprise());
                cmd.Parameters.AddWithValue("@dte_commande", commande.Get_dte_commande());
                cmd.Parameters.AddWithValue("@montant_commande", commande.Get_montant_commande());
                cmd.ExecuteNonQuery();
                Console.WriteLine("commande créée");
                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public static List<Commande> all()
        {
            try
            {
                List<Commande> commandes = new List<Commande>();
                MySqlDataReader reader;
                open();
                MySqlCommand requete = new MySqlCommand("SELECT * FROM commande");
                requete.Connection = conn;
                reader = requete.ExecuteReader();
                while (reader.Read())
                {
                    Commande com = new Commande((String)reader["entreprise"], (DateTime)reader["dte_commande"], (Int32)reader["montant_commande"]);
                    commandes.Add(com);
                }
                reader.Close();
                return commandes;
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
