using System;

namespace calcularot.OneArgumentClass
{
    public class Cos : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Cos(firstVlue);
        }
    }
}
