using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    [TestFixture]
    class CalculatorUnitTest
    {
        private Calc m_calculator;

        [SetUp]
        public void Setup()
        {
            m_calculator = new Calc();
        }

        [TestCase(2, 3, 5)]
        [TestCase(4, 3, 7)]
        [TestCase(6, 6, 12)]
        public void AddTests(double a, double b, double result)
        {
            // Act
            double res = m_calculator.Add(a, b);

            // Assert
            Assert.That(res, Is.EqualTo(result));
        }

        [TestCase(2, 3, -1)]
        [TestCase(4, 3, 1)]
        [TestCase(6, 6, 0)]
        public void SubtractTests(double a, double b, double result)
        {
            // Act
            double res = m_calculator.Subtract(6, 2);

            // Assert
            Assert.That(res, Is.EqualTo(4));
        }

        [TestCase(2, 3, 6)]
        [TestCase(4, 3, 12)]
        [TestCase(6, 6, 36)]
        public void MultiplyTests(double a, double b, double result)
        {
            // Act
            double res = m_calculator.Multiply(3, 4);

            // Assert
            Assert.That(res, Is.EqualTo(12));
        }

        [TestCase(2, 3, 8)]
        [TestCase(4, 3, 48)]
        [TestCase(6, 6, 46656)]
        public void PowTests(double a, double b, double result)
        {
            // Act
            double res = m_calculator.Power(5, 3);

            // Assert
            Assert.That(res, Is.EqualTo(125));
        }
    }
}
