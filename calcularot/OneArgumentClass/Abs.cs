using System;

namespace calcularot.OneArgumentClass
{
    public class Abs : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Abs(firstVlue);
        }
    }
}
