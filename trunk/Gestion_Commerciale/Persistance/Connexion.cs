using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Utilitaires;
using MesErreurs;

namespace Persistance
{
    public class Connexion
    {
        private static MySql.Data.MySqlClient.MySqlConnection macnx;
        private static Connexion instance;
        /// <summary>
        ///
        /// </summary>
        ///
        /// Impossible de créer un objet connexion
        ///
        private Connexion()
        {
        }
        
        public MySqlConnection getConnexion()
        {
            try
            {
                string bddCourante = ConfigurationManager.AppSettings["bddCourante"];
                string strConnexion = ConfigurationManager.AppSettings[bddCourante];
                macnx = new MySqlConnection(strConnexion);
                macnx.Open();
                return macnx;
            }
            catch (MySqlException err)
            {
                throw new MonException("", "Erreur d'acces à la base de Gestion des frais",
                err.Message);
            }
        }
        /// <summary>
        /// On crée le singleton
        /// </summary>
        public static Connexion getInstance()
        {
            if (instance == null)
                instance = new Connexion();
            return instance;
        }

        /// <summary>
        /// Fermeture de la connexion
        /// </summary>
        public static void closeConnexion()
        {
            macnx.Close();
        }
    }
}
