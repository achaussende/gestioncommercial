using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Utilitaires;
using MesErreurs;
using Persistance;

namespace Metier
{
    public class FermetureApplication
    {
        static public bool getFermeture()
        {
            try
            {
                Connexion.closeConnexion();
                return true;
            }
            catch (MonException excep)
            {
                throw excep;
            }
        }
    }
}
