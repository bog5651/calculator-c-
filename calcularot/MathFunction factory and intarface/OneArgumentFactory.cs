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
                case "SinG":
                    return new SinG();
                case "CosG":
                    return new CosG();
                case "Arcsin":
                    return new ArcsinG();
                case "Arccos":
                    return new Arccos();
                case "Ctan":
                    return new Ctan();
                case "Arctan":
                    return new Arctan();
                case "ArcsinG":
                    return new ArcsinG();
                case "RadinGrad":
                    return new RadinGrad();
                case "GradinRad":
                    return new GradinRad();
                case "Abs":
                    return new Abs();
                default: throw new Exception("Неизвестная операция");
            }
        }
    }
}
