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
            this.dgvDeveloppeurs = new System.Windows.Forms.DataGridView();
            this.grpBoxLesDeveloppeurs = new System.Windows.Forms.GroupBox();
            this.profilFiltre = new System.Windows.Forms.ComboBox();
            this.btnChangerPwd = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.grpBoxAjouterDev = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cmbProfil = new System.Windows.Forms.ComboBox();
            this.lblProfil = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.grpBoxChangerPwd = new System.Windows.Forms.GroupBox();
            this.btnAnnulerPwd = new System.Windows.Forms.Button();
            this.btnEnregistrerPwd = new System.Windows.Forms.Button();
            this.lblEncore = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtEncore = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblProfilFiltre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).BeginInit();
            this.grpBoxLesDeveloppeurs.SuspendLayout();
            this.grpBoxAjouterDev.SuspendLayout();
            this.grpBoxChangerPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDeveloppeurs
            // 
            this.dgvDeveloppeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeveloppeurs.Location = new System.Drawing.Point(6, 46);
            this.dgvDeveloppeurs.Name = "dgvDeveloppeurs";
            this.dgvDeveloppeurs.Size = new System.Drawing.Size(749, 275);
            this.dgvDeveloppeurs.TabIndex = 0;
            // 
            // grpBoxLesDeveloppeurs
            // 
            this.grpBoxLesDeveloppeurs.Controls.Add(this.lblProfilFiltre);
            this.grpBoxLesDeveloppeurs.Controls.Add(this.profilFiltre);
            this.grpBoxLesDeveloppeurs.Controls.Add(this.btnChangerPwd);
            this.grpBoxLesDeveloppeurs.Controls.Add(this.btnSupprimer);
            this.grpBoxLesDeveloppeurs.Controls.Add(this.btnModifier);
            this.grpBoxLesDeveloppeurs.Controls.Add(this.dgvDeveloppeurs);
            this.grpBoxLesDeveloppeurs.Location = new System.Drawing.Point(18, 21);
            this.grpBoxLesDeveloppeurs.Name = "grpBoxLesDeveloppeurs";
            this.grpBoxLesDeveloppeurs.Size = new System.Drawing.Size(761, 356);
            this.grpBoxLesDeveloppeurs.TabIndex = 1;
            this.grpBoxLesDeveloppeurs.TabStop = false;
            this.grpBoxLesDeveloppeurs.Text = "les développeurs";
            // 
            // profilFiltre
            // 
            this.profilFiltre.FormattingEnabled = true;
            this.profilFiltre.Location = new System.Drawing.Point(91, 19);
            this.profilFiltre.Name = "profilFiltre";
            this.profilFiltre.Size = new System.Drawing.Size(121, 21);
            this.profilFiltre.TabIndex = 3;
            // 
            // btnChangerPwd
            // 
            this.btnChangerPwd.Location = new System.Drawing.Point(184, 327);
            this.btnChangerPwd.Name = "btnChangerPwd";
            this.btnChangerPwd.Size = new System.Drawing.Size(105, 23);
            this.btnChangerPwd.TabIndex = 2;
            this.btnChangerPwd.Text = "changer pwd";
            this.btnChangerPwd.UseVisualStyleBackColor = true;
            this.btnChangerPwd.Click += new System.EventHandler(this.btnChangerPwd_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(95, 327);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(83, 23);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(6, 327);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(83, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // grpBoxAjouterDev
            // 
            this.grpBoxAjouterDev.Controls.Add(this.btnAnnuler);
            this.grpBoxAjouterDev.Controls.Add(this.btnEnregistrer);
            this.grpBoxAjouterDev.Controls.Add(this.cmbProfil);
            this.grpBoxAjouterDev.Controls.Add(this.lblProfil);
            this.grpBoxAjouterDev.Controls.Add(this.txtTel);
            this.grpBoxAjouterDev.Controls.Add(this.txtMail);
            this.grpBoxAjouterDev.Controls.Add(this.lblTel);
            this.grpBoxAjouterDev.Controls.Add(this.lblMail);
            this.grpBoxAjouterDev.Controls.Add(this.txtPrenom);
            this.grpBoxAjouterDev.Controls.Add(this.txtNom);
            this.grpBoxAjouterDev.Controls.Add(this.lblPrenom);
            this.grpBoxAjouterDev.Controls.Add(this.lblNom);
            this.grpBoxAjouterDev.Location = new System.Drawing.Point(18, 390);
            this.grpBoxAjouterDev.Name = "grpBoxAjouterDev";
            this.grpBoxAjouterDev.Size = new System.Drawing.Size(761, 148);
            this.grpBoxAjouterDev.TabIndex = 2;
            this.grpBoxAjouterDev.TabStop = false;
            this.grpBoxAjouterDev.Text = "ajouter un développeur";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(123, 115);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(108, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(9, 115);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(108, 23);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // cmbProfil
            // 
            this.cmbProfil.FormattingEnabled = true;
            this.cmbProfil.Location = new System.Drawing.Point(449, 82);
            this.cmbProfil.Name = "cmbProfil";
            this.cmbProfil.Size = new System.Drawing.Size(170, 21);
            this.cmbProfil.TabIndex = 9;
            this.cmbProfil.Text = "admin";
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Location = new System.Drawing.Point(401, 85);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(29, 13);
            this.lblProfil.TabIndex = 8;
            this.lblProfil.Text = "profil";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(449, 54);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(170, 20);
            this.txtTel.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(449, 27);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(306, 20);
            this.txtMail.TabIndex = 6;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(401, 57);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(18, 13);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "tel";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(401, 30);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(25, 13);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "mail";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(65, 54);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(282, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(65, 27);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(282, 20);
            this.txtNom.TabIndex = 2;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 57);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(42, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 30);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(27, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "nom";
            // 
            // grpBoxChangerPwd
            // 
            this.grpBoxChangerPwd.Controls.Add(this.btnAnnulerPwd);
            this.grpBoxChangerPwd.Controls.Add(this.btnEnregistrerPwd);
            this.grpBoxChangerPwd.Controls.Add(this.lblEncore);
            this.grpBoxChangerPwd.Controls.Add(this.lblPwd);
            this.grpBoxChangerPwd.Controls.Add(this.txtEncore);
            this.grpBoxChangerPwd.Controls.Add(this.txtPwd);
            this.grpBoxChangerPwd.Enabled = false;
            this.grpBoxChangerPwd.Location = new System.Drawing.Point(18, 554);
            this.grpBoxChangerPwd.Name = "grpBoxChangerPwd";
            this.grpBoxChangerPwd.Size = new System.Drawing.Size(761, 99);
            this.grpBoxChangerPwd.TabIndex = 3;
            this.grpBoxChangerPwd.TabStop = false;
            this.grpBoxChangerPwd.Text = "changer le mot de passe";
            // 
            // btnAnnulerPwd
            // 
            this.btnAnnulerPwd.Location = new System.Drawing.Point(123, 56);
            this.btnAnnulerPwd.Name = "btnAnnulerPwd";
            this.btnAnnulerPwd.Size = new System.Drawing.Size(108, 23);
            this.btnAnnulerPwd.TabIndex = 9;
            this.btnAnnulerPwd.Text = "Annuler";
            this.btnAnnulerPwd.UseVisualStyleBackColor = true;
            this.btnAnnulerPwd.Click += new System.EventHandler(this.btnAnnulerPwd_Click);
            // 
            // btnEnregistrerPwd
            // 
            this.btnEnregistrerPwd.Location = new System.Drawing.Point(9, 56);
            this.btnEnregistrerPwd.Name = "btnEnregistrerPwd";
            this.btnEnregistrerPwd.Size = new System.Drawing.Size(108, 23);
            this.btnEnregistrerPwd.TabIndex = 8;
            this.btnEnregistrerPwd.Text = "Enregistrer";
            this.btnEnregistrerPwd.UseVisualStyleBackColor = true;
            this.btnEnregistrerPwd.Click += new System.EventHandler(this.btnEnregistrerPwd_Click);
            // 
            // lblEncore
            // 
            this.lblEncore.AutoSize = true;
            this.lblEncore.Location = new System.Drawing.Point(401, 33);
            this.lblEncore.Name = "lblEncore";
            this.lblEncore.Size = new System.Drawing.Size(40, 13);
            this.lblEncore.TabIndex = 7;
            this.lblEncore.Text = "encore";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(6, 33);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(27, 13);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "pwd";
            // 
            // txtEncore
            // 
            this.txtEncore.Location = new System.Drawing.Point(449, 30);
            this.txtEncore.Name = "txtEncore";
            this.txtEncore.PasswordChar = '●';
            this.txtEncore.Size = new System.Drawing.Size(282, 20);
            this.txtEncore.TabIndex = 5;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(65, 30);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '●';
            this.txtPwd.Size = new System.Drawing.Size(282, 20);
            this.txtPwd.TabIndex = 4;
            // 
            // lblProfilFiltre
            // 
            this.lblProfilFiltre.AutoSize = true;
            this.lblProfilFiltre.Location = new System.Drawing.Point(13, 22);
            this.lblProfilFiltre.Name = "lblProfilFiltre";
            this.lblProfilFiltre.Size = new System.Drawing.Size(72, 13);
            this.lblProfilFiltre.TabIndex = 4;
            this.lblProfilFiltre.Text = "filtrer par profil";
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.grpBoxChangerPwd);
            this.Controls.Add(this.grpBoxAjouterDev);
            this.Controls.Add(this.grpBoxLesDeveloppeurs);
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).EndInit();
            this.grpBoxLesDeveloppeurs.ResumeLayout(false);
            this.grpBoxLesDeveloppeurs.PerformLayout();
            this.grpBoxAjouterDev.ResumeLayout(false);
            this.grpBoxAjouterDev.PerformLayout();
            this.grpBoxChangerPwd.ResumeLayout(false);
            this.grpBoxChangerPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeveloppeurs;
        private System.Windows.Forms.GroupBox grpBoxLesDeveloppeurs;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnChangerPwd;
        private System.Windows.Forms.GroupBox grpBoxAjouterDev;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox cmbProfil;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox grpBoxChangerPwd;
        private System.Windows.Forms.Button btnEnregistrerPwd;
        private System.Windows.Forms.Label lblEncore;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtEncore;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnAnnulerPwd;
        private System.Windows.Forms.ComboBox profilFiltre;
        private System.Windows.Forms.Label lblProfilFiltre;
    }
}

