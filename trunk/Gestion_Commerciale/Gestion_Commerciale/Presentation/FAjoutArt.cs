using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Metier;
using Utilitaires;

namespace Gestion_Commerciale.Presentation
{
    public partial class FAjoutArt : Form
    {
        public FAjoutArt()
        {
            InitializeComponent();

            String max = Article.maxNumeroArticle();
            int maximum = Int32.Parse(max);
            maximum++;
            max = maximum.ToString();
            TB_NumeroArt.Text = max;
            TB_NumeroArt.Enabled = false;
        }

        private void BT_Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Inserer_Click(object sender, EventArgs e)
        {
            Article unArt = new Article(TB_NumeroArt.Text, TB_Lib.Text, 
                TB_Qtedispo.Text, TB_Ville.Text, TB_PrixArt.Text, "F");
            unArt.insertArticle();
            DialogResult insertionOK;
            insertionOK = MessageBox.Show("Insertion réussie ! Voulez-vous ajouter un autre article ?", "Ajout d'un nouvel article", MessageBoxButtons.YesNo);
            if (insertionOK == System.Windows.Forms.DialogResult.No)
                Close();
        }
    }
}
