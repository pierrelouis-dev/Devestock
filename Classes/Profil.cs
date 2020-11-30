using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devestock.Classes
{
    class Profil
    {
        private int id_profil;
        private String nom;
        private String prenom;
        private String email;
        private int telephone;
        private String pseudo;
        private String mdp;
        private List<Commande> commandes;


        public Profil(string unnom, string unprenom, string unemail, int untel, string unpseudo, string unmdp)
        {
            this.nom = unnom;
            this.prenom = unprenom;
            this.email = unemail;
            this.telephone = untel;
            this.pseudo = unpseudo;
            this.mdp = unmdp;
            this.commandes = new List<Commande>();
        }

        public void AddCommande(Commande com)
        {
            this.commandes.Add(com);
            com.Set_profil(this);
        }
        public string Get_nom()
        {
            return this.nom;
        }
        public void Set_nom(string unnom)
        {
            this.nom = unnom;
        }

        public string Get_prenom()
        {
            return this.prenom;
        }
        public void Set_prenom(string unprenom)
        {
            this.prenom = unprenom;
        }

        public string Get_email()
        {
            return this.email;
        }
        public void Set_email(string unemail)
        {
            this.email = unemail;
        }
        
        public int Get_telephone()
        {
            return this.telephone;
        }
        public void Set_telephone(int untel)
        {
            this.telephone = untel;
        }

        public string Get_pseudo()
        {
            return this.pseudo;
        }
        public void Set_pseudo(string unpseudo)
        {
            this.pseudo = unpseudo;
        }

        public string Get_mdp()
        {
            return this.mdp;
        }
        public void Set_mdp(string unmdp)
        {
            this.mdp = unmdp;
        }
    }
}
