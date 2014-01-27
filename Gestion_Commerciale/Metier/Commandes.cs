using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Persistance;
using MesErreurs;
using Utilitaires;

using MySql.Data.MySqlClient;

namespace Metier
{
    public class Commandes
    {
        private String no_command;
        private DateTime date_cde;
        private String no_vendeur;
        private String no_client;
        private String facture;

        public String No_command
        {
            get { return no_command; }
            set { no_command = value; }
        }
        public DateTime Date_cde
        {
            get { return date_cde; }
            set { date_cde = value; }
        }
        public String No_vendeur
        {
            get { return no_vendeur; }
            set { no_vendeur = value; }
        }
        public String No_client
        {
            get { return no_client; }
            set { no_client = value; }
        }
        public String Facture
        {
            get { return facture; }
            set { facture = value; }
        }

        public Commandes(String no_command, DateTime date_cde,
            String no_vendeur, String no_client, String facture)
        {
            this.no_command = no_command;
            this.date_cde = date_cde;
            this.no_vendeur = no_vendeur;
            this.no_client = no_client;
            this.facture = facture;
        }

        public Commandes()
        { }

        // Traitements de la classe Metier Commande
        public List<Commandes> getLesCommandes()
        {
            DataTable dt;
            Connexion uneconnexion = Connexion.getInstance();
            MySqlConnection cnx = uneconnexion.getConnexion();
            String mysql = "SELECT NO_COMMAND, NO_VENDEUR, NO_CLIENT, DATE_CDE, FACTURE ";
            mysql += "FROM COMMANDES ";
            sErreurs er = new sErreurs("Erreur lors de la lecture des données", "Data reading error");
            try
            {
                dt = DbInterface.Lecture(mysql, er);
                List<Commandes> mesCdes = new List<Commandes>();

                foreach (DataRow dataRow in dt.Rows)
                {
                    Vendeur unvd = new Vendeur();
                    unvd.No_vendeur = dataRow[1].ToString();
                    Clientel uncli = new Clientel();
                    uncli.No_client = dataRow[2].ToString();

                    Commandes unecde = new Commandes(dataRow[0].ToString(), (DateTime)dataRow[3],
                        unvd.No_vendeur, uncli.No_client, dataRow[4].ToString());
                    mesCdes.Add(unecde);
                }
                return mesCdes;
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        /// <summary>
        /// Lis tous les numéros de commandes existants dans la base de données
        /// </summary>
        /// <returns>Une liste de chaînes de caractères des numéros de commandes</returns>
        public List<String> LectureNoCommandes()
        {
            List<String> mesNumeros = new List<String>();
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur lecture de la commande.",
            "Commandes.LectureNoCommandes()");
            try
            {
                String mysql = "SELECT DISTINCT NO_COMMAND FROM COMMANDES ORDER BY NO_COMMAND";
                dt = DbInterface.Lecture(mysql, er);
                foreach (DataRow dataRow in dt.Rows)
                {
                    mesNumeros.Add((dataRow[0]).ToString());
                }
                return mesNumeros;
            }
            catch (MonException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(),
                e.Message);
            }
        }

        /// <summary>
        /// Insère la commande dont les informations ont été rentrés dans les champs de l'interface
        /// </summary>
        public void insertCommandes()
        {
            String date_cde;
            String mysql;
            sErreurs er = new sErreurs("Erreur lors de l'insertion de la commande", 
                "Error Commandes.insertCommandes()");

            try
            {
                date_cde = Fonction.DateToString(this.date_cde);
               
                mysql = "INSERT INTO COMMERCIAL.COMMANDES (NO_COMMAND,NO_VENDEUR,NO_CLIENT,DATE_CDE,FACTURE) VALUES ";
                mysql += "('no_commande','no_vendeur','no_client','date_commande','facture')";
                mysql = mysql.Replace("no_commande", no_command);
                mysql = mysql.Replace("no_vendeur", no_vendeur);
                mysql = mysql.Replace("no_client", no_client);
                mysql = mysql.Replace("date_commande", date_cde);
                mysql = mysql.Replace("facture", facture);
                
                DbInterface.Ecriture(mysql, er);
            }
            catch (MonException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(),
                e.Message);
            }
        }

        /// <summary>
        /// Recherche une commande en fonction de son numéro
        /// </summary>
        /// <param name="numCde">Numero de la commande à chercher</param>
        /// <returns>La commande qui porte le numéro numCde</returns>
        public Commandes RechercheUneCommande(String numCde)
        {
            String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur recherche d'une commande.",
            "Commandes.RechercheUneCommande");
            try
            {
                mysql = "SELECT NO_COMMAND, DATE_CDE, NO_VENDEUR, NO_CLIENT, FACTURE";
                mysql += " FROM COMMANDES WHERE NO_COMMAND = 'numero' ";
                // On se protège de l’injection sql
                mysql = mysql.Replace("numero", numCde);
                // On appelle la couche Persistance
                dt = DbInterface.Lecture(mysql, er);
                if (dt.IsInitialized)
                {
                    DataRow dataRow = dt.Rows[0];
                    this.no_command = numCde;
                    this.date_cde = Fonction.StringToDate(dataRow[1].ToString());
                    this.no_vendeur = dataRow[2].ToString();
                    this.no_client = dataRow[3].ToString();
                    this.facture = dataRow[4].ToString();
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

        /// <summary>
        /// Supprime la commande identifiée par son numéro
        /// </summary>
        /// <param name="numCde">Numéro de la commande à supprimer</param>
        public void SupprimerUneCommande(String numCde)
        {
            String mysql;
            sErreurs er = new sErreurs("Erreur sur la suppression de la commande", 
                "Commandes.SupprimerUneCommande");
            try
            {
                mysql = "DELETE FROM COMMANDES";
                mysql += " WHERE commandes.NO_COMMAND = 'numero'";
                mysql = mysql.Replace("numero", numCde);

                DbInterface.Ecriture(mysql, er);
            }
            catch (MonException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(),e.Message);
            }
 
        }

        /// <summary>
        /// Récupère le dernier numéro de commande ajoutée dans la base de données
        /// </summary>
        /// <returns>Dernière numéro de commande ajoutée dans la base de données</returns>
        public static string maxNumeroCommande()
        {
            sErreurs er = new sErreurs("Erreur sur la récupération du dernier numéro de commande", "Commande.maxNumeroCommande()");
            DataTable dt;
            string mysql = "SELECT MAX(NO_COMMAND) FROM COMMANDES";
            string max;

            try
            {
                dt = DbInterface.Lecture(mysql, er);
                max = dt.Rows[0][0].ToString();
                return max;
            }
            catch (MonException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
    }
}
