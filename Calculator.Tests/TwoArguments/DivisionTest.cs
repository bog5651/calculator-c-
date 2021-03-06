﻿using calcularot.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DivisionTest
    {
        [TestCase(2, 2, 1)]
        [TestCase(2, 4, 0.5)]
        [TestCase(6, 2, 3)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Division();
            Assert.AreEqual(expected, calculator.Calculate(first, second));
        }
    }
}
