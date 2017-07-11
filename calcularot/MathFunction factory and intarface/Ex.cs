using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class Ex : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Pow(Math.E,firstVlue);
        }
    }
}
