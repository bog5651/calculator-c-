using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class CosTest
    {
        [TestCase(1, 0.540302)]
        [TestCase(0.5, 0.877582)]
        [TestCase(0, 1)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Cos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
