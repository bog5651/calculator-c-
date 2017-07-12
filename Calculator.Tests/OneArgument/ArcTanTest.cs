using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class ArcTanTest
    {
        [TestCase(1, 0.785398)]
        [TestCase(0.5, 0.463647)]
        [TestCase(0, 0)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Arctan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
