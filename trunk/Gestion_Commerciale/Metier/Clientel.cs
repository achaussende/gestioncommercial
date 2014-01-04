using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metier
{
    public class Clientel
    {
        private String no_client;
        private String societe;
        private String nom_cl;
        private String prenom_cl;
        private String adresse_cl;
        private String ville_cl;
        private String code_post_cl;

        public String No_client
        {
            get { return no_client; }
            set { no_client = value; }
        }
        public String Societe
        {
            get { return societe; }
            set { societe = value; }
        }
        public String Nom_cl
        {
            get { return nom_cl; }
            set { nom_cl = value; }
        }
        public String Prenom_cl
        {
            get { return prenom_cl; }
            set { prenom_cl = value; }
        }
        public String Adresse_cl
        {
            get { return adresse_cl; }
            set { adresse_cl = value; }
        }
        public String Ville_cl
        {
            get { return ville_cl; }
            set { ville_cl = value; }
        }
        public String Code_post_cl
        {
            get { return code_post_cl; }
            set { code_post_cl = value; }
        }

        public Clientel(int hashCode, String no_client, String societe, String nom_cl,
            String prenom_cl, String adresse_cl, String ville_cl, String code_post_cl)
        {
            this.no_client = no_client;
            this.societe = societe;
            this.nom_cl = nom_cl;
            this.prenom_cl = prenom_cl;
            this.adresse_cl = adresse_cl;
            this.ville_cl = ville_cl;
            this.code_post_cl = code_post_cl;
        }

        public Clientel()
        { }
    }
}
