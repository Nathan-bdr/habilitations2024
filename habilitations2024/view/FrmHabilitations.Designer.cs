namespace habilitations2024.view
{
    partial class FrmHabilitations
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
            this.lstDeveloppeurs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstDeveloppeurs
            // 
            this.lstDeveloppeurs.FormattingEnabled = true;
            this.lstDeveloppeurs.Location = new System.Drawing.Point(329, 145);
            this.lstDeveloppeurs.Name = "lstDeveloppeurs";
            this.lstDeveloppeurs.Size = new System.Drawing.Size(120, 95);
            this.lstDeveloppeurs.TabIndex = 0;
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstDeveloppeurs);
            this.Name = "FrmHabilitations";
            this.Text = "FrmHabilitations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDeveloppeurs;
    }
}

