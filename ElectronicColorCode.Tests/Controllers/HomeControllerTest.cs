using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElectronicColorCode;
using ElectronicColorCode.Controllers;
using CodeCalculator;

namespace ElectronicColorCode.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void NullTest()
        {
            Exception result = null;
            try
            {
                IOhmValueCalculator Calculator = new CalculateResistance();

                Calculator.CalculateOhmValue(null, null, null, null);
            }
            catch (Exception ex)
            {
                result = ex;
                throw;
            }

            Assert.IsInstanceOfType(result, typeof(ArgumentException));
        }

        [TestMethod]
        public void BasicColorTest()
        {
            IOhmValueCalculator Calculator = new CalculateResistance();
            double result = Calculator.CalculateOhmValue("brown", "red", "orange", "yellow");
            Assert.AreEqual("12600", result);
        }

        [TestMethod]
        public void MaximumResistanceTest()
        {
            IOhmValueCalculator Calculator = new CalculateResistance();
            double result = Calculator.CalculateOhmValue("white", "white", "white", "silver");
            Assert.AreEqual("108900000000.00002", result);
        }


        [TestMethod]
        public void MinimumResistanceTest()
        {
            IOhmValueCalculator Calculator = new CalculateResistance();
            double result = Calculator.CalculateOhmValue("brown", "brown", "pink", "gray");
            Assert.AreEqual("0.011005499999999998", result);
        }
    }
}
