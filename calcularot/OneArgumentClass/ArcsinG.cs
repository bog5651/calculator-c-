using System;

namespace calcularot.OneArgumentClass
{
    public class ArcsinG : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Asin(firstVlue);
        }
    }
}
