using calcularot.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class SubstractionTest
    {
        [TestCase(2, 2, 0)]
        [TestCase(4, 4, 0)]
        [TestCase(6, 2, 4)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Substraction();
            Assert.AreEqual(expected, calculator.Calculate(first, second));
        }
    }
}
