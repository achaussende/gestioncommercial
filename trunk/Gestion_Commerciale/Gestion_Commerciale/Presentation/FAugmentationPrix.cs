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

namespace Gestion_Commerciale.Presentation
{
    public partial class FAugmentationPrix : Form
    {
        public FAugmentationPrix()
        {
            InitializeComponent();
        }

        private void BT_Augmenter_Click(object sender, EventArgs e)
        {
            String mult = TB_Mult.Text.Replace(".", ",");
            if (!Fonction.IsPositiveDouble(mult))
            {
                DialogResult badmult = MessageBox.Show("Le multiplicateur n'est pas un nombre positif !", "Erreur de multiplication", MessageBoxButtons.OK);
            }
            else
            {
                mult = TB_Mult.Text.Replace(",", ".");
                Article.AugmenterLesPrix(mult);
                DialogResult succes = MessageBox.Show("Prix correctement augmentés", "Succès de l'augmentation", MessageBoxButtons.OK);
                Close();
            }
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
