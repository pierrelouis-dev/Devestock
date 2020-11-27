using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGesture.Classes
{
    class Categorie
    {
        private String nom;
        private String description;
        private List<Produit> produits;

        public Categorie (string unnom, string unedescription)
        {
            this.nom = unnom;
            this.description = unedescription;
            this.produits = new List<Produit>();
        }

        public void AddProduit(Produit p)
        {
            this.produits.Add(p);
            p.Set_categorie(this);
        }
        public string Get_nom()
        {
            return this.nom;
        }
        public void Set_nom(string unnom)
        {
            this.nom = unnom;
        }

        public string Get_description()
        {
            return this.description;
        }
        public void Set_description(string unedescription)
        {
            this.description = unedescription;
        }
    }
}
