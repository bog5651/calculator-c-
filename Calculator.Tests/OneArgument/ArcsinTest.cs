using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class ArcsinTest
    {
        [TestCase(0, 0)]
        [TestCase(0.5, 0.52359)]
        [TestCase(1, 1.570796)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Arcsin();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
