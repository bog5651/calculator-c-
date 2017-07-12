using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class AbsTest
    {
        [TestCase(2, 2)]
        [TestCase(-2, 2)]
        [TestCase(-52, 52)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Abs();
            Assert.AreEqual(expected, calculator.Calculate(first));
        }
    }
}
