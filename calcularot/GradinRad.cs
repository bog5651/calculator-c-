using System;

namespace calcularot
{
    public class GradinRad : MathFunction_factory_and_intarface.IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return firstVlue * 180 / Math.PI;
        }
    }
}
