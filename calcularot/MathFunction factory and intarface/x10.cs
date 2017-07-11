using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class x10 : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Pow(10, firstVlue);
        }
    }
}
