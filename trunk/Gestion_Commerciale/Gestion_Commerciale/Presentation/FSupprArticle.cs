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
    public partial class FSupprArticle : Form
    {
        public FSupprArticle()
        {
            InitializeComponent();
            try
            {
                Article unArt = new Article();
                CB_ListeNoArt.DataSource = unArt.LectureNoArticles();

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }

            LB_Libelle.Text = "";
            LB_QteDispo.Text = "";
            LB_PrixArt.Text = "";
            LB_Ville.Text = "";
            LB_Interrompu.Text = "";
        }

        public FSupprArticle(string no_art)
        {
            InitializeComponent();
            // Charge la liste de commandes disponibles à la suppression
            try
            {
                Article unArt = new Article();
                CB_ListeNoArt.DataSource = unArt.LectureNoArticles();

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }

            // Charge les détails de la commande
            Article unArticle = new Article();
            Article unArtcherche;
            try
            {
                CB_ListeNoArt.Text = no_art;
                unArtcherche = unArticle.RechercheUnArticle(no_art);
                LB_Interrompu.Text = unArtcherche.Interrompu;
                LB_Libelle.Text = unArtcherche.Lib_article;
                LB_PrixArt.Text = unArtcherche.Prix_art;
                LB_QteDispo.Text = unArtcherche.Qte_dispo;
                LB_Ville.Text = unArtcherche.Ville_art;
            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }

        private void FSupprArticle_Load(object sender, EventArgs e)
        {

        }

        private void BT_Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult config_suppr = MessageBox.Show("Voulez-vous vraiment supprimer cet article ?", "Suppression de l'article", MessageBoxButtons.YesNo);

            if (config_suppr == System.Windows.Forms.DialogResult.Yes)
            {
                Article unArt = new Article();
                unArt.SupprimerUnArticle(CB_ListeNoArt.Text);

                DialogResult supprOK = MessageBox.Show("Article supprimé avec succès ! Voulez-vous en supprimer un autre ?", "Suppresion réussie", MessageBoxButtons.YesNo);
                if (config_suppr == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Article unArticle = new Article();
                        CB_ListeNoArt.DataSource = unArt.LectureNoArticles();

                    }
                    catch (MonException exception)
                    {
                        MessageBox.Show(exception.MessageApplication(), exception.Message);
                    }

                    LB_Libelle.Text = "";
                    LB_QteDispo.Text = "";
                    LB_PrixArt.Text = "";
                    LB_Ville.Text = "";
                    LB_Interrompu.Text = "";
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

        private void CB_ListeNoArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Article unArticle = new Article();
            Article unArtcherche;
            try
            {
                string no_art = CB_ListeNoArt.Text;
                unArtcherche = unArticle.RechercheUnArticle(no_art);
                LB_Interrompu.Text = unArtcherche.Interrompu;
                LB_Libelle.Text = unArtcherche.Lib_article;
                LB_PrixArt.Text = unArtcherche.Prix_art;
                LB_QteDispo.Text = unArtcherche.Qte_dispo;
                LB_Ville.Text = unArtcherche.Ville_art;
            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }
        }
    }
}
