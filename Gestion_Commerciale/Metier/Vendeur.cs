using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metier
{
    public class Vendeur
    {
        private String no_vendeur;
        private String nom_vendeur;
        private String prenom_vendeur;
        private String date_embau;
        private String ville_vend;
        private String no_chef_eq;
        private String salaire_vend;
        private String commission;

        public String No_vendeur
        {
            get { return no_vendeur; }
            set { no_vendeur = value; }
        }

        public String Nom_vendeur
        {
            get { return nom_vendeur; }
            set { nom_vendeur = value; }
        }

        public String Prenom_vendeur
        {
            get { return prenom_vendeur; }
            set { prenom_vendeur = value; }
        }

        public String Date_embau
        {
            get { return date_embau; }
            set { date_embau = value; }
        }

        public String Ville_vend
        {
            get { return ville_vend; }
            set { ville_vend = value; }
        }

        public String No_chef_eq
        {
            get { return no_chef_eq; }
            set { no_chef_eq = value; }
        }

        public String Salaire_vend
        {
            get { return salaire_vend; }
            set { salaire_vend = value; }
        }

        public String Commission
        {
            get { return commission; }
            set { commission = value; }
        }

        public Vendeur(int hashCode, String no_vendeur, String nom_vendeur, String prenom_vendeur,
            String date_embau, String ville_vend, String no_chef_eq, String salaire_vend, String commission)
        {
            this.no_vendeur = no_vendeur;
            this.nom_vendeur = nom_vendeur;
            this.prenom_vendeur = prenom_vendeur;
            this.date_embau = date_embau;
            this.ville_vend = ville_vend;
            this.no_chef_eq = no_chef_eq;
            this.salaire_vend = salaire_vend;
            this.commission = commission;
        }

        public Vendeur()
        { }
    }
}
