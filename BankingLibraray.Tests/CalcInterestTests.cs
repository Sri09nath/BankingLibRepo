using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankingLibrary;

namespace BankingLibraray.Tests
{
    [TestClass]
    public class CalcInterestTests
    {
        [TestMethod]
        public void Calculate_AcceptsPNR_ReturnsSI()
        {
            //Arrange
            int ExpectedResult = 1000;

            //Act
            ICalcInterest calc = new CalcInterest();
            int ActualResult = calc.Calculate(10000, 1, 10);

            //Assert
            Assert.AreEqual(ActualResult, ExpectedResult);
        }
    }
}
