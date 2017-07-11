using System;

namespace calcularot
{
    public class Arctan : MathFunction_factory_and_intarface.IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Atan(firstVlue);
        }
    }
}
