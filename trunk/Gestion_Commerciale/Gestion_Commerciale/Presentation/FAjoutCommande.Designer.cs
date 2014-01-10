namespace Gestion_Commerciale.Presentation
{
    partial class FAjoutCommande
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_NumeroCde = new System.Windows.Forms.TextBox();
            this.BT_Inserer = new System.Windows.Forms.Button();
            this.BT_Annuler = new System.Windows.Forms.Button();
            this.DTP_DateCde = new System.Windows.Forms.DateTimePicker();
            this.CB_ListeClients = new System.Windows.Forms.ComboBox();
            this.CB_ListeVendeurs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertion d\'une commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro de commande";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date de commande";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numéro de client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Numéro de vendeur";
            // 
            // TB_NumeroCde
            // 
            this.TB_NumeroCde.Location = new System.Drawing.Point(165, 72);
            this.TB_NumeroCde.Name = "TB_NumeroCde";
            this.TB_NumeroCde.Size = new System.Drawing.Size(198, 20);
            this.TB_NumeroCde.TabIndex = 2;
            // 
            // BT_Inserer
            // 
            this.BT_Inserer.Location = new System.Drawing.Point(16, 225);
            this.BT_Inserer.Name = "BT_Inserer";
            this.BT_Inserer.Size = new System.Drawing.Size(167, 23);
            this.BT_Inserer.TabIndex = 3;
            this.BT_Inserer.Text = "Insérer";
            this.BT_Inserer.UseVisualStyleBackColor = true;
            this.BT_Inserer.Click += new System.EventHandler(this.BT_Inserer_Click);
            // 
            // BT_Annuler
            // 
            this.BT_Annuler.Location = new System.Drawing.Point(189, 224);
            this.BT_Annuler.Name = "BT_Annuler";
            this.BT_Annuler.Size = new System.Drawing.Size(174, 23);
            this.BT_Annuler.TabIndex = 4;
            this.BT_Annuler.Text = "Annuler";
            this.BT_Annuler.UseVisualStyleBackColor = true;
            this.BT_Annuler.Click += new System.EventHandler(this.BT_Annuler_Click);
            // 
            // DTP_DateCde
            // 
            this.DTP_DateCde.Location = new System.Drawing.Point(165, 104);
            this.DTP_DateCde.Name = "DTP_DateCde";
            this.DTP_DateCde.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateCde.TabIndex = 5;
            // 
            // CB_ListeClients
            // 
            this.CB_ListeClients.FormattingEnabled = true;
            this.CB_ListeClients.Location = new System.Drawing.Point(165, 137);
            this.CB_ListeClients.Name = "CB_ListeClients";
            this.CB_ListeClients.Size = new System.Drawing.Size(198, 21);
            this.CB_ListeClients.TabIndex = 6;
            // 
            // CB_ListeVendeurs
            // 
            this.CB_ListeVendeurs.FormattingEnabled = true;
            this.CB_ListeVendeurs.Location = new System.Drawing.Point(165, 175);
            this.CB_ListeVendeurs.Name = "CB_ListeVendeurs";
            this.CB_ListeVendeurs.Size = new System.Drawing.Size(198, 21);
            this.CB_ListeVendeurs.TabIndex = 6;
            // 
            // FAjoutCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 265);
            this.Controls.Add(this.CB_ListeVendeurs);
            this.Controls.Add(this.CB_ListeClients);
            this.Controls.Add(this.DTP_DateCde);
            this.Controls.Add(this.BT_Annuler);
            this.Controls.Add(this.BT_Inserer);
            this.Controls.Add(this.TB_NumeroCde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAjoutCommande";
            this.Text = "Nouvelle Commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_NumeroCde;
        private System.Windows.Forms.Button BT_Inserer;
        private System.Windows.Forms.Button BT_Annuler;
        private System.Windows.Forms.DateTimePicker DTP_DateCde;
        private System.Windows.Forms.ComboBox CB_ListeClients;
        private System.Windows.Forms.ComboBox CB_ListeVendeurs;
    }
}