using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MesErreurs;
using Persistance;
using MySql.Data.MySqlClient;

namespace Metier
{
    public class Detail_Cde
    {
        private String no_command;
        private String no_article;
        private String qte_cde;
        private String livree;

        public String Livree
        {
            get { return livree; }
            set { livree = value; }
        }
        public String No_command
        {
            get { return no_command; }
            set { no_command = value; }
        }
        public String No_article
        {
            get { return no_article; }
            set { no_article = value; }
        }
        public String Qte_cde
        {
            get { return qte_cde; }
            set { qte_cde = value; }
        }

        public Detail_Cde(String no_command, String no_article, String qte_cde, String livree)
        {
            this.no_command = no_command;
            this.no_article = no_article;
            this.qte_cde = qte_cde;
            this.livree = livree;
        }

        public Detail_Cde()
        { }

        /// <summary>
        /// Récupère tous les détails de commande identifiée par son numéro
        /// </summary>
        /// <param name="no_command">Numéro de la commande dont on doit récupérer les détails</param>
        /// <returns>Liste de Detail_Cde</returns>
        public List<Detail_Cde> recupererDetailCde(String no_command)
        {
            Detail_Cde detail_cde;
            String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreurs sur la récupération des détails de la commande",
                "Detail_Cde.recupererDetailCde");
            Connexion uneconnexion = Connexion.getInstance();
            MySqlConnection cnx = uneconnexion.getConnexion();
            mysql = "SELECT NO_COMMAND, NO_ARTICLE, QTE_CDEE, LIVREE ";
            mysql += "FROM DETAIL_CDE WHERE NO_COMMAND = ':numero' ";
            mysql = mysql.Replace(":numero", no_command);

            try
            {
                dt = DbInterface.Lecture(mysql, er);
                List<Detail_Cde> mesDetailsCde = new List<Detail_Cde>();

                foreach (DataRow dataRow in dt.Rows)
                {
                    detail_cde = new Detail_Cde(dataRow[0].ToString(), dataRow[1].ToString(),
                        dataRow[2].ToString(), dataRow[3].ToString());
                    mesDetailsCde.Add(detail_cde);
                }
                return mesDetailsCde;
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }
    }
}
