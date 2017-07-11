using System;

namespace calcularot.OneArgumentClass
{
    public class GradinRad : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return firstVlue * 180 / Math.PI;
        }
    }
}
