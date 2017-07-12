using System;

namespace calcularot.OneArgument
{
    public class Cos : IOneArgumentsCalculation
    {
        public double Calculate(double firstVlue)
        {
            return Math.Cos(firstVlue);
        }
    }
}
