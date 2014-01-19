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
    public partial class FProduitsCde : Form
    {
        public FProduitsCde(String numCde)
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");

            lvproduitcde.Items.Clear();
            lvproduitcde.View = View.Details;
            lvproduitcde.Columns.Add("Numéro Article", 100, HorizontalAlignment.Left);
            lvproduitcde.Columns.Add("Libellé", 100, HorizontalAlignment.Left);
            lvproduitcde.Columns.Add("Ville", 100, HorizontalAlignment.Left);
            lvproduitcde.Columns.Add("Prix unité", 100, HorizontalAlignment.Left);
            lvproduitcde.Columns.Add("Quantité", 100, HorizontalAlignment.Left);
            lvproduitcde.Columns.Add("Prix total", 100, HorizontalAlignment.Left);
            lvproduitcde.Columns.Add("Livré", 100, HorizontalAlignment.Left);
            lvproduitcde.FullRowSelect = true;

            LB_NoCde.Text = numCde;
            AfficherProduitsCde(numCde);
        }

        /// <summary>
        /// Affiche tous les produits relatifs à la commande identifiée par numCde
        /// </summary>
        /// <param name="no_cde">Numéro de la commande</param>
        public void AfficherProduitsCde(String no_cde)
        {
            Article unArticle = new Article();
            List<Article> mesProduitsCde;
            String numArt, libArt, qteDispo, villeArt, prixArt, interrompu;
            decimal qte, prixTotal;
            
            ListViewItem lvitem_produit;
            lvproduitcde.Items.Clear();
            lvproduitcde.Columns.Clear();
            lvproduitcde.View = View.Details;
            lvproduitcde.Columns.Add("1","Numéro Article");
            lvproduitcde.Columns.Add("2","Libellé");
            lvproduitcde.Columns.Add("3","Ville");
            lvproduitcde.Columns.Add("4","Prix unité");
            lvproduitcde.Columns.Add("5","Quantité");
            lvproduitcde.Columns.Add("6","Prix total");
            lvproduitcde.Columns.Add("7","Livré");
            try
            {
                mesProduitsCde = unArticle.recupererArticlesCde(no_cde);
                foreach (Article a in mesProduitsCde)
                {
                    numArt = a.No_article;
                    // On récupère la property NoVendeur
                    libArt = a.Lib_article;
                    qteDispo = a.Qte_dispo;
                    villeArt = a.Ville_art;
                    prixArt = a.Prix_art;
                    interrompu = a.Interrompu;
                    qte = Convert.ToDecimal(qteDispo);
                    //prixArt = prixArt.Replace(",", ".");
                    prixTotal = Convert.ToDecimal(prixArt);
                    prixTotal = prixTotal * qte;
                    
                    lvitem_produit = new ListViewItem(new string[] { numArt, libArt, villeArt, prixArt,
                        qteDispo, prixTotal.ToString(), interrompu },
                        -1, Color.Black, Color.LightGreen, null);

                    lvproduitcde.Items.Add(lvitem_produit);
                }

                lvproduitcde.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (MonException erreur)
            {
                throw erreur;
            }
        }

        private void lvdetailcde_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
