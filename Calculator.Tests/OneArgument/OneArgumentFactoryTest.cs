using System;
using calcularot.OneArgument;
using NUnit.Framework;

namespace Calculator.Tests.OneArgument
{
    [TestFixture]
    public class OneArgumentFactoryTest
    {
        [TestCase("cos", typeof(Cos))]
        [TestCase("sin", typeof(Sin))]
        [TestCase("tan", typeof(Tan))]
        public void CalculateTest(string testName, Type expected)
        {
            var calculator = OneArgumentFactory.CreatCalculation(testName);
            Assert.AreEqual(expected, calculator.GetType());
        }
    }
}
