using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Persistance;
using MySql.Data.MySqlClient;
using MesErreurs;

namespace Metier
{
    public class OuvertureApplication
    {
        /// <summary>
        /// Tentative de connexion à la base
        /// </summary>
        /// <returns></returns>
          static public bool getOuverture()
            {
                try
            {
                MySqlConnection mysqlcnx = Connexion.getInstance().getConnexion();
                return true;
            }
            catch (MonException excep)
            {
            throw excep;
            }
            }
    }
}
