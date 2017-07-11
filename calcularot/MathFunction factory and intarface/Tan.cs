using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class Tan : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Tan(firstVlue);
        }
    }
}
