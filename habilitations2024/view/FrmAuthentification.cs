using habilitations2024.controller;
using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace habilitations2024.view
{
    /// <summary>
    /// fenêtre d'authentification (seuls les développeurs profil "admin" peuvent accéder à l'application)
    /// </summary>
    public partial class FrmAuthentification : Form
    {
        /// <summary>
        /// contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// initialisations : création du contrôleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        /// <summary>
        /// demande au contrôleur de contrôler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFrmSeConnecter_Click(object sender, EventArgs e)
        {
            String nom = txtFrmNom.Text;
            String prenom = txtFrmPrenom.Text;
            String pwd = txtFrmPwd.Text;
            if (String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(prenom) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Admin admin = new Admin(nom, prenom, pwd);
                if (controller.ControleAuthentification(admin))
                {
                    FrmHabilitations frm = new FrmHabilitations();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                }
            }
        }
    }
}
