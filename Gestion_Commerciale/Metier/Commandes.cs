using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Persistance;
using MesErreurs;

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
    }
}
