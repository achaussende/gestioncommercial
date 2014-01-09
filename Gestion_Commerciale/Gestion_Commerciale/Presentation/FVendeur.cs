using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MesErreurs;
using Metier;

namespace Gestion_Commerciale.Presentation
{
    public partial class FVendeur : Form
    {
        public FVendeur()
        {
            InitializeComponent();

            List<String> mesNumeros;
            try
            {
                Vendeur unVendeur = new Vendeur();
                // Lecture classique
                CB_ListeVendeurs.DataSource = unVendeur.LectureNoVendeur();

                mesNumeros = unVendeur.LectureNoVendeur();

                // Lecture à partir d’un data source
                CB_ListeVendeurs.DataSource = unVendeur.LectureNoVendeur();
            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }

        /// <summary>
        /// Fermeture de la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bt_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Bt_Interroger_Click(object sender, EventArgs e)
        {
            string numVendeur;
            Vendeur unVendeur = new Vendeur();
            Vendeur unVendeurCherche;
            try
            {
                numVendeur = CB_ListeVendeurs.Text;
                unVendeurCherche = unVendeur.RechercheUnVendeur(numVendeur);
                LB_NO_VENDEUR.Text = numVendeur;
                LB_NOM.Text = unVendeur.Nom_vendeur;
                LB_PRENOM.Text = unVendeur.Prenom_vendeur;
                LB_NO_CHEF_EQ.Text = unVendeur.No_chef_eq;
                LB_DATE_EMBAU.Text = unVendeur.Date_embau;
                LB_VILLE.Text = unVendeur.Ville_vend;
                LB_COMMISSION.Text = unVendeur.Commission;
            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }

        private void CB_ListeVendeurs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
