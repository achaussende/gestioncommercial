using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Persistance;
using Utilitaires;
using MesErreurs;

namespace Metier
{
    public class Compose
    {
        private String no_compose;
        private String no_composant;
        private String qte_composant;

        public String No_compose
        {
            get { return no_compose; }
            set { no_compose = value; }
        }
        public String No_composant
        {
            get { return no_composant; }
            set { no_composant = value; }
        }
        public String Qte_composant
        {
            get { return qte_composant; }
            set { qte_composant = value; }
        }

        public Compose(int hashCode, String no_compose, String no_composant, String qte_composant)
        {
            this.no_compose = no_compose;
            this.no_composant = no_composant;
            this.qte_composant = qte_composant;
        }

        public Compose()
        { }

    }
}
