using System;

namespace calcularot.OneArgument
{
    public class Sin : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Sin(firstVlue);
        }
    }
}
