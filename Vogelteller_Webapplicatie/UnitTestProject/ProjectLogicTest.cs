using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Logic;

namespace UnitTestProject
{
    [TestClass]
    public class ProjectLogicTest
    {
        ProjectLogic pl = new ProjectLogic();

        [TestMethod]
        public void NewProjectAndGetAllProjects()
        {
            // Arrange & Act
            Species species = new Species(1, "Vogel");
            Project expected = new Project("Roermond", "link", DateTime.Now, species.ID);
            int x = pl.GetAllProjects().Count;
            pl.NewProject("Roermond", "link", DateTime.Now, species.ID);

            // Assert
            Assert.AreEqual(x + 1, pl.GetAllProjects().Count);
        }

        [TestMethod]
        public void GetProjectByID()
        {
            Random r = new Random();
            int x = r.Next(1, 4);
            Assert.AreEqual(x, pl.GetProjectByID(x).ID);
        }
    }
}
