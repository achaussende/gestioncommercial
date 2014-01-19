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
    public partial class FModifCde : Form
    {
        public FModifCde()
        {
            InitializeComponent();
            this.TB_NumeroCde.ReadOnly = false;
        }
        public FModifCde(String no_cde)
        {
            InitializeComponent();
            TB_NumeroCde.Text = no_cde;
            TB_NumeroCde.ReadOnly = true;
            try
            {
                Clientel unClient = new Clientel();
                Vendeur unVendeur = new Vendeur();

                CB_ListeClients.DataSource = unClient.LectureNoClient();
                CB_ListeVendeurs.DataSource = unVendeur.LectureNoVendeur();
            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }

        private void BT_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RB_FactureTrue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RB_FactureFalse_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BT_Modifier_Click(object sender, EventArgs e)
        {
            String facture;
            if(RB_FactureTrue.Checked == true)
            {
                facture = "V";
            }
            else
            {
                facture = "F";
            }

            Commandes cde_modif = new Commandes(TB_NumeroCde.Text, DTP_DateCde.Value,
                CB_ListeVendeurs.Text, CB_ListeClients.Text, facture);
            cde_modif.SupprimerUneCommande(cde_modif.No_command);
            cde_modif.insertCommandes();

            DialogResult modifOK = MessageBox.Show("Commande modifiée !", "Modification réussie", MessageBoxButtons.OK);
            Close();
        }

    }
}
