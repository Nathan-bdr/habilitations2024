using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace habilitations2024.bddmanager
{
    public class BddManager
    {
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static BddManager instance = null;
        /// <summary>
        /// objet de connexion à la BDD à partir d'une chaîne de connexion
        /// </summary>
        private readonly MySqlConnection connection;
        /// <summary>
        /// constructeur pour créer la connexion à la BDD et l'ouvrir
        /// </summary>
        /// <param name="stringConnect">chaîne de connexion</param>
        private BddManager(string stringConnect)
        {
            connection = new MySqlConnection(stringConnect);
            connection.Open();
        }
        /// <summary>
        /// création d'une seule instance de la classe
        /// </summary>
        /// <param name="stringConnect">chaîne de connexion</param>
        /// <returns>instance unnique de la classe</returns>
        public static BddManager GetInstance(string stringConnect)
        {
            if (instance == null)
            {
                instance = new BddManager(stringConnect);
            }
            return instance;
        }
        /// <summary>
        /// exécution d'une requête autre que "SELECT"
        /// </summary>
        /// <param name="stringQuery">requête autre que "SELECT"</param>
        /// <param name="parameters">dictionnaire contenant les paramètres</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters = null)
        {
            MySqlCommand command = new MySqlCommand(stringQuery, connection);
            if (!(parameters is null))
            {
                foreach (KeyValuePair<string, object> parameter in parameters)
                {
                    command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                }
            }
            command.Prepare();
            command.ExecuteNonQuery();
        }
    }
}
