using calcularot.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class MultiplicationTest
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 4, 8)]
        [TestCase(2, 6, 12)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Multiplication();
            Assert.AreEqual(expected, calculator.Calculate(first, second));
        }
    }
}
