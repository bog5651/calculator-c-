using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class Log10 : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Log(firstVlue, 10);
        }
    }
}
