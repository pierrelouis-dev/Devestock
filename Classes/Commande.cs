using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devestock.Classes
{
    class Commande
    {
        private int id_commande;
        private String entreprise;
        private DateTime dte_commande;
        private int montant_commande;
        private List<Produit> produits;
        private Profil profil;

        public Commande(string uneentreprise, DateTime unedte_commande, int unmontant)
        {
            this.entreprise = uneentreprise;
            this.dte_commande = unedte_commande;
            this.montant_commande = unmontant;
            this.produits = new List<Produit>();
        }

        public void Set_profil(Profil pro)
        {
            this.profil = pro;
        }

        public string Get_entreprise()
        {
            return this.entreprise;
        }
        public void Set_entreprise(string uneentreprise)
        {
            this.entreprise = uneentreprise;
        }

        public DateTime Get_dte_commande()
        {
            return this.dte_commande;
        }
        public void Set_dte_commande(DateTime unedte_commande)
        {
            this.dte_commande = unedte_commande;
        }

        public int Get_montant_commande()
        {
            return this.montant_commande;
        }
        public void Set_montant_commande(int unmontant)
        {
            this.montant_commande = unmontant;
        }

        public void AddProduit(Produit p)
        {
            this.produits.Add(p);
            p.Set_commande(this);
        }
    }
}
