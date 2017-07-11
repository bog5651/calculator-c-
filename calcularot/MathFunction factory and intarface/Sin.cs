using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class Sin : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Sin(firstVlue);
        }
    }
}
