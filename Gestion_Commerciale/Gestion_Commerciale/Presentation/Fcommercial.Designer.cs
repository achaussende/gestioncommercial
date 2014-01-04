namespace Gestion_Commerciale
{
    partial class Fcommercial
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TS_Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Deconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Interroger = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_FicheClient = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_FicheVendeur = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_ListeCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Gerer = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Commande = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_AjouterCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_SupprimerCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Article = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_AjouterArticle = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_SupprimerArticle = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_AugmenterPrix = new System.Windows.Forms.ToolStripMenuItem();
            this.L_GestionCommerciale = new System.Windows.Forms.Label();
            this.lbl_etat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Fichier,
            this.TS_Interroger,
            this.TS_Gerer});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TS_Fichier
            // 
            this.TS_Fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Connexion,
            this.TS_Deconnexion,
            this.TS_Quitter});
            this.TS_Fichier.Name = "TS_Fichier";
            this.TS_Fichier.Size = new System.Drawing.Size(54, 20);
            this.TS_Fichier.Text = "Fichier";
            // 
            // TS_Connexion
            // 
            this.TS_Connexion.Name = "TS_Connexion";
            this.TS_Connexion.Size = new System.Drawing.Size(152, 22);
            this.TS_Connexion.Text = "Connexion";
            // 
            // TS_Deconnexion
            // 
            this.TS_Deconnexion.Name = "TS_Deconnexion";
            this.TS_Deconnexion.Size = new System.Drawing.Size(152, 22);
            this.TS_Deconnexion.Text = "Déconnexion";
            // 
            // TS_Quitter
            // 
            this.TS_Quitter.Name = "TS_Quitter";
            this.TS_Quitter.Size = new System.Drawing.Size(152, 22);
            this.TS_Quitter.Text = "Quitter";
            // 
            // TS_Interroger
            // 
            this.TS_Interroger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_FicheClient,
            this.TS_FicheVendeur,
            this.TS_ListeCommande});
            this.TS_Interroger.Name = "TS_Interroger";
            this.TS_Interroger.Size = new System.Drawing.Size(71, 20);
            this.TS_Interroger.Text = "Interroger";
            // 
            // MS_FicheClient
            // 
            this.MS_FicheClient.Name = "MS_FicheClient";
            this.MS_FicheClient.Size = new System.Drawing.Size(164, 22);
            this.MS_FicheClient.Text = "Fiche Client";
            this.MS_FicheClient.Click += new System.EventHandler(this.MS_FicheClient_Click);
            // 
            // TS_FicheVendeur
            // 
            this.TS_FicheVendeur.Name = "TS_FicheVendeur";
            this.TS_FicheVendeur.Size = new System.Drawing.Size(164, 22);
            this.TS_FicheVendeur.Text = "Fiche Vendeur";
            // 
            // TS_ListeCommande
            // 
            this.TS_ListeCommande.Name = "TS_ListeCommande";
            this.TS_ListeCommande.Size = new System.Drawing.Size(164, 22);
            this.TS_ListeCommande.Text = "Liste Commande";
            // 
            // TS_Gerer
            // 
            this.TS_Gerer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Commande,
            this.TS_Article,
            this.TS_AugmenterPrix});
            this.TS_Gerer.Name = "TS_Gerer";
            this.TS_Gerer.Size = new System.Drawing.Size(47, 20);
            this.TS_Gerer.Text = "Gérer";
            // 
            // TS_Commande
            // 
            this.TS_Commande.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_AjouterCommande,
            this.TS_SupprimerCommande});
            this.TS_Commande.Name = "TS_Commande";
            this.TS_Commande.Size = new System.Drawing.Size(173, 22);
            this.TS_Commande.Text = "Commande";
            // 
            // TS_AjouterCommande
            // 
            this.TS_AjouterCommande.Name = "TS_AjouterCommande";
            this.TS_AjouterCommande.Size = new System.Drawing.Size(152, 22);
            this.TS_AjouterCommande.Text = "Ajouter";
            // 
            // TS_SupprimerCommande
            // 
            this.TS_SupprimerCommande.Name = "TS_SupprimerCommande";
            this.TS_SupprimerCommande.Size = new System.Drawing.Size(152, 22);
            this.TS_SupprimerCommande.Text = "Supprimer";
            // 
            // TS_Article
            // 
            this.TS_Article.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_AjouterArticle,
            this.MS_SupprimerArticle});
            this.TS_Article.Name = "TS_Article";
            this.TS_Article.Size = new System.Drawing.Size(173, 22);
            this.TS_Article.Text = "Article";
            // 
            // TS_AjouterArticle
            // 
            this.TS_AjouterArticle.Name = "TS_AjouterArticle";
            this.TS_AjouterArticle.Size = new System.Drawing.Size(152, 22);
            this.TS_AjouterArticle.Text = "Ajouter";
            // 
            // MS_SupprimerArticle
            // 
            this.MS_SupprimerArticle.Name = "MS_SupprimerArticle";
            this.MS_SupprimerArticle.Size = new System.Drawing.Size(152, 22);
            this.MS_SupprimerArticle.Text = "Supprimer";
            // 
            // TS_AugmenterPrix
            // 
            this.TS_AugmenterPrix.Name = "TS_AugmenterPrix";
            this.TS_AugmenterPrix.Size = new System.Drawing.Size(173, 22);
            this.TS_AugmenterPrix.Text = "Augmenter les prix";
            // 
            // L_GestionCommerciale
            // 
            this.L_GestionCommerciale.AutoSize = true;
            this.L_GestionCommerciale.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_GestionCommerciale.Location = new System.Drawing.Point(84, 138);
            this.L_GestionCommerciale.Name = "L_GestionCommerciale";
            this.L_GestionCommerciale.Size = new System.Drawing.Size(456, 53);
            this.L_GestionCommerciale.TabIndex = 1;
            this.L_GestionCommerciale.Text = "GESTION COMMERCIALE";
            // 
            // lbl_etat
            // 
            this.lbl_etat.AutoSize = true;
            this.lbl_etat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_etat.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_etat.Location = new System.Drawing.Point(13, 329);
            this.lbl_etat.Name = "lbl_etat";
            this.lbl_etat.Size = new System.Drawing.Size(67, 16);
            this.lbl_etat.TabIndex = 2;
            this.lbl_etat.Text = "label_etat";
            // 
            // Fcommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 354);
            this.Controls.Add(this.lbl_etat);
            this.Controls.Add(this.L_GestionCommerciale);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fcommercial";
            this.Text = "Fenêtre principale";
            this.Load += new System.EventHandler(this.Fcommercial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TS_Fichier;
        private System.Windows.Forms.ToolStripMenuItem TS_Quitter;
        private System.Windows.Forms.ToolStripMenuItem TS_Interroger;
        private System.Windows.Forms.ToolStripMenuItem MS_FicheClient;
        private System.Windows.Forms.ToolStripMenuItem TS_FicheVendeur;
        private System.Windows.Forms.ToolStripMenuItem TS_ListeCommande;
        private System.Windows.Forms.ToolStripMenuItem TS_Gerer;
        private System.Windows.Forms.ToolStripMenuItem TS_Commande;
        private System.Windows.Forms.ToolStripMenuItem TS_AjouterCommande;
        private System.Windows.Forms.ToolStripMenuItem TS_SupprimerCommande;
        private System.Windows.Forms.ToolStripMenuItem TS_Article;
        private System.Windows.Forms.ToolStripMenuItem TS_AjouterArticle;
        private System.Windows.Forms.ToolStripMenuItem MS_SupprimerArticle;
        private System.Windows.Forms.ToolStripMenuItem TS_AugmenterPrix;
        private System.Windows.Forms.Label L_GestionCommerciale;
        private System.Windows.Forms.ToolStripMenuItem TS_Connexion;
        private System.Windows.Forms.ToolStripMenuItem TS_Deconnexion;
        private System.Windows.Forms.Label lbl_etat;

    }
}

