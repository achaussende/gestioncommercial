using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using Utilitaires;
using MesErreurs;

namespace Persistance
{
    public class DbInterface
    {
        /// <summary>
        /// Exécution de la requête demandée en paramètre, req,
        /// /// et retour du resultat : un DataTable
        /// Si tout se passe bien la connexion est prête à être fermée
        /// par le client qui utilisera cette connexion
        /// </summary>
        /// <param name="req">RequêteMySql à exécuter</param>
        /// <returns></returns>
        public static DataTable Lecture(String req, sErreurs er)
        {
            MySqlConnection cnx = null;
            try
            {
                cnx = Connexion.getInstance().getConnexion();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;
                cmd.CommandText = req;
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                // Construire le DataSet
                DataSet ds = new DataSet();
                da.Fill(ds, "resultat");
                cnx.Close();
                // Retourner la table
                return (ds.Tables["resultat"]);
            }
            catch (MonException me)
            {
                throw (me);
            }
            catch (Exception e)
            {
                throw new MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
            finally
            {
                // S'il y a eu un problème, la connexion
                // peut être encore ouverte, dans ce cas
                // il faut la fermer.
                if (cnx != null)
                    cnx.Close();
            }
        }
    }
}
