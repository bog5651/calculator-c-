using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class LnTest
    {
        [TestCase(1, 0)]
        [TestCase(0.5, -0.693147)]
        [TestCase(0.1,-2.302585 )]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Ln();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
