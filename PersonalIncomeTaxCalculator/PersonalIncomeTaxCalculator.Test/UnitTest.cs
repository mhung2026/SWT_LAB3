using NUnit.Framework;

namespace PersonalIncomeTaxTests
{
    public class PersonalIncomeTaxTests
    {
        private PersonalIncomeTaxCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new PersonalIncomeTaxCalculator();
        }

        [Test]
        public void Test_NegativeSalary_ReturnsMinusOne()
        {
            float salary = -50000;
            float taxExempt = 100000;
            int dependents = 1;

            float result = _calculator.fncPersonalIncomeTax(salary, taxExempt, dependents);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test_NegativeTaxExempt_ReturnsMinusOne()
        {
            float salary = 10000000;
            float taxExempt = -50000;
            int dependents = 2;

            float result = _calculator.fncPersonalIncomeTax(salary, taxExempt, dependents);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Test_NegativeDependents_ReturnsMinusOne()
        {
            float salary = 15000000;
            float taxExempt = 500000;
            int dependents = -1;

            float result = _calculator.fncPersonalIncomeTax(salary, taxExempt, dependents);

            Assert.AreEqual(-1, result);
        }
        [Test]
        public void Test_NegativeTaxableIncome_ReturnsZero()
        {
            float salary = 9000000;
            float taxExempt = 0;
            int dependents = 0;

            float result = _calculator.fncPersonalIncomeTax(salary, taxExempt, dependents);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void Test_TaxableIncomeLessThanOrEqual5000000_ReturnsCorrectTax()
        {
            float salary = 15000000;
            float taxExempt = 500000;
            int dependents = 1;
            float expectedTax = 75000;

            float result = _calculator.fncPersonalIncomeTax(salary, taxExempt, dependents);

            Assert.AreEqual(expectedTax, result);
        }

        [Test]
        public void Test_TaxableIncomeGreaterThan80000000_ReturnsCorrectTax()
        {
            float salary = 100000000;
            float taxExempt = 5000000;
            int dependents = 0;
            float expectedTax = 9550002;

            float result = _calculator.fncPersonalIncomeTax(salary, taxExempt, dependents);

            Assert.AreEqual(expectedTax, result);
        }

        [Test]
        public void Test_TaxableIncomeGreaterThan40000000_ReturnsCorrectTax()
        {
            float salary = 60000000;
            float taxExempt = 10000000;
            int dependents = 1;
            float expectedTax = 5150000;

            float result = _calculator.fncPersonalIncomeTax(salary, taxExempt, dependents);

            Assert.AreEqual(expectedTax, result);
        }
    }
}