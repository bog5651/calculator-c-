using calcularot.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class RemainderTest
    {
        [TestCase(1, 1, 0)]
        [TestCase(1, 2, 1)]
        [TestCase(1, 3, 1)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Remainder();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
