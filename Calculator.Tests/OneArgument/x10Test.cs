using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class x10Test
    {
        [TestCase(1, 10)]
        [TestCase(2, 100)]
        [TestCase(0, 1)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new x10();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
