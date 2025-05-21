using Microsoft.VisualStudio.TestTools.UnitTesting;
using habilitations2024.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.model;

namespace habilitations2024.dal.Tests
{
    [TestClass()]
    public class DeveloppeurAccessTests : DeveloppeurAccess
    {
        [TestMethod()]
        public List<Developpeur> GetLesDeveloppeursTest(int? idProfil)
        {
            return GetLesDeveloppeurs(idProfil);
        }

        [TestMethod]
        public void GetLesDeveloppeurs_AvecProfil()
        {
            var developerAccessTests = new DeveloppeurAccessTests();
            int nbDeveloppeursAttendu = 6; 
            int idProfil = 1; 

            var result = developerAccessTests.GetLesDeveloppeursTest(idProfil);
            int nbDeveloppeurs = result.Count;

            Assert.AreEqual(nbDeveloppeursAttendu, nbDeveloppeurs);
        }

        [TestMethod]
        public void GetLesDeveloppeurs_SansProfil()
        {
            var developerAccessTests = new DeveloppeurAccessTests();
            int nbDeveloppeursAttendu = 20;

            var result = developerAccessTests.GetLesDeveloppeursTest(null);
            int nbDeveloppeurs = result.Count;

            Assert.AreEqual(nbDeveloppeursAttendu, nbDeveloppeurs);
        }
    }
}