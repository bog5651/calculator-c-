using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class SinGTest
    {
        [TestCase(1, 0.679522)]
        [TestCase(0.5, -0.364928)]
        [TestCase(0, 0)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new SinG();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
