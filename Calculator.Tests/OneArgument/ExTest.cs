using System;
using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class ExTest
    {
        [TestCase(1, Math.E)]
        [TestCase(0.5, 1.6487212)]
        [TestCase(0, 1)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Ex();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
