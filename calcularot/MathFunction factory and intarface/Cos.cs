using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class Cos : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Cos(firstVlue);
        }
    }
}
