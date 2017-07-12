using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class CosGTest
    {
        [TestCase(1, 0.733654)]
        [TestCase(0.5, -0.931035)]
        [TestCase(0, 1)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new CosG();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
