using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTests
{
    public class TaxCalculator
    {
        private readonly double baseRate;

        public TaxCalculator(double baseRate)
        {
            this.baseRate = baseRate;
        }

        public double CalculateTax(double amount, bool isCompany)
        {
            if (amount < 0)
                throw new ArgumentException("Iznos ne može biti negativan broj.");

            double effectiveRate = isCompany ? baseRate * 1.2 : baseRate;
            return amount * effectiveRate;
        }
    }
}
