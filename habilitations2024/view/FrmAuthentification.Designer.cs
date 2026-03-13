namespace habilitations2024.view
{
    partial class FrmAuthentification
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
            this.lblFrmNom = new System.Windows.Forms.Label();
            this.lblFrmPrenom = new System.Windows.Forms.Label();
            this.lblFrmPwd = new System.Windows.Forms.Label();
            this.txtFrmNom = new System.Windows.Forms.TextBox();
            this.txtFrmPrenom = new System.Windows.Forms.TextBox();
            this.txtFrmPwd = new System.Windows.Forms.TextBox();
            this.txtFrmMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFrmSeConnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFrmNom
            // 
            this.lblFrmNom.AutoSize = true;
            this.lblFrmNom.Location = new System.Drawing.Point(12, 15);
            this.lblFrmNom.Name = "lblFrmNom";
            this.lblFrmNom.Size = new System.Drawing.Size(27, 13);
            this.lblFrmNom.TabIndex = 0;
            this.lblFrmNom.Text = "nom";
            // 
            // lblFrmPrenom
            // 
            this.lblFrmPrenom.AutoSize = true;
            this.lblFrmPrenom.Location = new System.Drawing.Point(12, 41);
            this.lblFrmPrenom.Name = "lblFrmPrenom";
            this.lblFrmPrenom.Size = new System.Drawing.Size(42, 13);
            this.lblFrmPrenom.TabIndex = 1;
            this.lblFrmPrenom.Text = "prénom";
            // 
            // lblFrmPwd
            // 
            this.lblFrmPwd.AutoSize = true;
            this.lblFrmPwd.Location = new System.Drawing.Point(12, 67);
            this.lblFrmPwd.Name = "lblFrmPwd";
            this.lblFrmPwd.Size = new System.Drawing.Size(27, 13);
            this.lblFrmPwd.TabIndex = 2;
            this.lblFrmPwd.Text = "pwd";
            // 
            // txtFrmNom
            // 
            this.txtFrmNom.Location = new System.Drawing.Point(78, 12);
            this.txtFrmNom.Name = "txtFrmNom";
            this.txtFrmNom.Size = new System.Drawing.Size(213, 20);
            this.txtFrmNom.TabIndex = 3;
            // 
            // txtFrmPrenom
            // 
            this.txtFrmPrenom.Location = new System.Drawing.Point(78, 38);
            this.txtFrmPrenom.Name = "txtFrmPrenom";
            this.txtFrmPrenom.Size = new System.Drawing.Size(213, 20);
            this.txtFrmPrenom.TabIndex = 4;
            // 
            // txtFrmPwd
            // 
            this.txtFrmPwd.Location = new System.Drawing.Point(78, 64);
            this.txtFrmPwd.Name = "txtFrmPwd";
            this.txtFrmPwd.PasswordChar = '●';
            this.txtFrmPwd.Size = new System.Drawing.Size(213, 20);
            this.txtFrmPwd.TabIndex = 5;
            // 
            // txtFrmMail
            // 
            this.txtFrmMail.Location = new System.Drawing.Point(78, 90);
            this.txtFrmMail.Name = "txtFrmMail";
            this.txtFrmMail.Size = new System.Drawing.Size(213, 20);
            this.txtFrmMail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "mail";
            // 
            // btnFrmSeConnecter
            // 
            this.btnFrmSeConnecter.Location = new System.Drawing.Point(178, 121);
            this.btnFrmSeConnecter.Name = "btnFrmSeConnecter";
            this.btnFrmSeConnecter.Size = new System.Drawing.Size(113, 23);
            this.btnFrmSeConnecter.TabIndex = 9;
            this.btnFrmSeConnecter.Text = "se connecter";
            this.btnFrmSeConnecter.UseVisualStyleBackColor = true;
            this.btnFrmSeConnecter.Click += new System.EventHandler(this.btnFrmSeConnecter_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 156);
            this.Controls.Add(this.btnFrmSeConnecter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrmMail);
            this.Controls.Add(this.txtFrmPwd);
            this.Controls.Add(this.txtFrmPrenom);
            this.Controls.Add(this.txtFrmNom);
            this.Controls.Add(this.lblFrmPwd);
            this.Controls.Add(this.lblFrmPrenom);
            this.Controls.Add(this.lblFrmNom);
            this.Name = "FrmAuthentification";
            this.Text = "Authentification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrmNom;
        private System.Windows.Forms.Label lblFrmPrenom;
        private System.Windows.Forms.Label lblFrmPwd;
        private System.Windows.Forms.TextBox txtFrmNom;
        private System.Windows.Forms.TextBox txtFrmPrenom;
        private System.Windows.Forms.TextBox txtFrmPwd;
        private System.Windows.Forms.TextBox txtFrmMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFrmSeConnecter;
    }
}