using System;

namespace calcularot.OneArgumentClass
{
    public class Sin : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Sin(firstVlue);
        }
    }
}
