using System;

namespace calcularot.OneArgumentClass
{
    public class Arcsin : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Asin(firstVlue);
        }
    }
}
