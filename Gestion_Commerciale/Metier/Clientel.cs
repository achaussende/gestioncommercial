using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MesErreurs;
using MySql.Data.MySqlClient;
using Persistance;
using Utilitaires;

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

        public Clientel(String no_client, String societe, String nom_cl,
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
        {
            no_client = "";
            societe = "";
            nom_cl = "";
            prenom_cl = "";
            adresse_cl = "";
            ville_cl = "";
            code_post_cl = "";
        }


        //Traitement de la classe Clientel
        /// <summary>
        /// Lire un utilisateur sur son ID
        /// </summary>
        /// <param name="id_utilisateur">N° de l'utilisateur à lire</param>
        public List<String> LectureNoClient()
        {
            List<String> mesNumeros = new List<String>();
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur lecture du client.",
            "Utilisateur.lectureClient()");
            try
            {
                String mysql = "SELECT DISTINCT NO_CLIENT FROM CLIENTEL ORDER BY NO_CLIENT";
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


        public Clientel RechercheUnClient(String numCli)
        {
            String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur recherche d'un client.",
            "Client.rechercherClient()");
            try
            {
                mysql = "SELECT SOCIETE, NOM_CL, PRENOM_CL,";
                mysql += "ADRESSE_CL, VILLE_CL, CODE_POST_CL ";
                mysql += "FROM CLIENTEL WHERE NO_CLIENT=':numero'";
                // On se protège de l’injection sql
                mysql = mysql.Replace(":numero", numCli);
                // On appelle la couche Persistance
                dt = DbInterface.Lecture(mysql, er);
                if (dt.IsInitialized)
                {
                    DataRow dataRow = dt.Rows[0];
                    this.no_client = numCli;
                    this.nom_cl = dataRow[1].ToString();
                    this.societe = dataRow[0].ToString();
                    this.prenom_cl = dataRow[2].ToString();
                    this.adresse_cl = dataRow[3].ToString();
                    this.ville_cl = dataRow[4].ToString();
                    this.code_post_cl = dataRow[5].ToString();
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
