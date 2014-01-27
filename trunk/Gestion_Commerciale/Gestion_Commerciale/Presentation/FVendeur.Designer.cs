namespace Gestion_Commerciale.Presentation
{
    partial class FVendeur
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
            this.Tlabel_infos = new System.Windows.Forms.Label();
            this.Bt_Fermer = new System.Windows.Forms.Button();
            this.Bt_Interroger = new System.Windows.Forms.Button();
            this.CB_ListeVendeurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_NO_VENDEUR = new System.Windows.Forms.Label();
            this.LB_COMMISSION = new System.Windows.Forms.Label();
            this.LB_DATE_EMBAU = new System.Windows.Forms.Label();
            this.LB_VILLE = new System.Windows.Forms.Label();
            this.LB_NOM = new System.Windows.Forms.Label();
            this.LB_PRENOM = new System.Windows.Forms.Label();
            this.LB_NO_CHEF_EQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tlabel_infos
            // 
            this.Tlabel_infos.AutoSize = true;
            this.Tlabel_infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tlabel_infos.Location = new System.Drawing.Point(13, 13);
            this.Tlabel_infos.Name = "Tlabel_infos";
            this.Tlabel_infos.Size = new System.Drawing.Size(369, 31);
            this.Tlabel_infos.TabIndex = 1;
            this.Tlabel_infos.Text = "Informations sur le vendeur";
            // 
            // Bt_Fermer
            // 
            this.Bt_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Fermer.Location = new System.Drawing.Point(491, 20);
            this.Bt_Fermer.Name = "Bt_Fermer";
            this.Bt_Fermer.Size = new System.Drawing.Size(75, 23);
            this.Bt_Fermer.TabIndex = 2;
            this.Bt_Fermer.Text = "FERMER";
            this.Bt_Fermer.UseVisualStyleBackColor = true;
            this.Bt_Fermer.Click += new System.EventHandler(this.Bt_Fermer_Click);
            // 
            // Bt_Interroger
            // 
            this.Bt_Interroger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Interroger.Location = new System.Drawing.Point(491, 98);
            this.Bt_Interroger.Name = "Bt_Interroger";
            this.Bt_Interroger.Size = new System.Drawing.Size(75, 23);
            this.Bt_Interroger.TabIndex = 6;
            this.Bt_Interroger.Text = "Interroger";
            this.Bt_Interroger.UseVisualStyleBackColor = true;
            this.Bt_Interroger.Click += new System.EventHandler(this.Bt_Interroger_Click);
            // 
            // CB_ListeVendeurs
            // 
            this.CB_ListeVendeurs.FormattingEnabled = true;
            this.CB_ListeVendeurs.Location = new System.Drawing.Point(218, 64);
            this.CB_ListeVendeurs.Name = "CB_ListeVendeurs";
            this.CB_ListeVendeurs.Size = new System.Drawing.Size(214, 21);
            this.CB_ListeVendeurs.TabIndex = 10;
            this.CB_ListeVendeurs.SelectedIndexChanged += new System.EventHandler(this.CB_ListeVendeurs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Vendeur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "N°Vendeur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Commision";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date Embauche";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "N°Vendeur Chef Eq.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nom";
            // 
            // LB_NO_VENDEUR
            // 
            this.LB_NO_VENDEUR.AutoSize = true;
            this.LB_NO_VENDEUR.Location = new System.Drawing.Point(215, 98);
            this.LB_NO_VENDEUR.Name = "LB_NO_VENDEUR";
            this.LB_NO_VENDEUR.Size = new System.Drawing.Size(0, 13);
            this.LB_NO_VENDEUR.TabIndex = 25;
            // 
            // LB_COMMISSION
            // 
            this.LB_COMMISSION.AutoSize = true;
            this.LB_COMMISSION.Location = new System.Drawing.Point(215, 247);
            this.LB_COMMISSION.Name = "LB_COMMISSION";
            this.LB_COMMISSION.Size = new System.Drawing.Size(0, 13);
            this.LB_COMMISSION.TabIndex = 24;
            // 
            // LB_DATE_EMBAU
            // 
            this.LB_DATE_EMBAU.AutoSize = true;
            this.LB_DATE_EMBAU.Location = new System.Drawing.Point(215, 200);
            this.LB_DATE_EMBAU.Name = "LB_DATE_EMBAU";
            this.LB_DATE_EMBAU.Size = new System.Drawing.Size(0, 13);
            this.LB_DATE_EMBAU.TabIndex = 23;
            // 
            // LB_VILLE
            // 
            this.LB_VILLE.AutoSize = true;
            this.LB_VILLE.Location = new System.Drawing.Point(215, 224);
            this.LB_VILLE.Name = "LB_VILLE";
            this.LB_VILLE.Size = new System.Drawing.Size(0, 13);
            this.LB_VILLE.TabIndex = 22;
            // 
            // LB_NOM
            // 
            this.LB_NOM.AutoSize = true;
            this.LB_NOM.Location = new System.Drawing.Point(215, 121);
            this.LB_NOM.Name = "LB_NOM";
            this.LB_NOM.Size = new System.Drawing.Size(0, 13);
            this.LB_NOM.TabIndex = 20;
            // 
            // LB_PRENOM
            // 
            this.LB_PRENOM.AutoSize = true;
            this.LB_PRENOM.Location = new System.Drawing.Point(215, 146);
            this.LB_PRENOM.Name = "LB_PRENOM";
            this.LB_PRENOM.Size = new System.Drawing.Size(0, 13);
            this.LB_PRENOM.TabIndex = 21;
            // 
            // LB_NO_CHEF_EQ
            // 
            this.LB_NO_CHEF_EQ.AutoSize = true;
            this.LB_NO_CHEF_EQ.Location = new System.Drawing.Point(215, 174);
            this.LB_NO_CHEF_EQ.Name = "LB_NO_CHEF_EQ";
            this.LB_NO_CHEF_EQ.Size = new System.Drawing.Size(0, 13);
            this.LB_NO_CHEF_EQ.TabIndex = 19;
            // 
            // FVendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 273);
            this.Controls.Add(this.LB_NO_VENDEUR);
            this.Controls.Add(this.LB_COMMISSION);
            this.Controls.Add(this.LB_DATE_EMBAU);
            this.Controls.Add(this.LB_VILLE);
            this.Controls.Add(this.LB_NOM);
            this.Controls.Add(this.LB_PRENOM);
            this.Controls.Add(this.LB_NO_CHEF_EQ);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_ListeVendeurs);
            this.Controls.Add(this.Bt_Interroger);
            this.Controls.Add(this.Bt_Fermer);
            this.Controls.Add(this.Tlabel_infos);
            this.Name = "FVendeur";
            this.Text = "Fiche Vendeur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tlabel_infos;
        private System.Windows.Forms.Button Bt_Fermer;
        private System.Windows.Forms.Button Bt_Interroger;
        private System.Windows.Forms.ComboBox CB_ListeVendeurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_NO_VENDEUR;
        private System.Windows.Forms.Label LB_COMMISSION;
        private System.Windows.Forms.Label LB_DATE_EMBAU;
        private System.Windows.Forms.Label LB_VILLE;
        private System.Windows.Forms.Label LB_NOM;
        private System.Windows.Forms.Label LB_PRENOM;
        private System.Windows.Forms.Label LB_NO_CHEF_EQ;
    }
}