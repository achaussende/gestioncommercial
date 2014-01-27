namespace Gestion_Commerciale.Presentation
{
    partial class FAjoutArt
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
            this.label6 = new System.Windows.Forms.Label();
            this.BT_Annuler = new System.Windows.Forms.Button();
            this.BT_Inserer = new System.Windows.Forms.Button();
            this.TB_PrixArt = new System.Windows.Forms.TextBox();
            this.TB_Ville = new System.Windows.Forms.TextBox();
            this.TB_Qtedispo = new System.Windows.Forms.TextBox();
            this.TB_Lib = new System.Windows.Forms.TextBox();
            this.TB_NumeroArt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Prix article";
            // 
            // BT_Annuler
            // 
            this.BT_Annuler.Location = new System.Drawing.Point(192, 221);
            this.BT_Annuler.Name = "BT_Annuler";
            this.BT_Annuler.Size = new System.Drawing.Size(174, 23);
            this.BT_Annuler.TabIndex = 17;
            this.BT_Annuler.Text = "Annuler";
            this.BT_Annuler.UseVisualStyleBackColor = true;
            this.BT_Annuler.Click += new System.EventHandler(this.BT_Annuler_Click);
            // 
            // BT_Inserer
            // 
            this.BT_Inserer.Location = new System.Drawing.Point(19, 222);
            this.BT_Inserer.Name = "BT_Inserer";
            this.BT_Inserer.Size = new System.Drawing.Size(167, 23);
            this.BT_Inserer.TabIndex = 16;
            this.BT_Inserer.Text = "Insérer";
            this.BT_Inserer.UseVisualStyleBackColor = true;
            this.BT_Inserer.Click += new System.EventHandler(this.BT_Inserer_Click);
            // 
            // TB_PrixArt
            // 
            this.TB_PrixArt.Location = new System.Drawing.Point(168, 172);
            this.TB_PrixArt.Name = "TB_PrixArt";
            this.TB_PrixArt.Size = new System.Drawing.Size(198, 20);
            this.TB_PrixArt.TabIndex = 15;
            // 
            // TB_Ville
            // 
            this.TB_Ville.Location = new System.Drawing.Point(168, 147);
            this.TB_Ville.Name = "TB_Ville";
            this.TB_Ville.Size = new System.Drawing.Size(198, 20);
            this.TB_Ville.TabIndex = 14;
            // 
            // TB_Qtedispo
            // 
            this.TB_Qtedispo.Location = new System.Drawing.Point(168, 121);
            this.TB_Qtedispo.Name = "TB_Qtedispo";
            this.TB_Qtedispo.Size = new System.Drawing.Size(198, 20);
            this.TB_Qtedispo.TabIndex = 13;
            // 
            // TB_Lib
            // 
            this.TB_Lib.Location = new System.Drawing.Point(168, 95);
            this.TB_Lib.Name = "TB_Lib";
            this.TB_Lib.Size = new System.Drawing.Size(198, 20);
            this.TB_Lib.TabIndex = 12;
            // 
            // TB_NumeroArt
            // 
            this.TB_NumeroArt.Location = new System.Drawing.Point(168, 69);
            this.TB_NumeroArt.Name = "TB_NumeroArt";
            this.TB_NumeroArt.Size = new System.Drawing.Size(198, 20);
            this.TB_NumeroArt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantité disponible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Libellé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numéro d\'article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insertion d\'un article";
            // 
            // FAjoutArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 265);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BT_Annuler);
            this.Controls.Add(this.BT_Inserer);
            this.Controls.Add(this.TB_PrixArt);
            this.Controls.Add(this.TB_Ville);
            this.Controls.Add(this.TB_Qtedispo);
            this.Controls.Add(this.TB_Lib);
            this.Controls.Add(this.TB_NumeroArt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAjoutArt";
            this.Text = "Nouvel Article";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Annuler;
        private System.Windows.Forms.Button BT_Inserer;
        private System.Windows.Forms.TextBox TB_PrixArt;
        private System.Windows.Forms.TextBox TB_Ville;
        private System.Windows.Forms.TextBox TB_Qtedispo;
        private System.Windows.Forms.TextBox TB_Lib;
        private System.Windows.Forms.TextBox TB_NumeroArt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}