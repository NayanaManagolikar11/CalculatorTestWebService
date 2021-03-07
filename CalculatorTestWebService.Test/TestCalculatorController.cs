using CalculatorTestWebService.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTestWebService.Test
{
    [TestClass]
    public class TestCalculatorController
    {
        //DatabaseController databaseController = new DatabaseController();
       CalculatorController calculator = new CalculatorController();
        [TestMethod]
        public void TestAdd()
        {
            int expectedResult = 30;
            int result = calculator.GetAdd(20, 10);
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestSubtraction()
        {
            int expectedResult = 10;
            int result = calculator.GetSubtract(20, 10);
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestMultiply()
        {
            int expectedResult = 200;
            int result = calculator.GetMultiply(20, 10);
            Assert.AreEqual(expectedResult, result);

        }
        [TestMethod]
        public void TestDivide()
        {
            float expectedResult = 2;
            float result = calculator.GetDivide(20, 10);
            Assert.AreEqual(expectedResult, result);

        }
       
    }
}
