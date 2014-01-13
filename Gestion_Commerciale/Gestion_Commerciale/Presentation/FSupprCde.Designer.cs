namespace Gestion_Commerciale.Presentation
{
    partial class FSupprCde
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
            this.BT_Annuler = new System.Windows.Forms.Button();
            this.BT_Supprimer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_NoVendeur = new System.Windows.Forms.Label();
            this.LB_NoClient = new System.Windows.Forms.Label();
            this.LB_DateCommande = new System.Windows.Forms.Label();
            this.LB_Facture = new System.Windows.Forms.Label();
            this.CB_ListeCdes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BT_Annuler
            // 
            this.BT_Annuler.Location = new System.Drawing.Point(206, 221);
            this.BT_Annuler.Name = "BT_Annuler";
            this.BT_Annuler.Size = new System.Drawing.Size(134, 23);
            this.BT_Annuler.TabIndex = 20;
            this.BT_Annuler.Text = "Annuler";
            this.BT_Annuler.UseVisualStyleBackColor = true;
            this.BT_Annuler.Click += new System.EventHandler(this.BT_Annuler_Click);
            // 
            // BT_Supprimer
            // 
            this.BT_Supprimer.Location = new System.Drawing.Point(46, 221);
            this.BT_Supprimer.Name = "BT_Supprimer";
            this.BT_Supprimer.Size = new System.Drawing.Size(127, 23);
            this.BT_Supprimer.TabIndex = 21;
            this.BT_Supprimer.Text = "Supprimer";
            this.BT_Supprimer.UseVisualStyleBackColor = true;
            this.BT_Supprimer.Click += new System.EventHandler(this.BT_Supprimer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Facture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date Commande";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numéro Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Numéro Vendeur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numéro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Suppression de la commande";
            // 
            // LB_NoVendeur
            // 
            this.LB_NoVendeur.AutoSize = true;
            this.LB_NoVendeur.Location = new System.Drawing.Point(152, 103);
            this.LB_NoVendeur.Name = "LB_NoVendeur";
            this.LB_NoVendeur.Size = new System.Drawing.Size(35, 13);
            this.LB_NoVendeur.TabIndex = 22;
            this.LB_NoVendeur.Text = "label7";
            // 
            // LB_NoClient
            // 
            this.LB_NoClient.AutoSize = true;
            this.LB_NoClient.Location = new System.Drawing.Point(152, 130);
            this.LB_NoClient.Name = "LB_NoClient";
            this.LB_NoClient.Size = new System.Drawing.Size(35, 13);
            this.LB_NoClient.TabIndex = 22;
            this.LB_NoClient.Text = "label7";
            // 
            // LB_DateCommande
            // 
            this.LB_DateCommande.AutoSize = true;
            this.LB_DateCommande.Location = new System.Drawing.Point(152, 156);
            this.LB_DateCommande.Name = "LB_DateCommande";
            this.LB_DateCommande.Size = new System.Drawing.Size(35, 13);
            this.LB_DateCommande.TabIndex = 23;
            this.LB_DateCommande.Text = "label7";
            // 
            // LB_Facture
            // 
            this.LB_Facture.AutoSize = true;
            this.LB_Facture.Location = new System.Drawing.Point(152, 182);
            this.LB_Facture.Name = "LB_Facture";
            this.LB_Facture.Size = new System.Drawing.Size(35, 13);
            this.LB_Facture.TabIndex = 24;
            this.LB_Facture.Text = "label7";
            // 
            // CB_ListeCdes
            // 
            this.CB_ListeCdes.FormattingEnabled = true;
            this.CB_ListeCdes.Location = new System.Drawing.Point(155, 66);
            this.CB_ListeCdes.Name = "CB_ListeCdes";
            this.CB_ListeCdes.Size = new System.Drawing.Size(185, 21);
            this.CB_ListeCdes.TabIndex = 25;
            // 
            // FSupprCde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.CB_ListeCdes);
            this.Controls.Add(this.LB_Facture);
            this.Controls.Add(this.LB_DateCommande);
            this.Controls.Add(this.LB_NoClient);
            this.Controls.Add(this.LB_NoVendeur);
            this.Controls.Add(this.BT_Annuler);
            this.Controls.Add(this.BT_Supprimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FSupprCde";
            this.Text = "Suppression d\'une commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Annuler;
        private System.Windows.Forms.Button BT_Supprimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_NoVendeur;
        private System.Windows.Forms.Label LB_NoClient;
        private System.Windows.Forms.Label LB_DateCommande;
        private System.Windows.Forms.Label LB_Facture;
        private System.Windows.Forms.ComboBox CB_ListeCdes;
    }
}