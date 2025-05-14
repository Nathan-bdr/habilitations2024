using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.model
{
    /// <summary>
    /// classe métier interne pour mémoriser les informations d'authentification
    /// </summary>
    public class Admin
    {
        public string Nom { get; }
        public string Prenom { get; }
        public string Pwd { get; }

        /// <summary>
        /// valorise les propriétés
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="pwd"></param>
        public Admin(string nom, string prenom, string pwd)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Pwd = pwd;
        }
    }
}
