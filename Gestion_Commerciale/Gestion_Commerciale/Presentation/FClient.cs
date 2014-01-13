using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilitaires;
using Metier;
using MesErreurs;

namespace Gestion_Commerciale
{
    public partial class FClient : Form
    {
        /// <summary>
        /// Constructeur de la fiche Client
        /// </summary>
        public FClient()
        {
            InitializeComponent();

            try
            {
                Clientel unClient = new Clientel();

                CB_ListeClients.DataSource = unClient.LectureNoClient();

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }

        /// <summary> 
        /// Fermer la fenêtre 
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param>
        private void Bt_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_Interroger_Click(object sender, EventArgs e)
        {
            string numCli;
            Clientel unClient = new Clientel();
            Clientel unClientCherche;
            try
            {
                numCli = CB_ListeClients.Text;
                unClientCherche = unClient.RechercheUnClient(numCli);
                LB_NOCLIENT.Text = numCli;
                LB_NOM.Text = unClientCherche.Nom_cl;
                LB_PRENOM.Text = unClientCherche.Prenom_cl;
                LB_SOCIETE.Text = unClientCherche.Societe;
                LB_ADRESSE.Text = unClientCherche.Adresse_cl;
                LB_VILLE.Text = unClientCherche.Ville_cl;
                LB_CODEPOSTAL.Text = unClientCherche.Code_post_cl;
            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }

        private void CB_ListeClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
