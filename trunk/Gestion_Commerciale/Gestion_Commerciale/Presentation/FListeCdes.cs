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
        private String cde_select;

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
            lvcdes.FullRowSelect = true;
        }

        /// <summary>
        /// Affiche la liste de commandes dans la ListView en fonction des Checkboxes
        /// </summary>
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
                if (!CB_Numero.Checked && !CB_NumeroVendeur.Checked && !CB_NumeroClient.Checked && !CB_DateCommande.Checked &&
                    !CB_Facture.Checked && !CB_Facture.Checked)
                {
                    DialogResult check_incorrect;
                    lvcdes.Visible = false;
                    check_incorrect = MessageBox.Show("Vous devez cocher un attribut de commande à afficher, au moins.", "Impossibilté d'afficher la liste", MessageBoxButtons.OK);                        
                }
                else
                {
                    lvcdes.Visible = true;
                }
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
            AfficherListe();
        }

        private void BT_Modifier_Click(object sender, EventArgs e)
        {
            FModifCde fmc;

            if (this.cde_select == null)
            {
                DialogResult selectionner_cde;
                selectionner_cde = MessageBox.Show("Selectionner une commande à modifier", "Commande non-selectionnée", MessageBoxButtons.OK);
            }
            else
            {
                fmc = new FModifCde(cde_select);
                fmc.ShowDialog();
                AfficherListe();
            }

        }

        private void lvcdes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvcdes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.cde_select = e.Item.Text;
        }

        private void BT_Supprimer_Click(object sender, EventArgs e)
        {
            FSupprCde fsc;
            if (this.cde_select == null)
            {
                DialogResult selectionner_cde;
                selectionner_cde = MessageBox.Show("Selectionner une commande à supprimer", "Commande non-selectionnée", MessageBoxButtons.OK);
            }
            else
            {
                fsc = new FSupprCde(cde_select);
                fsc.ShowDialog();
                AfficherListe();
            }
        }

    }
}
