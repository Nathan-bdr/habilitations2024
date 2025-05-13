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
        public FrmHabilitations()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Chaîne de connexion à la base de données
            string connectionString = "Server=localhost;Port=3308;Database=habilitations;Uid=habilitations;Pwd=Sio1234*;";
            // Requête SQL pour récupérer les noms
            string query = "SELECT nom FROM developpeur";
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lstDeveloppeurs.Items.Add(reader["nom"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }
    }
}
