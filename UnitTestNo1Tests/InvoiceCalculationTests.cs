using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestNo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestNo1.Tests
{
    [TestClass()]
    public class InvoiceCalculationTests
    {
        [TestMethod()]
        public void CalculationCostTest()
        {
            //Assert.IsTrue(true);
            InvoiceCalculation obj = new InvoiceCalculation();
            int intTotalCost = obj.CalculationCost(10, 20);
            Assert.AreEqual(200, intTotalCost);
        }
    }
}