using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Detail_Cde(int hashCode, String no_command, String no_article, String qte_cde, String livree)
        {
            this.no_command = no_command;
            this.no_article = no_article;
            this.qte_cde = qte_cde;
            this.livree = livree;
        }

        public Detail_Cde()
        { }
    }
}
