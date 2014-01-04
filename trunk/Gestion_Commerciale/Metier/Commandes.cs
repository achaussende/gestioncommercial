using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metier
{
    public class Commandes
    {
        private String no_command;
        private String date_cde;
        private String no_vendeur;
        private String no_client;

        private String facture;
        public String No_command
        {
          get { return no_command; }
          set { no_command = value; }
        }
        public String Date_cde
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

        public Commandes(int hashCode, String no_command, String date_cde,
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
    }
}
