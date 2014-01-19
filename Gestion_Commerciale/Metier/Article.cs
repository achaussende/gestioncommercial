using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MesErreurs;
using Persistance;
using System.Data;
using MySql.Data.MySqlClient;

namespace Metier
{
    public class Article
    {
        private String no_article;
        private String lib_article;
        private String qte_dispo;
        private String ville_art;
        private String prix_art;
        private String interrompu;

        public String No_article
        {
          get { return no_article; }
          set { no_article = value; }
        }
        public String Lib_article
        {
          get { return lib_article; }
          set { lib_article = value; }
        }
        public String Qte_dispo
        {
          get { return qte_dispo; }
          set { qte_dispo = value; }
        }
        public String Ville_art
        {
            get { return ville_art; }
            set { ville_art = value; }
        }
        public String Prix_art
        {
          get { return prix_art; }
          set { prix_art = value; }
        }
        public String Interrompu
        {
          get { return interrompu; }
          set { interrompu = value; }
        }

        public Article(String no_article, String lib_article,
            String qte_dispo, String ville_art, String prix_art, String interrompu)
        {
            this.no_article = no_article;
            this.lib_article = lib_article;
            this.qte_dispo = qte_dispo;
            this.ville_art = ville_art;
            this.prix_art = prix_art;
            this.interrompu = interrompu;
        }

        public Article()
        { }

        public static void AugmenterLesPrix(String num)
        {
            String mysql;
            sErreurs er = new sErreurs("Erreur sur l'augmentation des prix", "Article.AugmenterLesPrix()");

            try
            {
                mysql = "CALL `articles_augm_prix` (numero)";
                mysql = mysql.Replace("numero", num);
                DbInterface.Ecriture(mysql, er);
            }
            catch (MonException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(),
                e.Message);
            }
        }

        /// <summary>
        /// Récupère tous les produits de la commande identifiée par son numéro
        /// </summary>
        /// <param name="no_command">Numéro de la commande dont on doit récupérer les produits</param>
        /// <returns>Liste d'Article</returns>
        public List<Article> recupererArticlesCde(String no_command)
        {
            Article unArticle;
            String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreurs sur la récupération des articles de la commande",
                "Article.recupererArticlesCde");
            Connexion uneconnexion = Connexion.getInstance();
            MySqlConnection cnx = uneconnexion.getConnexion();
            mysql = "SELECT a.NO_ARTICLE, a.LIB_ARTICLE, a.QTE_DISPO, a.VILLE_ART, a.PRIX_ART, a.INTERROMPU ";
            mysql += "FROM ARTICLES a,  DETAIL_CDE d WHERE d.NO_COMMAND = 'numero' AND a.NO_ARTICLE = d.NO_ARTICLE";
            mysql = mysql.Replace("numero", no_command);

            try
            {
                dt = DbInterface.Lecture(mysql, er);
                List<Article> mesProduitsCde = new List<Article>();

                foreach (DataRow dataRow in dt.Rows)
                {
                    unArticle = new Article(dataRow[0].ToString(), dataRow[1].ToString(),
                        dataRow[2].ToString(), dataRow[3].ToString(), dataRow[4].ToString(),
                        dataRow[5].ToString());
                    mesProduitsCde.Add(unArticle);
                }
                return mesProduitsCde;
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        } 
    }
}
