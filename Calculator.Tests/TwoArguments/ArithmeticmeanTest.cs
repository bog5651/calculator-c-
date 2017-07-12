using calcularot.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class ArithmeticmeanTest
    {
        [TestCase(2, 2, 2)]
        [TestCase(2, 4, 3)]
        [TestCase(2, 6, 4)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Arithmeticmean();
            Assert.AreEqual(expected, calculator.Calculate(first, second));
        }
    }
}
