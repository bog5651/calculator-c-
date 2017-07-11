using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class Ln : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Log(firstVlue,Math.E);
        }
    }
}
