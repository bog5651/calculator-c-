using calcularot.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class GeometricmeanTest
    {
        [TestCase(2, 2, 2)]
        [TestCase(8, 8, 8)]
        [TestCase(6, 6, 6)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Geometricmean();
            Assert.AreEqual(expected, calculator.Calculate(first, second));
        }
    }
}
