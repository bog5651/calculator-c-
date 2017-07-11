using System;

namespace calcularot
{
    public class Tan : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Tan(firstVlue);
        }
    }
}
