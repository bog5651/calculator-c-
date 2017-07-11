using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public static class TwoArgumentFactory
    {
        public static ITwoArgumentsCalculation CreatCalculation(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Plus":
                    return new Addition();
                case "Minus":
                    return new Substraction();
                case "Multiplire":
                    return new Multiplication();
                case "Division":
                    return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
