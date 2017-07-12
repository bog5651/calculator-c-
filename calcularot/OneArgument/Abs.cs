using System;

namespace calcularot.OneArgument
{
    public class Abs : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Abs(firstVlue);
        }
    }
}
