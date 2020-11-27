using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devestock.Classes;
using Devestock.Classes;
using MySql.Data.MySqlClient;

namespace SmartGesture.Classes
{
    class ProduitADO : BDDClasse
    {
        public static void create(Produit produit)
        {

            try
            {
                open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO produits(reference, qte_stock, prix, emplacement, designation, etat_stock) VALUES(@reference, @qte_stock, @prix, @emplacement, @designation, @etat_stock)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@reference", produit.Get_ref());
                cmd.Parameters.AddWithValue("@qte_stock", produit.Get_qte_stock());
                cmd.Parameters.AddWithValue("@prix", produit.Get_prix());
                cmd.Parameters.AddWithValue("@emplacement",produit.Get_emplacement());
                cmd.Parameters.AddWithValue("@designation",produit.Get_designation());
                cmd.Parameters.AddWithValue("@etat_stock",produit.Get_etat_stock());
                cmd.ExecuteNonQuery();
                Console.WriteLine("produit créée");
                close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public static List<Produit> all()
        {
            try
            {
                List<Produit> produits = new List<Produit>();
                MySqlDataReader reader;
                open();
                MySqlCommand requete = new MySqlCommand("SELECT * FROM produits");
                requete.Connection = conn;
                reader = requete.ExecuteReader();
                while (reader.Read())
                {
                    Produit pro = new Produit((String)reader["reference"], (Int32)reader["qte_stock"], (Double)reader["prix"], (String)reader["emplacement"], (String)reader["designation"], (String)reader["etat_stock"]);
                    produits.Add(pro);
                }
                reader.Close();
                return produits;
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
