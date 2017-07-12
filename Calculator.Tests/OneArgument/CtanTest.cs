using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class CtanTest
    {
        [TestCase(1, 0.747801)]
        [TestCase(0.5, -3.763768)]
        [TestCase(2, -0.492534)]
        public void CalculateTest(double first, double expected)
        {
            var calculator = new Ctan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.00001);
        }
    }
}
