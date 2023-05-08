using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation.TaxCalculator
{
    public class TaxBracket
    {
        public decimal UpperLimit { get; set; }
        public decimal LowerLimit { get; set; }
        public decimal TaxPercent { get; set; }
    }
}
