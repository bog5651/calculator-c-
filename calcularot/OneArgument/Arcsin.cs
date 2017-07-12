using System;

namespace calcularot.OneArgument
{
    public class Arcsin : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Asin(firstVlue);
        }
    }
}
