using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilitaires
{
    public class Fonction
    {
                /// <summary>
        /// Convertir une chaine date de mysql en datetime
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime StringToDate(String dt)
        {
        String[] coupehr = dt.Split(' ');
        String[] coupedt = coupehr[0].Split('/');
        return new DateTime(int.Parse(coupedt[2]), int.Parse(coupedt[1]),
        int.Parse(coupedt[0]));
        }
        /// <summary>
        /// Convertir une datetime en chaine pour mysql
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static String DateToString(DateTime dt)
        {
            String retour = "";
                        retour += dt.Year + "-";
            retour += dt.Month + "-";
            retour += dt.Day + " ";
            retour += dt.Hour + ":";
            retour += dt.Minute + ":";
            retour += dt.Second;
            return retour;
        }

        /// <summary>
        /// Vérifier si une chaîne de caractères correspond à un entier positif
        /// </summary>
        /// <param name="text">Nombre sous forme de chaînes de caractère</param>
        /// <returns></returns>
        public static bool IsPositiveDouble(string text)
        {
            double value;
            value = double.Parse(text);
            return value >= 0;
       
        }
        
    }
}
