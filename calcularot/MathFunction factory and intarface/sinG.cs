using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class SinG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Sin(firstVlue * (180 / Math.PI));
        }
    }
}
