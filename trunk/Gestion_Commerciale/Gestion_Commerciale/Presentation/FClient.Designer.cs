namespace Gestion_Commerciale
{
    partial class FClient
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
            this.CB_ListeClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bt_Interroger = new System.Windows.Forms.Button();
            this.LB_SOCIETE = new System.Windows.Forms.Label();
            this.LB_VILLE = new System.Windows.Forms.Label();
            this.LB_PRENOM = new System.Windows.Forms.Label();
            this.LB_NOM = new System.Windows.Forms.Label();
            this.LB_ADRESSE = new System.Windows.Forms.Label();
            this.LB_CODEPOSTAL = new System.Windows.Forms.Label();
            this.Bt_Details = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_NOCLIENT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tlabel_infos
            // 
            this.Tlabel_infos.AutoSize = true;
            this.Tlabel_infos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tlabel_infos.Location = new System.Drawing.Point(13, 13);
            this.Tlabel_infos.Name = "Tlabel_infos";
            this.Tlabel_infos.Size = new System.Drawing.Size(334, 31);
            this.Tlabel_infos.TabIndex = 0;
            this.Tlabel_infos.Text = "Informations sur le client";
            // 
            // Bt_Fermer
            // 
            this.Bt_Fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Fermer.Location = new System.Drawing.Point(491, 20);
            this.Bt_Fermer.Name = "Bt_Fermer";
            this.Bt_Fermer.Size = new System.Drawing.Size(75, 23);
            this.Bt_Fermer.TabIndex = 1;
            this.Bt_Fermer.Text = "FERMER";
            this.Bt_Fermer.UseVisualStyleBackColor = true;
            this.Bt_Fermer.Click += new System.EventHandler(this.Bt_Fermer_Click);
            // 
            // CB_ListeClients
            // 
            this.CB_ListeClients.FormattingEnabled = true;
            this.CB_ListeClients.Location = new System.Drawing.Point(218, 64);
            this.CB_ListeClients.Name = "CB_ListeClients";
            this.CB_ListeClients.Size = new System.Drawing.Size(214, 21);
            this.CB_ListeClients.TabIndex = 2;
            this.CB_ListeClients.SelectedIndexChanged += new System.EventHandler(this.CB_ListeClients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Société";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ville";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Code postal";
            // 
            // Bt_Interroger
            // 
            this.Bt_Interroger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Interroger.Location = new System.Drawing.Point(491, 98);
            this.Bt_Interroger.Name = "Bt_Interroger";
            this.Bt_Interroger.Size = new System.Drawing.Size(75, 23);
            this.Bt_Interroger.TabIndex = 5;
            this.Bt_Interroger.Text = "Interroger";
            this.Bt_Interroger.UseVisualStyleBackColor = true;
            // 
            // LB_SOCIETE
            // 
            this.LB_SOCIETE.AutoSize = true;
            this.LB_SOCIETE.Location = new System.Drawing.Point(215, 174);
            this.LB_SOCIETE.Name = "LB_SOCIETE";
            this.LB_SOCIETE.Size = new System.Drawing.Size(0, 13);
            this.LB_SOCIETE.TabIndex = 6;
            // 
            // LB_VILLE
            // 
            this.LB_VILLE.AutoSize = true;
            this.LB_VILLE.Location = new System.Drawing.Point(215, 224);
            this.LB_VILLE.Name = "LB_VILLE";
            this.LB_VILLE.Size = new System.Drawing.Size(0, 13);
            this.LB_VILLE.TabIndex = 6;
            // 
            // LB_PRENOM
            // 
            this.LB_PRENOM.AutoSize = true;
            this.LB_PRENOM.Location = new System.Drawing.Point(215, 146);
            this.LB_PRENOM.Name = "LB_PRENOM";
            this.LB_PRENOM.Size = new System.Drawing.Size(0, 13);
            this.LB_PRENOM.TabIndex = 6;
            // 
            // LB_NOM
            // 
            this.LB_NOM.AutoSize = true;
            this.LB_NOM.Location = new System.Drawing.Point(215, 121);
            this.LB_NOM.Name = "LB_NOM";
            this.LB_NOM.Size = new System.Drawing.Size(0, 13);
            this.LB_NOM.TabIndex = 6;
            // 
            // LB_ADRESSE
            // 
            this.LB_ADRESSE.AutoSize = true;
            this.LB_ADRESSE.Location = new System.Drawing.Point(215, 200);
            this.LB_ADRESSE.Name = "LB_ADRESSE";
            this.LB_ADRESSE.Size = new System.Drawing.Size(0, 13);
            this.LB_ADRESSE.TabIndex = 6;
            // 
            // LB_CODEPOSTAL
            // 
            this.LB_CODEPOSTAL.AutoSize = true;
            this.LB_CODEPOSTAL.Location = new System.Drawing.Point(215, 247);
            this.LB_CODEPOSTAL.Name = "LB_CODEPOSTAL";
            this.LB_CODEPOSTAL.Size = new System.Drawing.Size(0, 13);
            this.LB_CODEPOSTAL.TabIndex = 7;
            // 
            // Bt_Details
            // 
            this.Bt_Details.Location = new System.Drawing.Point(491, 223);
            this.Bt_Details.Name = "Bt_Details";
            this.Bt_Details.Size = new System.Drawing.Size(75, 23);
            this.Bt_Details.TabIndex = 8;
            this.Bt_Details.Text = "Détails";
            this.Bt_Details.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "N° Client";
            // 
            // LB_NOCLIENT
            // 
            this.LB_NOCLIENT.AutoSize = true;
            this.LB_NOCLIENT.Location = new System.Drawing.Point(215, 98);
            this.LB_NOCLIENT.Name = "LB_NOCLIENT";
            this.LB_NOCLIENT.Size = new System.Drawing.Size(0, 13);
            this.LB_NOCLIENT.TabIndex = 10;
            // 
            // FClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 273);
            this.Controls.Add(this.LB_NOCLIENT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Bt_Details);
            this.Controls.Add(this.LB_CODEPOSTAL);
            this.Controls.Add(this.LB_ADRESSE);
            this.Controls.Add(this.LB_VILLE);
            this.Controls.Add(this.LB_NOM);
            this.Controls.Add(this.LB_PRENOM);
            this.Controls.Add(this.LB_SOCIETE);
            this.Controls.Add(this.Bt_Interroger);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_ListeClients);
            this.Controls.Add(this.Bt_Fermer);
            this.Controls.Add(this.Tlabel_infos);
            this.Name = "FClient";
            this.Text = "Fiche Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tlabel_infos;
        private System.Windows.Forms.Button Bt_Fermer;
        private System.Windows.Forms.ComboBox CB_ListeClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Bt_Interroger;
        private System.Windows.Forms.Label LB_SOCIETE;
        private System.Windows.Forms.Label LB_VILLE;
        private System.Windows.Forms.Label LB_PRENOM;
        private System.Windows.Forms.Label LB_NOM;
        private System.Windows.Forms.Label LB_ADRESSE;
        private System.Windows.Forms.Label LB_CODEPOSTAL;
        private System.Windows.Forms.Button Bt_Details;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_NOCLIENT;
    }
}