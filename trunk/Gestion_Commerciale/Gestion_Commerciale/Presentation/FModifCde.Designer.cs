namespace Gestion_Commerciale.Presentation
{
    partial class FModifCde
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
            this.label6 = new System.Windows.Forms.Label();
            this.TB_NumeroCde = new System.Windows.Forms.TextBox();
            this.CB_ListeVendeurs = new System.Windows.Forms.ComboBox();
            this.CB_ListeClients = new System.Windows.Forms.ComboBox();
            this.DTP_DateCde = new System.Windows.Forms.DateTimePicker();
            this.RB_FactureTrue = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.BT_Modifier = new System.Windows.Forms.Button();
            this.BT_Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modification de la commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numéro Vendeur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numéro Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date Commande";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Facture";
            // 
            // TB_NumeroCde
            // 
            this.TB_NumeroCde.Location = new System.Drawing.Point(152, 67);
            this.TB_NumeroCde.Name = "TB_NumeroCde";
            this.TB_NumeroCde.Size = new System.Drawing.Size(202, 20);
            this.TB_NumeroCde.TabIndex = 2;
            // 
            // CB_ListeVendeurs
            // 
            this.CB_ListeVendeurs.FormattingEnabled = true;
            this.CB_ListeVendeurs.Location = new System.Drawing.Point(152, 95);
            this.CB_ListeVendeurs.Name = "CB_ListeVendeurs";
            this.CB_ListeVendeurs.Size = new System.Drawing.Size(202, 21);
            this.CB_ListeVendeurs.TabIndex = 3;
            // 
            // CB_ListeClients
            // 
            this.CB_ListeClients.FormattingEnabled = true;
            this.CB_ListeClients.Location = new System.Drawing.Point(152, 121);
            this.CB_ListeClients.Name = "CB_ListeClients";
            this.CB_ListeClients.Size = new System.Drawing.Size(202, 21);
            this.CB_ListeClients.TabIndex = 4;
            // 
            // DTP_DateCde
            // 
            this.DTP_DateCde.Location = new System.Drawing.Point(152, 149);
            this.DTP_DateCde.Name = "DTP_DateCde";
            this.DTP_DateCde.Size = new System.Drawing.Size(200, 20);
            this.DTP_DateCde.TabIndex = 5;
            // 
            // RB_FactureTrue
            // 
            this.RB_FactureTrue.AutoSize = true;
            this.RB_FactureTrue.Location = new System.Drawing.Point(176, 181);
            this.RB_FactureTrue.Name = "RB_FactureTrue";
            this.RB_FactureTrue.Size = new System.Drawing.Size(41, 17);
            this.RB_FactureTrue.TabIndex = 6;
            this.RB_FactureTrue.TabStop = true;
            this.RB_FactureTrue.Text = "Oui";
            this.RB_FactureTrue.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(243, 181);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // BT_Modifier
            // 
            this.BT_Modifier.Location = new System.Drawing.Point(46, 221);
            this.BT_Modifier.Name = "BT_Modifier";
            this.BT_Modifier.Size = new System.Drawing.Size(127, 23);
            this.BT_Modifier.TabIndex = 7;
            this.BT_Modifier.Text = "Modifier";
            this.BT_Modifier.UseVisualStyleBackColor = true;
            // 
            // BT_Annuler
            // 
            this.BT_Annuler.Location = new System.Drawing.Point(206, 221);
            this.BT_Annuler.Name = "BT_Annuler";
            this.BT_Annuler.Size = new System.Drawing.Size(134, 23);
            this.BT_Annuler.TabIndex = 7;
            this.BT_Annuler.Text = "Annuler";
            this.BT_Annuler.UseVisualStyleBackColor = true;
            this.BT_Annuler.Click += new System.EventHandler(this.BT_Annuler_Click);
            // 
            // FModifCde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.BT_Annuler);
            this.Controls.Add(this.BT_Modifier);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.RB_FactureTrue);
            this.Controls.Add(this.DTP_DateCde);
            this.Controls.Add(this.CB_ListeClients);
            this.Controls.Add(this.CB_ListeVendeurs);
            this.Controls.Add(this.TB_NumeroCde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FModifCde";
            this.Text = "Modification d\'une commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_NumeroCde;
        private System.Windows.Forms.ComboBox CB_ListeVendeurs;
        private System.Windows.Forms.ComboBox CB_ListeClients;
        private System.Windows.Forms.DateTimePicker DTP_DateCde;
        private System.Windows.Forms.RadioButton RB_FactureTrue;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button BT_Modifier;
        private System.Windows.Forms.Button BT_Annuler;
    }
}