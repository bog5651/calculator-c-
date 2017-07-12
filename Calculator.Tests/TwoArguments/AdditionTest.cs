using calcularot.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class AdditionTest
    {
        [TestCase (2,2,4)]
        [TestCase (2,4,6)]
        [TestCase (2,6,8)]
        public void CalculateTest(double first, double second, double expected)
        {
            var calculator = new Addition();
            Assert.AreEqual(expected,calculator.Calculate(first,second));
        }
    }
}
