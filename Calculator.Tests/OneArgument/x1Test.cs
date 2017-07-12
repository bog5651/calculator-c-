using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class x1Test
    {
        [TestCase(1, 1)]
        [TestCase(2, 0.5)]
        [TestCase(0, double.PositiveInfinity)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new x1();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
