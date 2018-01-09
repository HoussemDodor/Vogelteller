using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Logic;

namespace UnitTestProject
{
    [TestClass]
    public class ProjectLogicTest
    {
            [TestMethod]
        public void Test_NewProject()
        {
            // Arrange & Act
            Species species = new Species(1,"Vogel");
            Project expected = new Project("Roermond", "link", species);
            ProjectLogic pl = new ProjectLogic();

            // Assert
            // Assert.AreEqual("Roermond", actual.City);
            Project actual = pl.NewProject("Roermond", "link", species);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.DateStarted, actual.DateStarted);
            Assert.AreEqual(expected.name, actual.name);
        }

            [TestMethod]
        public void Test_EndProject_Succes()
        {
            //Arrange

        }

            [TestMethod]
        public void Test_EndProject_Fail()
        {

        }
    }
}
