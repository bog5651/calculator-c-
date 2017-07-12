using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class RadInGradTest
    {
        [TestCase(1, 0.01745)]
        [TestCase(0.5, 0.008726)]
        [TestCase(0, 0)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new RadinGrad();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}
