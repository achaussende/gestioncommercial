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
