using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestNo1
{
    public class InvoiceCalculation
    {
        public int CalculationCost(int NoOfProducts, int CostPerProduct)
        {
            return NoOfProducts * CostPerProduct;
        }
    }
}
