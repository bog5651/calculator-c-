using System;

namespace calcularot
{
    public class Ctan : MathFunction_factory_and_intarface.IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Tan(1 / Math.Tan(firstVlue));
        }
    }
}
