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
            this.MS_Fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Interroger = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_FicheClient = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_FicheVendeur = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_ListeCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Gerer = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Commande = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Article = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_AjouterCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_SupprimerCommande = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_AugmenterPrix = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_AjouterArticle = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_SupprimerArticle = new System.Windows.Forms.ToolStripMenuItem();
            this.L_GestionCommerciale = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Fichier,
            this.MS_Interroger,
            this.MS_Gerer});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MS_Fichier
            // 
            this.MS_Fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Quitter});
            this.MS_Fichier.Name = "MS_Fichier";
            this.MS_Fichier.Size = new System.Drawing.Size(54, 20);
            this.MS_Fichier.Text = "Fichier";
            // 
            // MS_Quitter
            // 
            this.MS_Quitter.Name = "MS_Quitter";
            this.MS_Quitter.Size = new System.Drawing.Size(152, 22);
            this.MS_Quitter.Text = "Quitter";
            // 
            // MS_Interroger
            // 
            this.MS_Interroger.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_FicheClient,
            this.MS_FicheVendeur,
            this.MS_ListeCommande});
            this.MS_Interroger.Name = "MS_Interroger";
            this.MS_Interroger.Size = new System.Drawing.Size(71, 20);
            this.MS_Interroger.Text = "Interroger";
            // 
            // MS_FicheClient
            // 
            this.MS_FicheClient.Name = "MS_FicheClient";
            this.MS_FicheClient.Size = new System.Drawing.Size(164, 22);
            this.MS_FicheClient.Text = "Fiche Client";
            // 
            // MS_FicheVendeur
            // 
            this.MS_FicheVendeur.Name = "MS_FicheVendeur";
            this.MS_FicheVendeur.Size = new System.Drawing.Size(164, 22);
            this.MS_FicheVendeur.Text = "Fiche Vendeur";
            // 
            // MS_ListeCommande
            // 
            this.MS_ListeCommande.Name = "MS_ListeCommande";
            this.MS_ListeCommande.Size = new System.Drawing.Size(164, 22);
            this.MS_ListeCommande.Text = "Liste Commande";
            // 
            // MS_Gerer
            // 
            this.MS_Gerer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_Commande,
            this.MS_Article,
            this.MS_AugmenterPrix});
            this.MS_Gerer.Name = "MS_Gerer";
            this.MS_Gerer.Size = new System.Drawing.Size(47, 20);
            this.MS_Gerer.Text = "Gérer";
            // 
            // MS_Commande
            // 
            this.MS_Commande.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_AjouterCommande,
            this.MS_SupprimerCommande});
            this.MS_Commande.Name = "MS_Commande";
            this.MS_Commande.Size = new System.Drawing.Size(173, 22);
            this.MS_Commande.Text = "Commande";
            // 
            // MS_Article
            // 
            this.MS_Article.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_AjouterArticle,
            this.MS_SupprimerArticle});
            this.MS_Article.Name = "MS_Article";
            this.MS_Article.Size = new System.Drawing.Size(173, 22);
            this.MS_Article.Text = "Article";
            // 
            // MS_AjouterCommande
            // 
            this.MS_AjouterCommande.Name = "MS_AjouterCommande";
            this.MS_AjouterCommande.Size = new System.Drawing.Size(152, 22);
            this.MS_AjouterCommande.Text = "Ajouter";
            // 
            // MS_SupprimerCommande
            // 
            this.MS_SupprimerCommande.Name = "MS_SupprimerCommande";
            this.MS_SupprimerCommande.Size = new System.Drawing.Size(152, 22);
            this.MS_SupprimerCommande.Text = "Supprimer";
            // 
            // MS_AugmenterPrix
            // 
            this.MS_AugmenterPrix.Name = "MS_AugmenterPrix";
            this.MS_AugmenterPrix.Size = new System.Drawing.Size(173, 22);
            this.MS_AugmenterPrix.Text = "Augmenter les prix";
            // 
            // MS_AjouterArticle
            // 
            this.MS_AjouterArticle.Name = "MS_AjouterArticle";
            this.MS_AjouterArticle.Size = new System.Drawing.Size(152, 22);
            this.MS_AjouterArticle.Text = "Ajouter";
            // 
            // MS_SupprimerArticle
            // 
            this.MS_SupprimerArticle.Name = "MS_SupprimerArticle";
            this.MS_SupprimerArticle.Size = new System.Drawing.Size(152, 22);
            this.MS_SupprimerArticle.Text = "Supprimer";
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
            // Fcommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 354);
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
        private System.Windows.Forms.ToolStripMenuItem MS_Fichier;
        private System.Windows.Forms.ToolStripMenuItem MS_Quitter;
        private System.Windows.Forms.ToolStripMenuItem MS_Interroger;
        private System.Windows.Forms.ToolStripMenuItem MS_FicheClient;
        private System.Windows.Forms.ToolStripMenuItem MS_FicheVendeur;
        private System.Windows.Forms.ToolStripMenuItem MS_ListeCommande;
        private System.Windows.Forms.ToolStripMenuItem MS_Gerer;
        private System.Windows.Forms.ToolStripMenuItem MS_Commande;
        private System.Windows.Forms.ToolStripMenuItem MS_AjouterCommande;
        private System.Windows.Forms.ToolStripMenuItem MS_SupprimerCommande;
        private System.Windows.Forms.ToolStripMenuItem MS_Article;
        private System.Windows.Forms.ToolStripMenuItem MS_AjouterArticle;
        private System.Windows.Forms.ToolStripMenuItem MS_SupprimerArticle;
        private System.Windows.Forms.ToolStripMenuItem MS_AugmenterPrix;
        private System.Windows.Forms.Label L_GestionCommerciale;

    }
}

