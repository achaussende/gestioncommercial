namespace Gestion_Commerciale.Presentation
{
    partial class FAugmentationPrix
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
            this.TB_Mult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Augmenter = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_Mult
            // 
            this.TB_Mult.Location = new System.Drawing.Point(94, 47);
            this.TB_Mult.Name = "TB_Mult";
            this.TB_Mult.Size = new System.Drawing.Size(160, 20);
            this.TB_Mult.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Multiplicateur";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Augmenter les prix";
            // 
            // BT_Augmenter
            // 
            this.BT_Augmenter.Location = new System.Drawing.Point(44, 83);
            this.BT_Augmenter.Name = "BT_Augmenter";
            this.BT_Augmenter.Size = new System.Drawing.Size(75, 23);
            this.BT_Augmenter.TabIndex = 5;
            this.BT_Augmenter.Text = "Augmenter";
            this.BT_Augmenter.UseVisualStyleBackColor = true;
            this.BT_Augmenter.Click += new System.EventHandler(this.BT_Augmenter_Click);
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(152, 83);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(75, 23);
            this.Annuler.TabIndex = 5;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // FAugmentationPrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 118);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.BT_Augmenter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Mult);
            this.Name = "FAugmentationPrix";
            this.Text = "Augmentation des prix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Mult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Augmenter;
        private System.Windows.Forms.Button Annuler;
    }
}