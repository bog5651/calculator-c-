using System;

namespace calcularot
{
    public class Log10 : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Log(firstVlue, 10);
        }
    }
}
