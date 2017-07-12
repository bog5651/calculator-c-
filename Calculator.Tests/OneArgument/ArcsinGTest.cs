using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class ArcsinGTest
    {
        [TestCase(1, 1.570796)]
        [TestCase(0.5, 0.523598)]
        [TestCase(0, 0)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new ArcsinG();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
