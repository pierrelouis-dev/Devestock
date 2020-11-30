using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devestock.Classes
{
    class Produit
    {
        private String reference;
        private int qte_stock;
        private Double prix;
        private String emplacement;
        private String designation;
        private String etat_stock;
        private Categorie categorie;
        private Commande commande;

        public Produit(string uneref, int uneqte_stock, double unprix, string unemplacement, string unedesignation, string unetat_stock)
        {
            this.reference = uneref;
            this.qte_stock = uneqte_stock;
            this.prix = unprix;
            this.emplacement = unemplacement;
            this.designation = unedesignation;
            this.etat_stock = unetat_stock;
        }
        public void Set_categorie(Categorie c)
        {
            this.categorie = c;
        }

        public void Set_commande(Commande com)
        {
            this.commande = com;
        }
        public string Get_ref()
        {
            return this.reference;
        }
        public void Set_ref(string uneref)
        {
            this.reference = uneref;
        }

        public int Get_qte_stock()
        {
            return this.qte_stock;
        }
        public void Set_qte_stock(int uneqte_stock)
        {
            this.qte_stock = uneqte_stock;
        }

        public double Get_prix()
        {
            return this.prix;
        }
        public void Set_prix(double unprix)
        {
            this.prix = unprix;
        }

        public string Get_emplacement()
        {
            return this.emplacement;
        }
        public void Set_emplacement(string unemplacement)
        {
            this.emplacement = unemplacement;
        }

        public string Get_designation()
        {
            return this.designation;
        }
        public void Set_designation(string unedesignation)
        {
            this.designation = unedesignation;
        }
        
        public string Get_etat_stock()
        {
            return this.etat_stock;
        }
        public void Set_etat_stock(string unetat_stock)
        {
            this.etat_stock = unetat_stock;
        }
    }
}
