using System;

namespace calcularot
{
    public class Log2 : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Log(firstVlue, 2);
        }
    }
}
