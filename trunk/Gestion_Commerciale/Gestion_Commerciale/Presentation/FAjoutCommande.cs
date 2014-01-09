using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Metier;
using MesErreurs;

namespace Gestion_Commerciale.Presentation
{
    public partial class FAjoutCommande : Form
    {
        public FAjoutCommande()
        {
            InitializeComponent();

            List<String> mesNumeros;
            try
            {
                Clientel unClient = new Clientel();
                Vendeur unVendeur = new Vendeur();
                // Lecture classique
                CB_ListeClients.DataSource = unClient.LectureNoClient();

                mesNumeros = unClient.LectureNoClient();

                // Lecture à partir d’un data source
                CB_ListeClients.DataSource = unClient.LectureNoClient();
                mesNumeros.Clear();
                /*CB_ListeVendeur.DataSource = unVendeur.Lecture();*/
            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }
    }
}
