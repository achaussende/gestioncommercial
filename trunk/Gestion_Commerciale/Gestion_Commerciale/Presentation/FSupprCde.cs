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
using Utilitaires;

namespace Gestion_Commerciale.Presentation
{
    public partial class FSupprCde : Form
    {
        public FSupprCde()
        {
            InitializeComponent();

            try
            {
                Commandes uneCde = new Commandes();
                CB_ListeCdes.DataSource = uneCde.LectureNoCommandes();

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }

            LB_DateCommande.Text = "";
            LB_Facture.Text = "";
            LB_NoClient.Text = "";
            LB_NoVendeur.Text = "";
        }

        public FSupprCde(String no_cde)
        {
            InitializeComponent();

            try
            {
                Commandes uneCde = new Commandes();
                CB_ListeCdes.DataSource = uneCde.LectureNoCommandes();

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
            
            Commandes uneCommande = new Commandes();
            Commandes uneCdecherche;
            try
            {
                CB_ListeCdes.Text = no_cde;
                uneCdecherche = uneCommande.RechercheUneCommande(no_cde);
                LB_NoVendeur.Text = uneCdecherche.No_vendeur;
                LB_NoClient.Text = uneCdecherche.No_client;
                LB_Facture.Text = uneCdecherche.Facture;
                LB_DateCommande.Text = Fonction.DateToString(uneCdecherche.Date_cde);
            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }

        private void BT_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult config_suppr = MessageBox.Show("Voulez-vous vraiment supprimer cette commande ?", "Suppression de la commande", MessageBoxButtons.YesNo);

            if (config_suppr == System.Windows.Forms.DialogResult.Yes)
            {
                Commandes uneCde = new Commandes();
                uneCde.SupprimerUneCommande(CB_ListeCdes.Text);

                DialogResult supprOK = MessageBox.Show("Commande supprimée avec succès ! Voulez-vous en supprimer une autre ?", "Suppresion réussie", MessageBoxButtons.YesNo);
                if (config_suppr == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Commandes uneCommande = new Commandes();
                        CB_ListeCdes.DataSource = uneCde.LectureNoCommandes();

                    }
                    catch (MonException exception)
                    {
                        MessageBox.Show(exception.MessageApplication(), exception.Message);
                    }

                    LB_DateCommande.Text = "";
                    LB_Facture.Text = "";
                    LB_NoClient.Text = "";
                    LB_NoVendeur.Text = "";
                }
                else
                {
                    Close();
                }
            }
        }

        private void BT_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
