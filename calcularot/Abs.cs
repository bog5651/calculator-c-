using System;

namespace calcularot
{
    public class Abs : MathFunction_factory_and_intarface.IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Abs(firstVlue);
        }
    }
}
