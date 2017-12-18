﻿using System;
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
            Species species = new Species("Vogel");
            Project expected = new Project("Roermond", "link", species);
            ProjectLogic pl = new ProjectLogic();

            // Assert
            Assert.AreEqual(expected, pl.NewProject("Roermond", "link", species));
        }

        [TestMethod]
        public void Test_EndProject_Succes()
        {

        }

        [TestMethod]
        public void Test_EndProject_Fail()
        {

        }
    }
}