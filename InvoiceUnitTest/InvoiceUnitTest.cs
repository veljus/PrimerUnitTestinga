using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestNo1;

namespace InvoiceUnitTest
{
    [TestFixture(Description ="Test1")]
    public class InvoiceUnitTest
    {
        [Test]
        public void TestInvoiceCalc()
        {
            InvoiceCalculation obj = new InvoiceCalculation();
            int intTotalCost = obj.CalculationCost(10, 20);
            Assert.AreEqual(100, intTotalCost);
        }
    }
}
