using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class ArccosTest
    {
        [TestCase(1, 0)]
        [TestCase(0.5, 1.047197)]
        [TestCase(0, 1.570796)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Arccos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
