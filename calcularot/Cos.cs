using System;

namespace calcularot
{
    public class Cos : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Cos(firstVlue);
        }
    }
}
