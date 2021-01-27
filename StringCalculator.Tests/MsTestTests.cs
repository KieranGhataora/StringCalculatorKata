using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;
namespace StringCalculator.Tests
{
    [TestClass]
    public class MsTestTests
    {
        [TestMethod]
        public void CalcAdd_TestEmptyString()
        {
            Calculator clc  =  new Calculator();
            int retVal= clc.Add(string.Empty);
            const int  constZero = 0;
            Assert.AreEqual(retVal, constZero, "Add calculator for empty String");

        }

       


        [TestMethod]
        public void CalcAdd_TestIntValue()
        {
            Calculator clc = new Calculator();

            int retVal = clc.Add("1");
            int constIntOne = 1;
            Assert.AreEqual(retVal, constIntOne, "Add calculator for empty String");

        }
        [TestMethod]
        public void CalcAdd_TestCommaSeperatedValue()
        {
            Calculator clc = new Calculator();

            int retVal = clc.Add("1,2");
            const int constIntTotal = 3;
            Assert.AreEqual(retVal, constIntTotal, "Add calculator for empty String");

        }
    }
}