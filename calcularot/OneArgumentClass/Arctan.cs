using System;

namespace calcularot.OneArgumentClass
{
    public class Arctan : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Atan(firstVlue);
        }
    }
}
