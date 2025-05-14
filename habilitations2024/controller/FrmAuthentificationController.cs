using habilitations2024.dal;
using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace habilitations2024.controller
{
    /// <summary>
    /// contrôleur de FrmAuthentification
    /// </summary>
    class FrmAuthentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        private readonly DeveloppeurAccess developpeurAccess;

        /// <summary>
        /// récupère l'accès aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            developpeurAccess = new DeveloppeurAccess();
        }

        /// <summary>
        /// vérifie l'authentification
        /// </summary>
        /// <param name="admin">objet contenant les informations de connection</param>
        /// <returns>vrai si les informations de connection sont correctes</returns>
        public Boolean ControleAuthentification(Admin admin)
        {
            return developpeurAccess.ControleAuthentification(admin);
        }
    }
}
