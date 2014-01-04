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

namespace CARON_CHAUSSENDE_CommercialEntity.Presentation
{
    public partial class FClient : Form
    {
        public FClient()
        {
            InitializeComponent();

            LB_NOM.Text = "";
            LB_PRENOM.Text = "";
            LB_SOCIETE.Text = "";
            LB_ADRESSE.Text = "";
            LB_VILLE.Text = "";
            LB_CODEPOSTAL.Text = "";
            Bt_Details.Visible = false;

            /*List<String> mesNumeros;
            try
            {
                Service unService = Service.getInstance();
                mesNumeros = unService.LectureNoClient();
                foreach (String item in mesNumeros)
                {
                    CB_ListeClients.Items.Add(item);
                }

            }
            catch (MonException exception)
            {
                MessageBox.Show(exception.MessageApplication(), exception.Message);
            }*/


        }

        /// <summary> 
        /// Fermer la fenêtre 
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param>
        private void Bt_Fermer_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Bt_Details_Click(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        /// <summary> 
        /// Charger les informations sur le client sélectionné dans la liste déroulante 
        /// </summary> 
        private void ActualiserListe()
        {
            /*clientel monclient = new clientel();
            Service unService = Service.getInstance();
            int index = CB_ListeClients.SelectedIndex;
            if (index != -1)
            {
                unService.RechercheUnClient(CB_ListeClients.Items[index].ToString());

                LB_NOM.Text = monclient.NOM_CL;
                LB_PRENOM.Text = monclient.PRENOM_CL;
                LB_SOCIETE.Text = monclient.SOCIETE;
                LB_ADRESSE.Text = monclient.ADRESSE_CL;
                LB_VILLE.Text = monclient.VILLE_CL;
                LB_CODEPOSTAL.Text = monclient.CODE_POST_CL;

                LB_NOCLIENT.Text = "Client n°" + CB_ListeClients.Items[index].ToString();
            }
            else
            {
                LB_NOM.Text = "";
                LB_PRENOM.Text = "";
                LB_SOCIETE.Text = "";
                LB_ADRESSE.Text = "";
                LB_VILLE.Text = "";
                LB_CODEPOSTAL.Text = "";

                LB_NOCLIENT.Text = "Veuillez choisir un client";
            }*/
        }
        private void FClient_Load(object sender, EventArgs e)
        {

        }

        private void CB_ListeClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        private void CB_ListeClients_TextChanged(object sender, EventArgs e)
        {
            ActualiserListe();
        }

        /// <summary> 
        /// empêcher la saisie à la main d'un numéro 
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void CB_ListeClients_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
