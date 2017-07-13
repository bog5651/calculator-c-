using System;
using calcularot.OneArgument;
using calcularot.TwoArguments;
using NUnit.Framework;

namespace Calculator.Tests.TwoArguments
{
    [TestFixture]
    public class TwoArgumentFactoryTest
    {
        [TestCase("Plus", typeof(Addition))]
        [TestCase("Multiplire", typeof(Multiplication))]
        [TestCase("Division", typeof(Division))]
        public void CalculateTest(string testName, Type expected)
        {
            var calculator = TwoArgumentFactory.CreatCalculation(testName);
            Assert.AreEqual(expected, calculator.GetType());
        }
    }
}
