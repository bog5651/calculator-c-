using System;

namespace calcularot.OneArgument
{
    public class Log2 : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Log(firstVlue, 2);
        }
    }
}
