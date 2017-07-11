using System;

namespace calcularot.MathFunction_factory_and_intarface
{
    public class Arccos : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Acos(firstVlue);
        }
    }
}
