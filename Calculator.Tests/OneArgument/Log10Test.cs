using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class Log10Test
    {
        [TestCase(1, 0)]
        [TestCase(0.5, -0.301029)]
        [TestCase(0, double.NegativeInfinity)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Log10();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
