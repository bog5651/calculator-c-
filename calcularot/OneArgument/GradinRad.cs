using System;

namespace calcularot.OneArgument
{
    public class GradinRad : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return firstVlue * 180 / Math.PI;
        }
    }
}
