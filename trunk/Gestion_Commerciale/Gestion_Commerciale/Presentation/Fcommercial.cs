using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MesErreurs;
using Persistance;
using Metier;
using Gestion_Commerciale.Presentation;

namespace Gestion_Commerciale
{
    public partial class Fcommercial : Form
    {
        public Fcommercial()
        {
            InitializeComponent();
        }

        private void Fcommercial_Load(object sender, EventArgs e)
        {
            try
            {
                bool rep;
                // on connecte l'application à la base de données
                rep = OuvertureApplication.getOuverture();
                // si la connexion a réussie : on active les menus
                if (rep)
                {
                    TS_Connexion.Enabled = false;
                    TS_Deconnexion.Enabled = true;
                    TS_Interroger.Enabled = true;
                    TS_Gerer.Enabled = true;
                    lbl_etat.Text = "Etat : en ligne";
                    lbl_etat.ForeColor = Color.DarkGreen;
                }
                // sinon on désactive les menus
                else
                {
                    TS_Connexion.Enabled = true;
                    TS_Deconnexion.Enabled = false;
                    TS_Interroger.Enabled = false;
                    TS_Gerer.Enabled = false;
                    lbl_etat.Text = "Etat : hors ligne - erreur de connexion";
                    lbl_etat.ForeColor = Color.Red;
                }
            }
            catch (MonException excep)
            {
                MessageBox.Show(excep.MessageSysteme(), "Erreur de connexion");
                TS_Connexion.Enabled = true;
                TS_Deconnexion.Enabled = false;
                TS_Interroger.Enabled = false;
                TS_Gerer.Enabled = false;
                lbl_etat.Text = excep.MessageSysteme();
                lbl_etat.ForeColor = Color.Red;
            }
        }

        private void MS_FicheClient_Click(object sender, EventArgs e)
        {
            FClient fc = new FClient();
            fc.ShowDialog();
        }

        private void TS_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TS_ListeCommande_Click(object sender, EventArgs e)
        {
            FListeCdes flc;
            flc = new FListeCdes();
            flc.ShowDialog();
        }

        private void TS_FicheVendeur_Click(object sender, EventArgs e)
        {
            FVendeur fv;
            fv = new FVendeur();
            fv.ShowDialog();
        }

        private void TS_AjouterCommande_Click(object sender, EventArgs e)
        {
            FAjoutCommande fac;
            fac = new FAjoutCommande();
            fac.ShowDialog();
        }

    }
}
