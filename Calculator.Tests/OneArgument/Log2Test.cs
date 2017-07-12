using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class Log2Test
    {
        [TestCase(1, 0)]
        [TestCase(0.5, -1)]
        [TestCase(0, double.NegativeInfinity)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Log2();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
