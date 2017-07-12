using calcularot.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class MultiplicationTest
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Multiplication();
            Assert.AreEqual(1, calculator.Calculate(1, 1));
            Assert.AreEqual(-9, calculator.Calculate(3, -3));
        }
    }
}
