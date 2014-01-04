using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Article(int hashCode, String no_article, String lib_article,
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
    }
}
