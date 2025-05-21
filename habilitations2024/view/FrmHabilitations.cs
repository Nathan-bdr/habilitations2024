using habilitations2024.controller;
using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace habilitations2024.view
{
    public partial class FrmHabilitations : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifDeveloppeur = false;
        /// <summary>
        /// objet pour gérer la liste de dévelopeurs
        /// </summary>
        private BindingSource bdgDeveloppeurs = new BindingSource();
        /// <summary>
        /// objet pour gérer la liste des profils
        /// </summary>
        private BindingSource bdgProfils = new BindingSource();
        /// <summary>
        /// objet pour gérer la liste des profils du filtre
        /// </summary>
        private BindingSource bdgFiltreProfils = new BindingSource();
        /// <summary>
        /// contrôleur de la fenêtre
        /// </summary>
        private FrmHabilitationsController controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmHabilitations()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// création du contrôleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmHabilitationsController();
            RemplirListeDeveloppeurs();
            RemplirListeProfils();
            EnCoursModifDeveloppeur(false);
            EnCoursModifPwd(false);

            profilFiltre.SelectedIndexChanged += profilFiltre_SelectedIndexChanged;
            InitialiserFiltreProfils();
        }

        /// <summary>
        /// affiche les développeurs
        /// </summary>
        /// <param name="idProfil"></param>
        private void RemplirListeDeveloppeurs(int? idProfil = null)
        {
            List<Developpeur> lesDeveloppeurs = controller.GetLesDeveloppeurs(idProfil);
            bdgDeveloppeurs.DataSource = lesDeveloppeurs;
            dgvDeveloppeurs.DataSource = bdgDeveloppeurs;
            dgvDeveloppeurs.Columns["iddeveloppeur"].Visible = false;
            dgvDeveloppeurs.Columns["pwd"].Visible = false;
            dgvDeveloppeurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// affiche les profils
        /// </summary>
        private void RemplirListeProfils()
        {
            List<Profil> lesProfils = controller.GetLesProfils();
            bdgProfils.DataSource = lesProfils;
            cmbProfil.DataSource = bdgProfils;
        }

        /// <summary>
        /// demande de modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count > 0)
            {
                EnCoursModifDeveloppeur(true);
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                txtNom.Text = developpeur.Nom;
                txtPrenom.Text = developpeur.Prenom;
                txtTel.Text = developpeur.Tel;
                txtMail.Text = developpeur.Mail;
                cmbProfil.SelectedIndex = cmbProfil.FindStringExact(developpeur.Profil.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// demande de suppression d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count > 0)
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + developpeur.Nom + " " + developpeur.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelDeveloppeur(developpeur);
                    RemplirListeDeveloppeurs();
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée", "Information");
                }
            }
        }

        /// <summary>
        /// demande de changement de pwd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangerPwd_Click(object sender, EventArgs e)
        {
            if (dgvDeveloppeurs.SelectedRows.Count > 0)
            {
                EnCoursModifPwd(true);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée", "Information");
            }
        }

        /// <summary>
        /// demande d'enregistrement de l'ajout ou de la modification d'un développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cmbProfil.SelectedIndex != -1)
            {
                Profil profil = (Profil)bdgProfils.List[bdgProfils.Position];
                if (enCoursDeModifDeveloppeur)
                {
                    Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                    developpeur.Nom = txtNom.Text;
                    developpeur.Prenom = txtPrenom.Text;
                    developpeur.Tel = txtTel.Text;
                    developpeur.Mail = txtMail.Text;
                    developpeur.Profil = profil;
                    controller.UpdateDeveloppeur(developpeur);
                }
                else
                {
                    Developpeur developpeur = new Developpeur(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, profil);
                    controller.AddDeveloppeur(developpeur);
                }
                RemplirListeDeveloppeurs();
                EnCoursModifDeveloppeur(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// annule la demande d'ajout ou de modification d'un développeur
        /// vide les zones de saisie du développeur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifDeveloppeur(false);
            }
        }

        /// <summary>
        /// demande d'enregistrement d'un nouveau pwd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerPwd_Click(object sender, EventArgs e)
        {
            if (!txtPwd.Text.Equals("") && !txtEncore.Text.Equals("") && txtPwd.Text.Equals(txtEncore.Text))
            {
                Developpeur developpeur = (Developpeur)bdgDeveloppeurs.List[bdgDeveloppeurs.Position];
                developpeur.Pwd = txtPwd.Text;
                controller.UpdatePwd(developpeur);
                EnCoursModifPwd(false);
            }
            else
            {
                MessageBox.Show("Les 2 zones doivent être remplies et de contenu identique", "Information");
            }
        }

        /// <summary>
        /// annulation de la demande d'enregistrement d'un nouveau pwd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerPwd_Click(object sender, EventArgs e)
        {
            EnCoursModifPwd(false);
        }

        private void EnCoursModifDeveloppeur(Boolean modif)
        {
            enCoursDeModifDeveloppeur = modif;
            grpBoxLesDeveloppeurs.Enabled = !modif;
            if (modif)
            {
                grpBoxAjouterDev.Text = "modifier un développeur";
            }
            else
            {
                grpBoxAjouterDev.Text = "ajouter un développeur";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifPwd(Boolean modif)
        {
            grpBoxChangerPwd.Enabled = modif;
            grpBoxLesDeveloppeurs.Enabled = !modif;
            grpBoxAjouterDev.Enabled = !modif;
            txtPwd.Text = "";
            txtEncore.Text = "";
        }

        /// <summary>
        /// initialiser le filtre
        /// </summary>
        private void InitialiserFiltreProfils()
        {
            List<Profil> profilsAvecVide = new List<Profil>();
            profilsAvecVide.Add(new Profil(0, ""));
            profilsAvecVide.AddRange(controller.GetLesProfils());

            bdgFiltreProfils.DataSource = profilsAvecVide;
            profilFiltre.DataSource = bdgFiltreProfils;
            profilFiltre.DisplayMember = "Nom";
            profilFiltre.ValueMember = "IdProfil";
            profilFiltre.SelectedIndex = 0;
        }

        /// <summary>
        /// gérer le changement de filtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void profilFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (profilFiltre.SelectedItem != null)
            {
                Profil profilSelectionne = (Profil)profilFiltre.SelectedItem;
                int? idProfil = profilSelectionne.Idprofil == 0 ? (int?)null : profilSelectionne.Idprofil;
                RemplirListeDeveloppeurs(idProfil);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
