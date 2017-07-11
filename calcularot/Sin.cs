using System;

namespace calcularot
{
    public class Sin : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Sin(firstVlue);
        }
    }
}
