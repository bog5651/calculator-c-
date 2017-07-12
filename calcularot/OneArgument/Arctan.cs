using System;

namespace calcularot.OneArgument
{
    public class Arctan : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Atan(firstVlue);
        }
    }
}
