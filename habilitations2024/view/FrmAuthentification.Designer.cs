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
            // btnFrmSeConnecter
            // 
            this.btnFrmSeConnecter.Location = new System.Drawing.Point(178, 90);
            this.btnFrmSeConnecter.Name = "btnFrmSeConnecter";
            this.btnFrmSeConnecter.Size = new System.Drawing.Size(113, 23);
            this.btnFrmSeConnecter.TabIndex = 6;
            this.btnFrmSeConnecter.Text = "se connecter";
            this.btnFrmSeConnecter.UseVisualStyleBackColor = true;
            this.btnFrmSeConnecter.Click += new System.EventHandler(this.btnFrmSeConnecter_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 123);
            this.Controls.Add(this.btnFrmSeConnecter);
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
        private System.Windows.Forms.Button btnFrmSeConnecter;
    }
}