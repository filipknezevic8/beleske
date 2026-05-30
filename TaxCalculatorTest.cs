using Shouldly;

namespace CalculatorTests
{
    public class TaxCalculatorTest
    {
        [Theory]
        [InlineData(1000, false, 100)]
        [InlineData(1000, true, 120)]
        [InlineData(0, false, 0)]
        [InlineData(0, true, 0)]
        public void Calculate_tax_rate(double amount, bool isCompany, double expectedResult)
        {
            TaxCalculator calculator = new TaxCalculator(0.1);

            double actualResult = calculator.CalculateTax(amount, isCompany);

            actualResult.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(-1000, true)]
        [InlineData(-1000, false)]
        public void CalculateTax_NegativeAmount_ThrowsArgumentException(double amount, bool isCompany)
        {
            TaxCalculator calculator = new TaxCalculator(0.1);
            Should.Throw<ArgumentException>(() => calculator.CalculateTax(amount, isCompany));
        }
    }
}