using System;

namespace calcularot.OneArgument
{
    public class ArcsinG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Asin(firstVlue);
        }
    }
}
