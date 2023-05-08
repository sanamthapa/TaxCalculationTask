using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation.TaxCalculator;

public class TaxCalculator
{
    private List<TaxBracket> _taxBrackets;

    public TaxCalculator()
    {
        _taxBrackets = new List<TaxBracket>
        {
            new TaxBracket { LowerLimit = 0, UpperLimit = 1000, TaxPercent = 10 },
            new TaxBracket { LowerLimit = 1000, UpperLimit = 5000, TaxPercent = 20 },
            new TaxBracket { LowerLimit = 5000, UpperLimit = decimal.MaxValue, TaxPercent = 35 }
        };

    }

    public decimal CalculateAdditionalIncomeTax(decimal baseIncome, decimal additionalIncome)
    {
        decimal taxableIncome = additionalIncome;
        decimal taxResult = 0;

        foreach (var bracket in _taxBrackets)
        {
            if (baseIncome < bracket.UpperLimit)
            {
                decimal taxApplicableIncome = taxableIncome >bracket.UpperLimit - baseIncome ? bracket.UpperLimit - baseIncome : taxableIncome;

                decimal taxAmount = decimal.Divide(taxApplicableIncome * bracket.TaxPercent, 100);

                taxResult += taxAmount;
                taxableIncome = taxableIncome - taxApplicableIncome;

                if (taxableIncome == 0)
                {
                    break;
                }
            }

            baseIncome = Math.Max(0, baseIncome - bracket.UpperLimit);
        }
        return taxResult;
    }
}


