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

        /// <summary>
        /// Lis tous les numéros d'articles existants dans la base de données
        /// </summary>
        /// <returns>Une liste de chaînes de caractères des numéros d'articles</returns>
        public List<String> LectureNoArticles()
        {
            List<String> mesNumeros = new List<String>();
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur lecture de l'article.",
            "Article.LectureNoArticle()");
            try
            {
                String mysql = "SELECT DISTINCT NO_ARTICLE FROM ARTICLES ORDER BY NO_ARTICLE";
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
        /// Insère l'article dont les informations ont été rentrés dans les champs de l'interface
        /// </summary>
        public void insertArticle()
        {
            String mysql;
            sErreurs er = new sErreurs("Erreur lors de l'insertion de l'article",
                "Error Article.insertArticle()");
            try
            {

                mysql = "INSERT INTO COMMERCIAL.ARTICLES (NO_ARTICLE,LIB_ARTICLE,QTE_DISPO,VILLE_ART,PRIX_ART,INTERROMPU) VALUES ";
                mysql += "('no_article','lib_article','qte_dispo','ville_art','prix_art','interrompu')";
                mysql = mysql.Replace("no_article", No_article);
                mysql = mysql.Replace("lib_article", Lib_article);
                mysql = mysql.Replace("qte_dispo", Qte_dispo);
                mysql = mysql.Replace("ville_art", Ville_art);
                mysql = mysql.Replace("prix_art", Prix_art);
                mysql = mysql.Replace("interrompu", Interrompu);

                DbInterface.Ecriture(mysql, er);
            }
            catch (MonException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(),
                e.Message);
            }
        }

        /// <summary>
        /// Recherche un article en fonction de son numéro
        /// </summary>
        /// <param name="numCde">Numero de l'article à chercher</param>
        /// <returns>L'article qui porte le numéro numArt</returns>
        public Article RechercheUnArticle(String numArt)
        {
            String mysql;
            DataTable dt;
            sErreurs er = new sErreurs("Erreur sur recherche d'un article.",
            "Article.RechercheUnArticle");
            try
            {
                mysql = "SELECT NO_ARTICLE,LIB_ARTICLE,QTE_DISPO,VILLE_ART,PRIX_ART,INTERROMPU";
                mysql += " FROM ARTICLES WHERE NO_ARTICLE = 'numero' ";
                // On se protège de l’injection sql
                mysql = mysql.Replace("numero", numArt);
                // On appelle la couche Persistance
                dt = DbInterface.Lecture(mysql, er);
                if (dt.IsInitialized)
                {
                    DataRow dataRow = dt.Rows[0];
                    this.no_article = numArt;
                    this.lib_article = dataRow[1].ToString();
                    this.qte_dispo = dataRow[2].ToString();
                    this.ville_art = dataRow[3].ToString();
                    this.prix_art = dataRow[4].ToString();
                    this.interrompu = dataRow[5].ToString();
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
        /// Supprime l'article identifié par son numéro
        /// </summary>
        /// <param name="numCde">Numéro de l'article à supprimer</param>
        public void SupprimerUnArticle(String numArt)
        {
            String mysql;
            sErreurs er = new sErreurs("Erreur sur la suppression de l'article",
                "Article.SupprimerUnArticle");
            try
            {
                mysql = "DELETE FROM ARTICLES";
                mysql += " WHERE NO_ARTICLE = 'numero'";
                mysql = mysql.Replace("numero", numArt);

                DbInterface.Ecriture(mysql, er);
            }
            catch (MonException e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }

        }

        /// <summary>
        /// Récupère le dernier numéro d'article ajouté dans la base de données
        /// </summary>
        /// <returns>Dernière numéro d'article ajouté dans la base de données</returns>
        public static string maxNumeroArticle()
        {
            sErreurs er = new sErreurs("Erreur sur la récupération du dernier numéro de produit", "Article.maxNumeroArticle()");
            DataTable dt;
            string mysql = "SELECT MAX(no_article) FROM ARTICLES";
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
