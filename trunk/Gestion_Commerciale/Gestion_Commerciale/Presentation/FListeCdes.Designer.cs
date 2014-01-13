namespace Gestion_Commerciale.Presentation
{
    partial class FListeCdes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvcdes = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Numero = new System.Windows.Forms.CheckBox();
            this.CB_NumeroClient = new System.Windows.Forms.CheckBox();
            this.CB_NumeroVendeur = new System.Windows.Forms.CheckBox();
            this.CB_DateCommande = new System.Windows.Forms.CheckBox();
            this.CB_Facture = new System.Windows.Forms.CheckBox();
            this.BT_Ajouter = new System.Windows.Forms.Button();
            this.BT_Modifier = new System.Windows.Forms.Button();
            this.BT_Supprimer = new System.Windows.Forms.Button();
            this.BT_Details = new System.Windows.Forms.Button();
            this.BT_AfficherListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvcdes
            // 
            this.lvcdes.Location = new System.Drawing.Point(12, 38);
            this.lvcdes.MultiSelect = false;
            this.lvcdes.Name = "lvcdes";
            this.lvcdes.Size = new System.Drawing.Size(658, 374);
            this.lvcdes.TabIndex = 0;
            this.lvcdes.UseCompatibleStateImageBehavior = false;
            this.lvcdes.Visible = false;
            this.lvcdes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvcdes_ItemSelectionChanged);
            this.lvcdes.SelectedIndexChanged += new System.EventHandler(this.lvcdes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtres :";
            // 
            // CB_Numero
            // 
            this.CB_Numero.AutoSize = true;
            this.CB_Numero.Location = new System.Drawing.Point(58, 15);
            this.CB_Numero.Name = "CB_Numero";
            this.CB_Numero.Size = new System.Drawing.Size(63, 17);
            this.CB_Numero.TabIndex = 2;
            this.CB_Numero.Text = "Numéro";
            this.CB_Numero.UseVisualStyleBackColor = true;
            // 
            // CB_NumeroClient
            // 
            this.CB_NumeroClient.AutoSize = true;
            this.CB_NumeroClient.Location = new System.Drawing.Point(239, 15);
            this.CB_NumeroClient.Name = "CB_NumeroClient";
            this.CB_NumeroClient.Size = new System.Drawing.Size(92, 17);
            this.CB_NumeroClient.TabIndex = 3;
            this.CB_NumeroClient.Text = "Numéro Client";
            this.CB_NumeroClient.UseVisualStyleBackColor = true;
            // 
            // CB_NumeroVendeur
            // 
            this.CB_NumeroVendeur.AutoSize = true;
            this.CB_NumeroVendeur.Location = new System.Drawing.Point(127, 15);
            this.CB_NumeroVendeur.Name = "CB_NumeroVendeur";
            this.CB_NumeroVendeur.Size = new System.Drawing.Size(106, 17);
            this.CB_NumeroVendeur.TabIndex = 3;
            this.CB_NumeroVendeur.Text = "Numéro Vendeur";
            this.CB_NumeroVendeur.UseVisualStyleBackColor = true;
            // 
            // CB_DateCommande
            // 
            this.CB_DateCommande.AutoSize = true;
            this.CB_DateCommande.Location = new System.Drawing.Point(337, 15);
            this.CB_DateCommande.Name = "CB_DateCommande";
            this.CB_DateCommande.Size = new System.Drawing.Size(105, 17);
            this.CB_DateCommande.TabIndex = 3;
            this.CB_DateCommande.Text = "Date Commande";
            this.CB_DateCommande.UseVisualStyleBackColor = true;
            // 
            // CB_Facture
            // 
            this.CB_Facture.AutoSize = true;
            this.CB_Facture.Location = new System.Drawing.Point(448, 15);
            this.CB_Facture.Name = "CB_Facture";
            this.CB_Facture.Size = new System.Drawing.Size(62, 17);
            this.CB_Facture.TabIndex = 3;
            this.CB_Facture.Text = "Facture";
            this.CB_Facture.UseVisualStyleBackColor = true;
            // 
            // BT_Ajouter
            // 
            this.BT_Ajouter.Location = new System.Drawing.Point(12, 418);
            this.BT_Ajouter.Name = "BT_Ajouter";
            this.BT_Ajouter.Size = new System.Drawing.Size(109, 23);
            this.BT_Ajouter.TabIndex = 4;
            this.BT_Ajouter.Text = "Ajouter Commande";
            this.BT_Ajouter.UseVisualStyleBackColor = true;
            this.BT_Ajouter.Click += new System.EventHandler(this.BT_Ajouter_Click);
            // 
            // BT_Modifier
            // 
            this.BT_Modifier.Location = new System.Drawing.Point(127, 418);
            this.BT_Modifier.Name = "BT_Modifier";
            this.BT_Modifier.Size = new System.Drawing.Size(115, 23);
            this.BT_Modifier.TabIndex = 4;
            this.BT_Modifier.Text = "Modifier Commande";
            this.BT_Modifier.UseVisualStyleBackColor = true;
            this.BT_Modifier.Click += new System.EventHandler(this.BT_Modifier_Click);
            // 
            // BT_Supprimer
            // 
            this.BT_Supprimer.Location = new System.Drawing.Point(248, 418);
            this.BT_Supprimer.Name = "BT_Supprimer";
            this.BT_Supprimer.Size = new System.Drawing.Size(125, 23);
            this.BT_Supprimer.TabIndex = 4;
            this.BT_Supprimer.Text = "Supprimer Commande";
            this.BT_Supprimer.UseVisualStyleBackColor = true;
            this.BT_Supprimer.Click += new System.EventHandler(this.BT_Supprimer_Click);
            // 
            // BT_Details
            // 
            this.BT_Details.Location = new System.Drawing.Point(379, 418);
            this.BT_Details.Name = "BT_Details";
            this.BT_Details.Size = new System.Drawing.Size(104, 23);
            this.BT_Details.TabIndex = 5;
            this.BT_Details.Text = "Détails Commande";
            this.BT_Details.UseVisualStyleBackColor = true;
            // 
            // BT_AfficherListe
            // 
            this.BT_AfficherListe.Location = new System.Drawing.Point(558, 9);
            this.BT_AfficherListe.Name = "BT_AfficherListe";
            this.BT_AfficherListe.Size = new System.Drawing.Size(92, 23);
            this.BT_AfficherListe.TabIndex = 6;
            this.BT_AfficherListe.Text = "Afficher Liste";
            this.BT_AfficherListe.UseVisualStyleBackColor = true;
            this.BT_AfficherListe.Click += new System.EventHandler(this.BT_AfficherListe_Click);
            // 
            // FListeCdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 445);
            this.Controls.Add(this.BT_AfficherListe);
            this.Controls.Add(this.BT_Details);
            this.Controls.Add(this.BT_Supprimer);
            this.Controls.Add(this.BT_Modifier);
            this.Controls.Add(this.BT_Ajouter);
            this.Controls.Add(this.CB_NumeroVendeur);
            this.Controls.Add(this.CB_Facture);
            this.Controls.Add(this.CB_DateCommande);
            this.Controls.Add(this.CB_NumeroClient);
            this.Controls.Add(this.CB_Numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvcdes);
            this.Name = "FListeCdes";
            this.Text = "Liste des Commandes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvcdes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CB_Numero;
        private System.Windows.Forms.CheckBox CB_NumeroClient;
        private System.Windows.Forms.CheckBox CB_NumeroVendeur;
        private System.Windows.Forms.CheckBox CB_DateCommande;
        private System.Windows.Forms.CheckBox CB_Facture;
        private System.Windows.Forms.Button BT_Ajouter;
        private System.Windows.Forms.Button BT_Modifier;
        private System.Windows.Forms.Button BT_Supprimer;
        private System.Windows.Forms.Button BT_Details;
        private System.Windows.Forms.Button BT_AfficherListe;
    }
}