using System;
using Calculator;
using NUnit.Framework;
using Calculator;

namespace Tests
{
    public class Tests
    {
        private Calculator.Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator.Calculator();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestCase(4,2,2)]
        [TestCase(0,0,0)]
        [TestCase(-5,10,-15)]
        public void AddTest(int expected, int addend, int secondAddend)
        {
            var sum = _calculator.Add(addend, secondAddend);
            Assert.AreEqual(expected, sum);
        }

        [TestCase(0, 5, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-5, 10, 15)]
        public void SubtractionTest(int expected, int minuend, int subtrahend)
        {
            var subtraction = _calculator.Subtract(minuend, subtrahend);
            Assert.AreEqual(expected, subtraction);
        }

        [TestCase(0, 5, 0)]
        [TestCase(4, 2, 2)]
        [TestCase(-10, 2, -5)]
        public void MultiplyTest(int expected, int factor, int secondFactor)
        {
            var multiplication = _calculator.Multiply(factor, secondFactor);
            Assert.AreEqual(expected, multiplication);
        }

        [TestCase(0, 0, 5)]
        [TestCase(4, 8, 2)]
        [TestCase(-5, 10, -2)]
        public void DivideTest(int expected, int dividend, int divider)
        {
            var quotient = _calculator.Divide(dividend, divider);
            Assert.AreEqual(expected, quotient);
        }

        [TestCase(1)]
        [TestCase(0)]
        [TestCase(-5)]
        public void DivideByZeroTest(int dividend)
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(dividend, 0));
        }
    }
}