using System;

namespace calcularot
{
    public static class OneArgumentFactory
    {
        public static IOneArgumentsCalculation CreatCalculation(string CalculationName)
        {
            switch (CalculationName)
            {
                case "sin":
                    return new Sin();
                case "cos":
                    return new Cos();
                case "tan":
                    return new Tan();
                case "Ln":
                    return new Ln();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
