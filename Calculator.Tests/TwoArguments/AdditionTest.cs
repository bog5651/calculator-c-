using System.Dynamic;
using calcularot.TwoArguments;
using NUnit.Framework;


namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class AdditionTest
    {
        [Test]
        public void CalculateTest()
        {
            var calculator = new Addition();
            Assert.AreEqual(2,calculator.Calculate(1,1));
            Assert.AreEqual(0, calculator.Calculate(3, -3));
        }
    }
}
