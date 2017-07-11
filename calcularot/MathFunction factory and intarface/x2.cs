using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class x2 : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Pow(firstVlue, 2);
        }
    }
}
