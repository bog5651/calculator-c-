using System;

namespace calcularot.MathFunction_factory_and_intarface
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
                case "ex":
                    return new Ex();
                case "Log2":
                    return new Log2();
                case "Log10":
                    return new Log10();
                case "x2":
                    return new x2();
                case "x10":
                    return new x10();
                case "x1":
                    return new x1();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
