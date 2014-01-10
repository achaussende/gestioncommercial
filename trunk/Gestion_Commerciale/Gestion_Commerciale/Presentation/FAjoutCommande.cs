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
                CB_ListeVendeurs.DataSource = unVendeur.LectureNoVendeur();
            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }

        private void BT_Inserer_Click(object sender, EventArgs e)
        {
            Commandes uneCommande = new Commandes(TB_NumeroCde.Text, DTP_DateCde.Value,
            CB_ListeVendeurs.Text, CB_ListeClients.Text, "F");
            uneCommande.insertCommandes();
            DialogResult insertionOK;
            insertionOK = MessageBox.Show("Insertion réussie ! Voulez-vous ajouter une autre commande ?", "Ajout d'une nouvelle commande", MessageBoxButtons.YesNo);
            if (insertionOK == System.Windows.Forms.DialogResult.No)
                Close();
        }

        private void BT_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
