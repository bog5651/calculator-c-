using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class GradinRadTest
    {
        [TestCase(1, 57.29577)]
        [TestCase(0.5, 28.64788)]
        [TestCase(0, 0)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new GradinRad();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
