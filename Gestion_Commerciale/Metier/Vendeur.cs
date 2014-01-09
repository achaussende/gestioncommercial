using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MesErreurs;
using MySql.Data.MySqlClient;
using Persistance;

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

        public Vendeur(String no_vendeur, String nom_vendeur, String prenom_vendeur,
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
        {
            no_vendeur = "";
            nom_vendeur = "";
            prenom_vendeur = "";
            date_embau = "";
            ville_vend = "";
            no_chef_eq = "";
            salaire_vend = "";
            commission = "";
        }

        //Traitement de la classe Vendeur
        /// <summary>
        /// Lire un utilisateur sur son ID
        /// </summary>
        /// <param name="id_utilisateur">N° de l'utilisateur à lire</param>
        public List<String> LectureNoVendeur()
        {
            List<String> mesNumeros = new List<String>();
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur lecture du vendeur.",
            "Vendeur.lectureNoVendeur()");
            try
            {
                String mysql = "SELECT DISTINCT NO_VENDEUR FROM VENDEUR ORDER BY NO_VENDEUR";
                dt = DbInterface.Lecture(mysql, er);
                foreach (DataRow dataRow in dt.Rows)
                {
                    mesNumeros.Add((dataRow[0]).ToString());
                }
                return mesNumeros;
            }
            catch (MySqlException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(),
                e.Message);
            }
        }


        public Vendeur RechercheUnVendeur(String numVd)
        {
            String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur recherche d'un vendeur.",
            "Vendeur.RechercherUnVendeur()");
            try
            {
                mysql = "SELECT PRENOM_VEND,NOM_VEND,DATE_EMBAU,";
                mysql += "VILLE_VEND,NO_VEND_CHEF_EQ,SALAIRE_VEND,COMMISSION";
                mysql += " FROM VENDEUR WHERE NO_VENDEUR=':numero'";
                // On se protège de l’injection sql
                mysql = mysql.Replace(":numero", numVd);
                // On appelle la couche Persistance
                dt = DbInterface.Lecture(mysql, er);
                if (dt.IsInitialized)
                {
                    DataRow dataRow = dt.Rows[0];

                    this.no_vendeur = numVd;
                    this.nom_vendeur = dataRow[1].ToString();
                    this.prenom_vendeur = dataRow[0].ToString();
                    this.date_embau = dataRow[2].ToString();
                    this.ville_vend = dataRow[3].ToString();
                    this.no_chef_eq = dataRow[4].ToString();
                    this.salaire_vend = dataRow[5].ToString();
                    this.commission = dataRow[6].ToString();

                    return this;
                }
                else
                    return null;
            }
            catch (MySqlException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(),
                e.Message);
            }
        }
    }
}
