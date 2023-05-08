using TaxCalculation.TaxCalculator;

namespace TaxCalculationTest
{
    public class Tests
    {
        private TaxCalculator _taxCalculator;
        [SetUp]
        public void Setup()
        {
            _taxCalculator = new TaxCalculator();
        }

        [Test]
        public void CalculateAdditionalIncomeTax_ReturnsZero_WhenBaseIncomeAndAdditionalIncomeAreBothZero()
        {
            // Arrange
            decimal baseIncome = 0;
            decimal additionalIncome = 0;
            //Act
            decimal result = _taxCalculator.CalculateAdditionalIncomeTax(baseIncome, additionalIncome);
            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateAdditionalIncomeTax_ReturnsZero_WhenAdditionalIncomeIsZero()
        {
         
            decimal baseIncome = 5000;
            decimal additionalIncome = 0;

            decimal result = _taxCalculator.CalculateAdditionalIncomeTax(baseIncome, additionalIncome);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CalculateAdditionalIncomeTax_CalculatesTaxCorrectly_WhenBaseIncomeAndAdditionalIncomeAreBothPositive()
        {
        
            decimal baseIncome = 5000;
            decimal additionalIncome = 3000;

            decimal result = _taxCalculator.CalculateAdditionalIncomeTax(baseIncome, additionalIncome);
            Assert.That(result, Is.EqualTo(900));
        }

        [Test]
        public void CalculateAdditionalIncomeTax_CalculatesTaxCorrectly_WhenBaseIncomeIsZero()
        {
         
            decimal baseIncome = 0;
            decimal additionalIncome = 3000;

            decimal result = _taxCalculator.CalculateAdditionalIncomeTax(baseIncome, additionalIncome);
            Assert.That(result, Is.EqualTo(500));
        }

        [Test]
        public void CalculateAdditionalIncomeTax_CalculatesTaxCorrectly_WhenAdditionalIncomeIsInHighestTaxBracket()
        {
            
            decimal baseIncome = 5000;
            decimal additionalIncome = 10000;

            decimal result = _taxCalculator.CalculateAdditionalIncomeTax(baseIncome, additionalIncome);
            Assert.That(result, Is.EqualTo(3350));
        }

        [Test]
        public void CalculateAdditionalIncomeTax_CalculatesTaxCorrectly_WhenBaseIncomeIsInHighestTaxBracket()
        {

            decimal baseIncome = 10000;
            decimal additionalIncome = 5000;

            decimal result = _taxCalculator.CalculateAdditionalIncomeTax(baseIncome, additionalIncome);
            Assert.That(result, Is.EqualTo(1750));
        }
    }
}