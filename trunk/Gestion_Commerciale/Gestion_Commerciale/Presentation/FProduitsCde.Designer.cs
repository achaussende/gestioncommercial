namespace Gestion_Commerciale.Presentation
{
    partial class FProduitsCde
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
            this.LB_NoCde = new System.Windows.Forms.Label();
            this.lvproduitcde = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produits de la commande";
            // 
            // LB_NoCde
            // 
            this.LB_NoCde.AutoSize = true;
            this.LB_NoCde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NoCde.Location = new System.Drawing.Point(253, 13);
            this.LB_NoCde.Name = "LB_NoCde";
            this.LB_NoCde.Size = new System.Drawing.Size(80, 24);
            this.LB_NoCde.TabIndex = 1;
            this.LB_NoCde.Text = "no_cde";
            // 
            // lvproduitcde
            // 
            this.lvproduitcde.Location = new System.Drawing.Point(13, 41);
            this.lvproduitcde.Name = "lvproduitcde";
            this.lvproduitcde.Size = new System.Drawing.Size(548, 317);
            this.lvproduitcde.TabIndex = 2;
            this.lvproduitcde.UseCompatibleStateImageBehavior = false;
            this.lvproduitcde.SelectedIndexChanged += new System.EventHandler(this.lvdetailcde_SelectedIndexChanged);
            // 
            // FProduitsCde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 370);
            this.Controls.Add(this.lvproduitcde);
            this.Controls.Add(this.LB_NoCde);
            this.Controls.Add(this.label1);
            this.Name = "FProduitsCde";
            this.Text = "Produits commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_NoCde;
        private System.Windows.Forms.ListView lvproduitcde;
    }
}