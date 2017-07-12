using calcularot.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class DivisionTest
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Division();
            Assert.AreEqual(1, calculator.Calculate(1, 1));
            Assert.AreEqual(-1, calculator.Calculate(3, -3));
        }
    }
}
