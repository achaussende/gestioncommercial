using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using Metier;
using MesErreurs;

namespace Gestion_Commerciale.Presentation
{
    public partial class FListeCdes : Form
    {
        public FListeCdes()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            
            lvcdes.Items.Clear();
            lvcdes.View = View.Details;
            lvcdes.Columns.Add("Numéro", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Numéro Vendeur", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Numéro Client", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Date Commande", 100, HorizontalAlignment.Left);
            lvcdes.Columns.Add("Facture", 100, HorizontalAlignment.Left);
        }


        private void AfficherListe()
        {
            Commandes unecommande = new Commandes();
            List<Commandes> mesCommandes;
            string numCde, numVend, NumCli, facture, datecde;
            ListViewItem lvitem_cde;
            lvcdes.Items.Clear();
            lvcdes.Columns.Clear();
            lvcdes.View = View.Details;
            lvcdes.Columns.Add("1", "Numéro");
            lvcdes.Columns.Add("2", "Numéro Vendeur");
            lvcdes.Columns.Add("3", "Numéro Client");
            lvcdes.Columns.Add("4", "Date Commande");
            lvcdes.Columns.Add("5", "Facture");
            try
            {
                mesCommandes = unecommande.getLesCommandes();
                foreach (Commandes c in mesCommandes)
                {
                    numCde = c.No_command;
                    // On récupère la property NoVendeur
                    numVend = c.No_vendeur;
                    NumCli = c.No_client;
                    datecde = c.Date_cde.ToShortDateString();
                    facture = c.Facture;
                    lvitem_cde = new ListViewItem(new string[] { numCde, numVend, NumCli, datecde, facture }, -1, Color.Black, Color.LightGreen, null);

                    lvcdes.Items.Add(lvitem_cde);
                }
                if (!CB_Numero.Checked) lvcdes.Columns.RemoveByKey("1");
                if (!CB_NumeroVendeur.Checked) lvcdes.Columns.RemoveByKey("2");
                if (!CB_NumeroClient.Checked) lvcdes.Columns.RemoveByKey("3");
                if (!CB_DateCommande.Checked) lvcdes.Columns.RemoveByKey("4");
                if (!CB_Facture.Checked) lvcdes.Columns.RemoveByKey("5");
                lvcdes.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        private void BT_AfficherListe_Click(object sender, EventArgs e)
        {
            AfficherListe();
        }

        private void BT_Ajouter_Click(object sender, EventArgs e)
        {
            FAjoutCommande fac;
            fac = new FAjoutCommande();
            fac.ShowDialog();
        }

        private void BT_Modifier_Click(object sender, EventArgs e)
        {
            FModifCde fmc;
            fmc = new FModifCde();
            fmc.ShowDialog();
        }

        private void lvcdes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
