using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Rossetto.RG.Dal.DAL;
using Rossetto.RG.Dal.Modele;
using Rossetto.RG.Dal.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rossetto.RG.Dal.Service.Tests
{
    [TestClass()]
    public class RossettoServiceTests
    {
        [TestMethod()]
        public void GetEspionsByMissionTest()
        {
            // Arrange
            var mockContext = new Mock<IRossettoDbContext>();
            var service = new RossettoService(mockContext.Object);

         
            var espions = new List<Espion>
            {
            new Espion { Nom = "James Bond", Missions = new List<Mission> { new Mission { Lieu = "Londres" } } },
            new Espion { Nom = "Hubert Bonisseur", Missions = new List<Mission> { new Mission { Lieu = "Paris" } } }
            };

            mockContext.Setup(db => db.GetAllEspions()).Returns(espions);

            // Act
            var actual = service.GetEspionsByMission("Paris");

            // Assert
            Assert.AreEqual("Hubert Bonisseur", actual.First().Nom);

        }
    }
}