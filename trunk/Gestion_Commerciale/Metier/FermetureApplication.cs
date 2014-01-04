using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance;
using MySql.Data.MySqlClient;
using MesErreurs;

namespace Metier
{
    public class FermetureApplication
    {
        /// <summary>
        /// Tentative de connexion à la base
        /// </summary>
        /// <returns></returns>
        static public bool getFermeture()
        {
            try
            {
                //A revérifer
                Connexion macnx = Connexion.getInstance();
                MySqlConnection mysqlcnx = Connexion.getInstance().getConnexion();
                macnx.closeconnexion();
                return true;
            }
            catch (MonException excep)
            {
                throw excep;
            }
        }
    }
}
